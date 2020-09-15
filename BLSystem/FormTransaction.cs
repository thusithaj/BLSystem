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
    public partial class FormTransaction : Form
    {
        SupplierLedger ledger;
        PMModel contxt;
        DataTable trType;
        Product product;
        List<Product> products;
        List<AddressBook> partners;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        string Trntype { get; set; }
        bool isFormLoading = true;
        List<SupplierLedger> sessionList;
        AddressBook partner;
        public string formMode { get; set; }
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            partners = new List<AddressBook>();
            partner = new AddressBook();
            products = new List<Product>();
            ledger = new SupplierLedger();
            sessionList = new List<SupplierLedger>();
            GetTrnType();
            GetProducts();
            
            state = FORMSTATE.NOOP;
            SetButtons();
            isEdit = false; isNew = false;
            panelMid.Enabled = false;
            dtTrnDate.Value = DateTime.Now;
            GetCurrentMonthTrn();
            isFormLoading = false;
            SetGridProperties();

        }

        private void GetCurrentMonthTrn()
        {
            sessionList = contxt.SupplierLedgers.Where(o => o.Ref01.Trim() == Trntype && 
                    o.TrnDate.Month==dtTrnDate.Value.Month).ToList();
            dgvSes.DataSource = sessionList;
            //throw new NotImplementedException();
        }

        private void SetGridProperties()
        {
            dgvSes.AllowUserToAddRows = false;
            dgvSes.AllowUserToDeleteRows = false;
            dgvSes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSes.MultiSelect = false;
            dgvSes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //throw new NotImplementedException();
        }

        private void GetAddressBook()
        {
            if (Trntype == "Purchase" || Trntype =="Sales")
            {
                partners = contxt.AddressBooks.Where(o => o.AddressBookType.Category01.Trim() == Trntype).ToList();
                cboSup.DataSource = partners;
                cboSup.DisplayMember = "AddressName";
                cboSup.ValueMember = "id";
            }
            else
            {
                partners = contxt.AddressBooks.Where(o => o.AddressBookType.Category01.Trim() != Trntype).ToList();
                cboSup.DataSource = partners;
                cboSup.DisplayMember = "AddressName";
                cboSup.ValueMember = "id";

            }
            

        }
        private void GetTrnType()
        {
            trType = new DataTable();
            trType.Columns.Add(new DataColumn("TrnType", typeof(string)));
            switch(formMode)
            {
                case "Purchase":
                    {
                        trType.Rows.Add(trType.NewRow());
                        trType.Rows[trType.Rows.Count - 1]["TrnType"] = "Purchase";
                        Trntype = formMode;
                        lts.Text = "Supplier :";
                    }
                    break;
                case "Sales":
                    {
                        trType.Rows.Add(trType.NewRow());
                        trType.Rows[trType.Rows.Count - 1]["TrnType"] = "Sales";
                        Trntype = formMode;
                        lts.Text = "Customer :";
                    }
                    break;
                default:
                    {
                        trType.Rows.Add(trType.NewRow());
                        trType.Rows[trType.Rows.Count - 1]["TrnType"] = "Financial";
                        lts.Text = "Partner :";
                    }
                    break;

            }
            
            cboTrType.DataSource = trType;
            cboTrType.DisplayMember = "TrnType";
            cboTrType.ValueMember = "TrnType";
            cboTrType.SelectedItem = Trntype;
            GetAddressBook();
            GetProducts();
            //throw new NotImplementedException();
        }

        private void GetProducts()
        {
            if (contxt.Products.ToList().Count > 0 )
            {
                if (Trntype == "Purchase" || Trntype == "Sales")
                    products = contxt.Products.Where(o=>o.TransactionType.Trim()=="DEBIT").ToList();
                else
                    products = contxt.Products.Where(o => o.TransactionType.Trim() == "CREDIT").ToList();
                cboProduct.DataSource = products;
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "id";
            }
            //throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = FORMSTATE.ADD;
            SetButtons();
            panelMid.Enabled = true;
            isNew = true; isEdit = false;
            cboTrType.Focus();

        }
        private void FillObjects()
        {
            ledger.ProductId = product.id;
            ledger.SupplierId = contxt.SupplierMasters.FirstOrDefault(o => o.AddressBookId == partner.id).id; ;
            ledger.RouteId =(int) contxt.SupplierMasters.FirstOrDefault(o => o.AddressBookId == partner.id).RouteId;
            ledger.Quantity = nQty.Value;
            if (product.TransactionType.Trim() =="CREDIT")
                ledger.TotalPrice = nAmt.Value * -1;
            else
                ledger.TotalPrice = nAmt.Value;
            ledger.TrnDate = dtTrnDate.Value;
            ledger.Ref01 = Trntype;
            ledger.Ref02 = tbRef.Text;
        }
        private void Save()
        {
            if (isNew)
            {
                ledger.CreatedBy = 1;
                ledger.CreatedDate = DateTime.Now;
                contxt.SupplierLedgers.Add(ledger);
                contxt.Entry(ledger).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                contxt.Entry(ledger).Reload();
                sessionList.Add(ledger);
            }
            if (isEdit)
            {
                SupplierLedger led = contxt.SupplierLedgers.FirstOrDefault(o => o.id == ledger.id);
                if (led != null)
                {
                    led.ModifiedBy = 1;
                    led.ModifiedDate = DateTime.Now;
                    led.ProductId = ledger.ProductId;
                    led.Quantity = ledger.Quantity;
                    led.Ref01 = ledger.Ref01;
                    led.Ref02 = ledger.Ref02;
                    led.SupplierId = ledger.SupplierId;
                    led.TotalPrice = ledger.TotalPrice;
                    led.TrnDate = ledger.TrnDate;
                    led.UnitPrice = ledger.UnitPrice;
                    contxt.Entry(led).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    contxt.Entry(ledger).Reload();
                }
            }
            ShowSession();

        }

        private void ShowSession()
        {

            GetCurrentMonthTrn();
            //dgvSes.DataSource = sessionList;
            //throw new NotImplementedException();
        }

        private void cboTrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isFormLoading)
            {
                DataRowView dv = (DataRowView) cboTrType.SelectedItem;
                Trntype = dv[0].ToString();
                GetProducts();
                //GetAddressBook();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillObjects();
            try
            {
                Save();
                MessageBox.Show("Data saving was successful");
                ledger = new SupplierLedger();
                isEdit = false; isNew = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                ClearControls();
                panelMid.Enabled = false;
                btnAdd.Focus();

            }catch (Exception ex)
            {
                MessageBox.Show(" Data saving returned an error \n" + ex.Message + "\n" + ex.InnerException.InnerException.Message);
            }
        }

        private void ClearControls()
        {
            nQty.Value = 0.00M;
            nAmt.Value = 0.00M;
            tbRef.Text = "";
            
            //throw new NotImplementedException();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoading)
            {
                product = (Product)cboProduct.SelectedItem;
            }
        }

        private void cboSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoading)
            {
                partner = (AddressBook)cboSup.SelectedItem;
            }
        }

        private void cboTrType_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cboTrType_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                cboTrType_SelectedIndexChanged(sender, new EventArgs());
                dtTrnDate.Focus();
            }
        }

        private void dtTrnDate_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                cboProduct.Focus();
            }
        }

        private void cboProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                cboProduct_SelectedIndexChanged(sender, new EventArgs());
                cboSup.Focus();
            }
        }

        private void cboSup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                cboSup_SelectedIndexChanged(sender, new EventArgs());
                nQty.Focus();
            }
        }

        private void nAmt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
               tbRef.Focus();
            }
        }

        private void nQty_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                nAmt.Focus();
            }
        }

        private void tbRef_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            btnSave_Click(sender, new EventArgs());
        }

        private void btnAdd_KeyUp(object sender, KeyEventArgs e)
        {
            btnAdd_Click(sender, new EventArgs());
        }

        private void cboTrType_Enter(object sender, EventArgs e)
        {
            cboTrType.SelectAll();
        }

        private void dtTrnDate_Enter(object sender, EventArgs e)
        {
            dtTrnDate.Select();
        }

        private void cboProduct_Enter(object sender, EventArgs e)
        {
            cboProduct.SelectAll();
        }

        private void cboSup_Enter(object sender, EventArgs e)
        {
            cboSup.SelectAll();
        }

        private void nQty_Enter(object sender, EventArgs e)
        {
            nQty.Select(0, nQty.Value.ToString().Length + 3);
        }

        private void nAmt_Enter(object sender, EventArgs e)
        {
            nAmt.Select(0, nAmt.Value.ToString().Length + 3);
        }

        private void tbRef_Enter(object sender, EventArgs e)
        {
            tbRef.SelectAll();
        }

        private void dgvSes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ledger =(SupplierLedger) dgvSes.Rows[e.RowIndex].DataBoundItem;
            ShowContents();
            isNew = false; isEdit = true;
            state = FORMSTATE.EDIT;
            panelMid.Enabled = true;
            SetButtons();

        }

        private void ShowContents()
        {
            dtTrnDate.Value = ledger.TrnDate;
            product = products.FirstOrDefault(o => o.id == ledger.ProductId);
            SupplierMaster supplier = contxt.SupplierMasters.FirstOrDefault(o => o.id == ledger.SupplierId);
            partner = partners.FirstOrDefault(o => o.id == supplier.AddressBookId);
            cboSup.SelectedItem = partner;
            cboProduct.SelectedItem = product;
            cboSup.SelectedItem = partner;
            nQty.Value = ledger.Quantity;
            nAmt.Value =(decimal) ledger.TotalPrice;
            tbRef.Text = ledger.Ref02;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Setting up command buttons based on the form state
        /// </summary>
        private void SetButtons()
        {
            switch (state)
            {
                case FORMSTATE.NOOP:
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnRefresh.Enabled = true;
                    btnSave.Enabled = false;
                    break;
                case FORMSTATE.ADD:
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnSave.Enabled = true;
                    break;
                case FORMSTATE.EDIT:
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnSave.Enabled = true;
                    break;
                case FORMSTATE.DELETE:
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnSave.Enabled = false;
                    break;
                default:
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnRefresh.Enabled = true;
                    btnSave.Enabled = false;
                    break;
            }
        }
    }
}
