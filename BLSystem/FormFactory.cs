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
    public partial class FormFactory : Form
    {
        CompanyMaster company;
        List<CompanyMaster> companies;
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
            GetCompanyList();
            state = FORMSTATE.NOOP;
            SetButtons();
            isEdit = false; isNew = false;
            panelMid.Enabled = false;
            isFormLoading = false;
        }
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
