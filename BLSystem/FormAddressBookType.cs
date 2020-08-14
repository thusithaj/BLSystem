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
    public partial class formAddressBookType : Form
    {
        PMModel contxt;
        AddressBookType bookType;
        List<AddressBookType> bookTypes;
        CompanyMaster company;
        List<CompanyMaster> companies;
        bool isNew=false, isEdit= false;
        enum FORMSTATE {  ADD,EDIT,VIEW,DELETE,NOOP};
        FORMSTATE state;
        public formAddressBookType()
        {
            InitializeComponent();
        }

        private void formAddressBookType_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            bookType = new AddressBookType();
            bookTypes = new List<AddressBookType>();
            company = new CompanyMaster();
            companies = new List<CompanyMaster>();
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            GetAddressBookTypeList();
            GetCompanyList();
        }
        private void GetCompanyList()
        {
            if (contxt.CompanyMasters.ToList().Count > 0)
            {
                companies = contxt.CompanyMasters.ToList();
                cboCom.DataSource = companies;
                cboCom.DisplayMember = "CompanyName";
                cboCom.ValueMember = "id";
            }
            //throw new NotImplementedException();
        }
        private void GetAddressBookTypeList()
        {
            if (contxt.AddressBookTypes.ToList().Count > 0)
            {
                bookTypes = contxt.AddressBookTypes.ToList();
                dgvType.AutoGenerateColumns = false;
                dgvType.DataSource = bookTypes;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saving/updating form data to the database
        /// </summary>
        private void Save()
        {
            if(isNew)
            {
                bookType.CreatedBy = 1;
                bookType.CreatedDate = DateTime.Now;
                contxt.AddressBookTypes.Add(bookType);
                contxt.SaveChanges();
            }
            if (isEdit)
            {
                AddressBookType type = contxt.AddressBookTypes.Where
                    (o => o.id == bookType.id).FirstOrDefault();
                if ( type != null)
                {
                    type.BookTypeName = bookType.BookTypeName;
                    type.Category01 = bookType.Category01;
                    type.Category02 = bookType.Category02;
                    type.Category03 = bookType.Category03;
                    type.Category04 = bookType.Category04;
                    type.Category05 = bookType.Category05;
                    type.ModifiedBy = 1;
                    type.ModifiedDate = DateTime.Now;
                    contxt.SaveChanges();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            state = FORMSTATE.ADD;
            SetButtons();
            panelMid.Enabled = true;
            ClearContents();
            tbABTypeName.Focus();
        }

        private void ClearContents()
        {
            tbABTypeName.Text = "";
            tbCat01.Text = "";
            tbCat02.Text = "";
            tbCat03.Text = "";
            //throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateValues();
            try
            {
                Save();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                ClearContents();
                panelMid.Enabled = false;
                MessageBox.Show(" Record Saved ");
            }
            catch( Exception ex)
            {
                MessageBox.Show(" Record Not Saved \n" + ex.Message);
            }
        }

        private void UpdateValues()
        {
            bookType.BookTypeName = tbABTypeName.Text;
            bookType.Category01 = tbCat01.Text;
            bookType.Category02 = tbCat02.Text;
            bookType.Category03 = tbCat03.Text;
            bookType.CompanyId = company.id;
            //throw new NotImplementedException();
        }

        private void dgvType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            bookType =(AddressBookType) dgvType.Rows[e.RowIndex].DataBoundItem;
            ShowRowContents();
            btnEdit_Click(sender, new EventArgs());

        }

        private void ShowRowContents()
        {
            tbABTypeName.Text = bookType.BookTypeName;
            tbCat01.Text = bookType.Category01;
            tbCat02.Text = bookType.Category02;
            tbCat03.Text = bookType.Category03;
            if (bookType.CompanyId != null)
            {
                company = companies.Where(o => o.id == bookType.CompanyId).FirstOrDefault();
                cboCom.SelectedItem = company;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true; isNew = false;
            state = FORMSTATE.EDIT;
            SetButtons();
            panelMid.Enabled = true;
            tbABTypeName.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvType.DataSource = null;
            dgvType.Refresh();
            GetAddressBookTypeList();
        }

        private void tbABTypeName_Enter(object sender, EventArgs e)
        {
            tbABTypeName.Select(0, tbABTypeName.Text.Length);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isEdit = false;isNew = false;
            state = FORMSTATE.NOOP;
            SetButtons();
            ClearContents();
            panelMid.Enabled = false;
        }

        private void cboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            company =(CompanyMaster) cboCom.SelectedItem;
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
