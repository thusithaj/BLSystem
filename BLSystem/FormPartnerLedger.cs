using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows;
namespace BLSystem
{
    public partial class FormPartnerLedger : Form
    {
        PMModel contxt;
        List<AddressBook> partners;
        AddressBook partner;
        public string ReportName { get; set; }
        CrystalDecisions.CrystalReports.Engine.ReportDocument report;
        public FormPartnerLedger()
        {
            InitializeComponent();
        }

        private void FormPartnerLedger_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            partners = new List<AddressBook>();
            partner = new AddressBook();
            GetPartners();
        }

        private void GetPartners()
        {
            string sql = "Select a.* From AddressBook a Inner Join SupplierMaster M On a.id = m.AddressBookId";
            partners = contxt.Database.SqlQuery<AddressBook>(sql).ToList();
            cboPartner.DataSource = partners;
            cboPartner.DisplayMember = "AddressName";
            cboPartner.ValueMember = "id";
            cboPartner.SelectedItem = null;
            //throw new NotImplementedException();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintPreView();

        }
        private void PrintPreView()
        {
            var cmd = contxt.Database.Connection.CreateCommand();
            //System.Data.Common.DataAdapter da = new System.Data.Common.DataAdapter();

            string spName = "";
            //var DataReport;
            if (partner.id == 0)
            {
                spName = "PartnerLedger " + dtMonth.Value.Month + ", -1";
                //DataReport = contxt.Database.SqlQuery(spName,dtMonth.Value.Month, -1).ToList() 
            }
            else
            {
                spName = "PartnerLedger " + dtMonth.Value.Month + ", " + contxt.SupplierMasters.FirstOrDefault(o => o.AddressBookId == partner.id);
            }
            cmd.CommandText = spName;
            //cmd.ExecuteReader();
            contxt.Database.Connection.Open();
            report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            report.Load(ReportName);
            report.SetDataSource((IDataReader)cmd.ExecuteReader());
            report.SetParameterValue("MonthName", String.Format("{0:MMM-yyyy}", dtMonth.Value));
            crv.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach (CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {

                crv.ParameterFieldInfo.Add(fld);

            }
            crv.ReportSource = report;

        }
    }
}
