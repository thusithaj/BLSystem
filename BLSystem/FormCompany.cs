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
    public partial class FormCompany : Form
    {
        CompanyMaster company;
        List<CompanyMaster> companies;
        PMModel contxt;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public FormCompany()
        {
            InitializeComponent();
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            company = new CompanyMaster();
            companies = new List<CompanyMaster>();
            GetCompanyList();
            state = FORMSTATE.NOOP;
            SetButtons();
            isEdit = false; isNew = false;
            panelMid.Enabled = false;
            isFormLoading = false;
        }

        private void GetCompanyList()
        {
            if ( contxt.CompanyMasters.ToList().Count > 0 && isFormLoading)
            {
                companies = contxt.CompanyMasters.ToList();
                dgvCo.DataSource = companies;
            }
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
        private void Save()
        {
            GetContents();
            if (isNew)
            {
                
                contxt.CompanyMasters.Add(company);
                contxt.SaveChanges();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;

                SetButtons();
            }
            if (isEdit)
            {
                CompanyMaster com = contxt.CompanyMasters.Where(
                    o => o.id == company.id).FirstOrDefault();
                if (com != null)
                {
                    
                    com.CompanyName = company.CompanyName;
                    
                    contxt.SaveChanges();
                    isNew = false; isEdit = false;
                    state = FORMSTATE.NOOP;
                    SetButtons();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            state = FORMSTATE.ADD;
            SetButtons();
            ClearContents();
            panelMid.Enabled = true;
            tbCompany.Focus();
        }

        private void ClearContents()
        {
            tbCompany.Text = "";
            //throw new NotImplementedException();
        }

        private void dgvCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            company = (CompanyMaster) dgvCo.Rows[e.RowIndex].DataBoundItem;
            isEdit = true; isNew = false;
            state = FORMSTATE.EDIT;
            SetButtons();
            ShowContents();
            panelMid.Enabled = true;
        }

        private void ShowContents()
        {
            tbCompany.Text = company.CompanyName;
            //throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                MessageBox.Show(" Company " + company.CompanyName + " Saved Successfully");
                isEdit = false; isNew = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                panelMid.Enabled = false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(" Company " + company.CompanyName + "did not Save. An error occurred \n " + ex.Message );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetCompanyList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetContents()
        {
            company.CompanyName = tbCompany.Text;
            //throw new NotImplementedException();
        }
    }
}
