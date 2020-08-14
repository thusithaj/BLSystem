using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLSystem
{
    public partial class FormImportTrn : Form
    {
        OldBlObj old;
        SupplierLedger ledger;
        RouteQty ledgerMaster;
        AddressBook route;
        PMModel contxt;
        DataTable table;

        public FormImportTrn()
        {
            InitializeComponent();
        }

        private void FormImportTrn_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            ledger = new SupplierLedger();
            ledgerMaster = new RouteQty();
            route = new AddressBook();
        }

        private void ImportQty()
        {
            string sql = "Select * from Collection_tbl where Month(trDate)=" + dtM.Value.Month +
                " Order By trDate ";
            int i = 0, idiv = 0;
            table = new DataTable();
            old = new OldBlObj();
            table = old.GetDataTable(sql);
            idiv = table.Rows.Count / 100;
            foreach(DataRow dr in table.Rows)
            {
                int supno = int.Parse(dr["RegNo"].ToString());
                string routeName = dr["Route"].ToString().Trim();
                SupplierMaster supplier = contxt.SupplierMasters.FirstOrDefault(o => o.RegNo == supno);
                route = contxt.AddressBooks.FirstOrDefault(e => e.AddressName.Trim() == routeName );
                ledgerMaster.SupplierId = supplier.id;
                ledgerMaster.RouteId = route.id;
                ledgerMaster.Trndate = DateTime.Parse(dr["trDate"].ToString());
                RouteQty rqTemp = contxt.RouteQties.FirstOrDefault(r => r.SupplierId == supplier.id && r.RouteId == route.id &&
                r.Trndate.Value.Month == ledgerMaster.Trndate.Value.Month);
                if (rqTemp == null)
                {
                    contxt.RouteQties.Add(ledgerMaster);
                    contxt.Entry(ledgerMaster).State = System.Data.Entity.EntityState.Added;
                    contxt.SaveChanges();
                    contxt.Entry(ledgerMaster).Reload();

                }
                else
                {
                    rqTemp.Quantity = rqTemp.Quantity + decimal.Parse(dr["Qty"].ToString());
                    contxt.Entry(rqTemp).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    ledgerMaster.id = rqTemp.id;
                }
                Product product = contxt.Products.FirstOrDefault(p => p.ProductName.Trim() == "Green Leaf");
                ledger.ProductId = product.id;
                ledger.SupplierId = supplier.id;
                ledger.RouteId = route.id;
                ledger.Quantity = decimal.Parse(dr["Qty"].ToString());
                ledger.TrnDate= DateTime.Parse(dr["trDate"].ToString());
                ledger.Ref01 = dr["Vehicale"].ToString();
                ledger.CreatedBy = 1;
                ledger.CreatedDate = DateTime.Now;
                contxt.SupplierLedgers.Add(ledger);
                contxt.Entry(ledger).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                ledger = new SupplierLedger();
                ledgerMaster = new RouteQty();
                i++;
                pgbQty.Value += i % idiv == 0 ?  1: 0;
                lmsgQ.Text = string.Format("Importing record {0,6}", i);
            }
        }

        private void btnImpQty_Click(object sender, EventArgs e)
        {
            ImportQty();
        }
    }
}
