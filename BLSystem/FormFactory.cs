using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq.Expressions;

namespace BLSystem
{
    public partial class FormFactory : Form
    {
        CompanyMaster company;
        List<CompanyMaster> companies;
        FactoryMaster factory;
        List<FactoryMaster> factories;
        PMModel contxt;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public FormFactory()
        {
            InitializeComponent();
        }

        private void FormFactory_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            company = new CompanyMaster();
            companies = new List<CompanyMaster>();
            factory = new FactoryMaster();
            factories = new List<FactoryMaster>();
            GetCompanyList();
            GetFactoryList();
            
            ///tbFacName.MaxLength = from meta in contxt.FactoryMasters.Me
            state = FORMSTATE.NOOP;
            SetButtons();
            isEdit = false; isNew = false;
            panelMid.Enabled = false;
            isFormLoading = false;
        }

        private void GetFactoryList()
        {
            if ( contxt.FactoryMasters.ToList().Count > 0)
            {
                factories = contxt.FactoryMasters.ToList();
                dgvFac.DataSource = null;

                dgvFac.AutoGenerateColumns = false;
                dgvFac.DataSource = factories;

            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Get List of Companies
        /// </summary>
        private void GetCompanyList()
        {
            if (contxt.CompanyMasters.ToList().Count > 0 && isFormLoading)
            {
                companies = contxt.CompanyMasters.ToList();
                cboCom.DataSource = companies;
                cboCom.DisplayMember = "CompanyName";
                cboCom.ValueMember = "id";
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            state = FORMSTATE.ADD;
            SetButtons();
            panelMid.Enabled = true;
            cboCom.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNew = false; isEdit = true;
            state = FORMSTATE.EDIT;
            SetButtons();
            ShowContents();
            panelMid.Enabled = true;
            cboCom.Focus();
            
        }

        private void ShowContents()
        {
            tbFacName.Text = factory.FactoryName;
            company = companies.Where(o => o.id == factory.CompanyId).FirstOrDefault();
            if (company != null)
                cboCom.SelectedItem = company;
            //throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //GetContents();
            try
            {
                Save();
                MessageBox.Show(" Factory " + factory.FactoryName + " Saved Successfully");
                isEdit = false; isNew = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                panelMid.Enabled = false;
                //isEdit = false; isNew = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Company " + factory.FactoryName + "did not Save. An error occurred \n " + ex.Message);

            }

        }
        private void Save()
        {
            GetContents();
            if (isNew)
            {

                contxt.FactoryMasters.Add(factory);
                contxt.SaveChanges();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;

                SetButtons();
            }
            if (isEdit)
            {
                FactoryMaster fac = contxt.FactoryMasters.Where(
                    o => o.id == factory.id).FirstOrDefault();
                if (fac != null)
                {

                    fac.FactoryName = factory.FactoryName;
                    fac.CompanyId = factory.CompanyId;

                    contxt.SaveChanges();
                    isNew = false; isEdit = false;
                    state = FORMSTATE.NOOP;
                    SetButtons();
                }
            }
            GetFactoryList();
        }

        private void GetContents()
        {
            factory.FactoryName = tbFacName.Text;
            factory.CompanyId = company.id;
            //throw new NotImplementedException();
        }

        private void cboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = (CompanyMaster)cboCom.SelectedItem;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFac_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            factory = (FactoryMaster) dgvFac.Rows[e.RowIndex].DataBoundItem;
            btnEdit_Click(sender, new EventArgs());
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
