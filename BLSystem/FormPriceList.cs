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
    public partial class FormPriceList : Form
    {
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
        PriceList priceList;
        PriceListType priceType;
        public FormPriceList()
        {
            InitializeComponent();
        }

        private void FormPriceList_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            partners = new List<AddressBook>();
            partner = new AddressBook();
            products = new List<Product>();
            sessionList = new List<SupplierLedger>();
            priceList = new PriceList();
            priceType = new PriceListType();
            Trntype = formMode;
            GetTrnType();
            GetProducts();
            ShowPriceList();
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            isFormLoading = false;

        }
        private void GetProducts()
        {
            if (contxt.Products.ToList().Count > 0)
            {
                if (Trntype == "Purchase" || Trntype == "Sales")
                    products = contxt.Products.Where(o => o.TransactionType.Trim() == "DEBIT").ToList();
                else
                    products = contxt.Products.Where(o => o.TransactionType.Trim() == "CREDIT").ToList();
                cboProduct.DataSource = products;
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "id";
            }
            //throw new NotImplementedException();
        }
        private void GetTrnType()
        {
            //trType = new DataTable();
            //trType.Columns.Add(new DataColumn("TrnType", typeof(string)));
            priceType = contxt.PriceListTypes.FirstOrDefault(o => o.ListTypeName == Trntype);
            

            //cboTrType.DataSource = trType;
            //cboTrType.DisplayMember = "TrnType";
            //cboTrType.ValueMember = "TrnType";
            //cboTrType.SelectedItem = Trntype;
            GetAddressBook();
            GetProducts();
            //throw new NotImplementedException();
        }

        private void cboTrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trntype = formMode;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            product = (Product) cboProduct.SelectedItem;
        }

        private void cboSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoading)
            {
                partner = (AddressBook)cboSup.SelectedItem;
            }
        }

        private void GetAddressBook()
        {
            if (Trntype == "Purchase" || Trntype == "Sales")
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
            cboSup.SelectedItem = null;
        }
        private void FillObject()
        {
            priceList.CreatedBy = 1;
            priceList.CreatedDate = DateTime.Now;
            if (partner != null )
                priceList.PartnerId = contxt.SupplierMasters.FirstOrDefault(o=>o.AddressBookId== partner.id).id;
            priceList.PriceListType = priceType.id;
            priceList.ProductId = product.id;
            priceList.Price = nAmt.Value;
            priceList.EffectFrom = dtFrom.Value;
            priceList.EffectTo = dtTo.Value;
            priceList.Status = chkActive.Checked ? 1 : 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillObject();
            try
            {
                Save();
                partner = null;
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                panelMid.Enabled = false;
                MessageBox.Show(" Data saved successfully");
                ShowPriceList();
                btnAdd.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show(" Data saving retuned error \n" + ex.Message + "\n" + ex.InnerException.InnerException.Message);
            }
        }

        private void ShowPriceList()
        {
            dgvSes.AutoGenerateColumns = false;
            dgvSes.DataSource = contxt.PriceLists.Where(o => o.PriceListType1.ListTypeName == Trntype).ToList();

            //throw new NotImplementedException();
        }

        private void Save()
        {
            if ( isNew)
            {
                contxt.PriceLists.Add(priceList);
                contxt.Entry(priceList).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                contxt.Entry(priceList).Reload();
            }
            if(isEdit)
            {
                PriceList ptmp = contxt.PriceLists.FirstOrDefault(o => o.id == priceList.id);
                if(ptmp!=null)
                {
                    ptmp.ModifiedBy = 1;
                    ptmp.ModifiedDate = DateTime.Now;
                    ptmp.PartnerId = priceList.PartnerId;
                    ptmp.ProductId = priceList.ProductId;
                    ptmp.Status = priceList.Status;
                    ptmp.PriceListType = priceList.PriceListType;
                    ptmp.EffectFrom = priceList.EffectFrom;
                    ptmp.EffectTo = priceList.EffectTo;
                    contxt.Entry(ptmp).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    contxt.Entry(priceList).Reload();
                }
            }
            //throw new NotImplementedException();
        }

        private void ShowObject()
        {
            cboSup.SelectedItem = partners.FirstOrDefault(o => o.id == priceList.PartnerId);
            cboProduct.SelectedItem = products.FirstOrDefault(o => o.id == priceList.ProductId);
            dtFrom.Value = priceList.EffectFrom.Value;
            dtTo.Value = priceList.EffectTo.Value;
            nAmt.Value = (decimal) priceList.Price;
            chkActive.Checked = priceList.Status == 1 ? true : false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true;isEdit = false;
            state = FORMSTATE.ADD;
            SetButtons();
            panelMid.Enabled = true;
            cboProduct.Focus();
        }

        private void dgvSes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            priceList = (PriceList)dgvSes.Rows[e.RowIndex].DataBoundItem;
            ShowObject();
            isNew = false; isEdit = true;
            state = FORMSTATE.EDIT;
            SetButtons();
            panelMid.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.Value = dtFrom.Value.AddMonths(1).AddDays((dtFrom.Value.Day ) * -1);
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
