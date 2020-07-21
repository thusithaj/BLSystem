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
    public partial class FormAddressBook : Form
    {
        PMModel contxt;
        AddressBookType bookType;
        AddressBook address;
        Factory factory;
        List<AddressBookType> bookTypes;
        List<AddressBook> addresses;
        List<Factory> factories;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public FormAddressBook()
        {
            InitializeComponent();
        }

        private void FormAddressBook_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            bookType = new AddressBookType();
            bookTypes = new List<AddressBookType>();
            addresses = new List<AddressBook>();
            factories = new List<Factory>();
            address = new AddressBook();
            factory = new Factory();
            GetAddressBookTypeList();
            GetFactories();
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            isFormLoading = false;
            
        }

        private void GetFactories()
        {
            if (contxt.Factories.ToList().Count >0)
            {
                factories = contxt.Factories.ToList();
                
            }
            else
            {
                Factory newFac = new Factory();
                newFac.FactoryName = "New";
                newFac.id = 0;
                factories.Add(newFac);

            }
            cboFactory.DataSource = factories;
            cboFactory.DisplayMember = "FactoryName";
            cboFactory.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void GetAddressBookTypeList()
        {
            if (contxt.AddressBookTypes.ToList().Count > 0)
            {
                bookTypes = contxt.AddressBookTypes.ToList();
                cboType.DataSource = bookTypes;
                cboType.DisplayMember = "BookTypeName";
                cboType.ValueMember = "id";
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedItem != null && !isFormLoading)
            {
                bookType = (AddressBookType)cboType.SelectedItem;
                GetAddressList();
            }

        }

        private void GetAddressList()
        {
            if (contxt.AddressBooks.Where(
                o => o.AddressBookType.id == bookType.id).ToList().Count > 0)
            addresses = contxt.AddressBooks.Where(
                o => o.AddressBookType.id == bookType.id).ToList();
            dgvAB.AutoGenerateColumns = false;
            dgvAB.DataSource = addresses;
            //throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            panelMid.Enabled = true;
            state = FORMSTATE.ADD;
            SetButtons();
            cboType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                address.CreatedBy = 1;
                address.CreatedDate = DateTime.Now;
                contxt.AddressBooks.Add(address);
                contxt.SaveChanges();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;
                
                SetButtons();
            }
            if (isEdit)
            {
                AddressBook book = contxt.AddressBooks.Where(
                    o => o.id == address.id).FirstOrDefault();
                if (book != null)
                {
                    book.ModifiedBy = 1;
                    book.ModifiedDate = DateTime.Now;
                    book.AddressName = address.AddressName;
                    book.AddressLine01 = address.AddressLine01;
                    book.AddressLine02 = address.AddressLine02;
                    book.AddressBookType = address.AddressBookType;
                    contxt.SaveChanges();
                    isNew = false; isEdit = false;
                    state = FORMSTATE.NOOP;
                    SetButtons();
                }
            }
        }

        private void cboFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboFactory.SelectedItem != null && !isFormLoading)
            {
                factory = (Factory)cboFactory.SelectedItem;
                if(factory.id == 0)
                {
                    MessageBox.Show("Call add factory Form Here");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                MessageBox.Show(" Record Saved ");
                cboType_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Record Not Saved \n" + ex.Message);
            }
            
        }

        private void GetContents()
        {
            address.AddressType = bookType.id;
            address.AddressName = tbName.Text;
            address.AddressLine01 = tbAL01.Text;
            address.AddressLine02 = tbAL02.Text;
            if (factory.id != 0)
                address.FactoryId = factory.id;
            //throw new NotImplementedException();
        }
    }
}
