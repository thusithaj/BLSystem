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
    public partial class FormProducts : Form
    {
        PMModel contxt;
        FactoryMaster factory;
        Product product;
        List<Product> products;

        List<FactoryMaster> factories;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public string TypeName { get; set; }
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            factories = new List<FactoryMaster>();
            factory = new FactoryMaster();
            products = new List<Product>();
            product = new Product();
            GetFactories();
            GetProducts();
            isNew = false; isEdit = false;
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            isFormLoading = false;
        }

        private void GetProducts()
        {
            if (contxt.Products.ToList().Count > 0)
            {
                products = contxt.Products.OrderBy(o=>o.PrintOrder ).ToList();
                dgvPrd.DataSource = null;
                dgvPrd.AutoGenerateColumns = false;
                dgvPrd.DataSource = products;
            }
            //throw new NotImplementedException();
        }

        private void GetFactories()
        {
            if (contxt.FactoryMasters.ToList().Count > 0)
            {
                factories = contxt.FactoryMasters.ToList();

            }
            else
            {
                FactoryMaster newFac = new FactoryMaster();
                newFac.FactoryName = "New";
                newFac.id = 0;
                factories.Add(newFac);

            }
            cboFactory.DataSource = factories;
            cboFactory.DisplayMember = "FactoryName";
            cboFactory.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void cboFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory = (FactoryMaster)cboFactory.SelectedItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            state = FORMSTATE.ADD;
            SetButtons();
            panelMid.Enabled = true;
            cboFactory.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNew = false; isEdit = true;
            state = FORMSTATE.EDIT;
            SetButtons();
            ShowContents();
            panelMid.Enabled = true;
        }

        private void ShowContents()
        {
            cboFactory.SelectedItem = factory;
            tbPName.Text = product.ProductName.Trim();
            cboTrnType.SelectedIndex = product.TransactionType == "DEBIT" ? 0 : 1;
            tbUOM.Text = product.UOM1;
            nOrder.Value = 0M;
            nOrder.Value =decimal.Parse( product.PrintOrder.ToString());
            //throw new NotImplementedException();
        }

        private void dgvPrd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            product =(Product) dgvPrd.Rows[e.RowIndex].DataBoundItem;
            btnEdit_Click(sender, new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetContents();
            try
            {
                Save();
                isEdit = false;isNew = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                MessageBox.Show("Record saving for " + product.ProductName.Trim() + " is successful");
                btnRefresh_Click(sender, e);
                panelMid.Enabled = false;
                btnAdd.Focus();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Record saving for " + product.ProductName + " is returned an error \n " +
                    ex.Message);
            }
            
        }

        private void GetContents()
        {
            product.FactoryId = factory.id;
            product.ProductName = tbPName.Text;
            product.UOM1 = tbUOM.Text;
            product.PrintOrder = (int)nOrder.Value;
            //throw new NotImplementedException();
        }

        private void cboTrnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoading)
                product.TransactionType =  cboTrnType.SelectedItem.ToString();
            //product.TransactionType = dvr[0].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isNew = false; isEdit = false;
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPName_Enter(object sender, EventArgs e)
        {
            tbPName.Select(0, tbPName.Text.Length);
        }

        private void dgvPrd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPrd_CellContentDoubleClick(sender, e);
        }

        private void Save()
        {
            if (isNew)
            {
                product.CreatedBy = 1;
                product.CreatedDate = DateTime.Now;
                contxt.Products.Add(product);
                contxt.Entry(product).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
            }
            if (isEdit)
            {
                Product ptemp = contxt.Products.Where(o => o.id == product.id).FirstOrDefault();
                if (ptemp != null)
                {
                    ptemp.Conversion = product.Conversion;
                    ptemp.FactoryId = product.FactoryId;
                    ptemp.ModifiedBy = 1;
                    ptemp.ModifiedDate = DateTime.Now;
                    ptemp.PrintOrder = product.PrintOrder;
                    ptemp.ProductName = product.ProductName;
                    ptemp.TransactionType = product.TransactionType;
                    ptemp.UOM1 = product.UOM1;
                    ptemp.UOM2 = product.UOM2;
                    contxt.Entry(ptemp).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();

                }
            }
        }
    }
}
