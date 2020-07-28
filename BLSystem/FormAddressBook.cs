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
        FactoryMaster factory;
        List<AddressBookType> bookTypes;
        List<AddressBook> addresses;
        List<FactoryMaster> factories;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        OldBlObj old;
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
            factories = new List<FactoryMaster>();
            address = new AddressBook();
            factory = new FactoryMaster();
            GetAddressBookTypeList();
            GetFactories();
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            isFormLoading = false;
            panelMBot.Visible = false;
            
        }

        private void GetFactories()
        {
            if (contxt.FactoryMasters.ToList().Count >0)
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
                if (bookType.BookTypeName.Trim().ToLower() =="route")
                {
                    panelMBot.Visible = true;
                }
                else
                {
                    panelMBot.Visible = false;
                }
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
            
            if (isNew)
            {
                address.CreatedBy = 1;
                address.CreatedDate = DateTime.Now;
                contxt.AddressBooks.Add(address);
                contxt.Entry(address).State = System.Data.Entity.EntityState.Added;
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
                factory = (FactoryMaster)cboFactory.SelectedItem;
                if(factory.id == 0)
                {
                    MessageBox.Show("Call add factory Form Here");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetContents();
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            GetOldRoutes();
        }

        private void GetOldRoutes()
        {
            old = new OldBlObj();
            string sql = " Select * from Route_List";
            DataTable oldr = new DataTable();
            oldr = old.GetDataTable(sql);
            int reccnt = 0;
            if ( oldr.Rows.Count >0 )
            {
                this.Cursor = Cursors.WaitCursor;
                foreach( DataRow dr in oldr.Rows)
                {
                    address.AddressType = bookType.id;
                    string routeName = dr["rName"].ToString().Trim();
                    address.AddressName = routeName;
                    address.AddressLine01 = address.AddressName;
                    address.FactoryId = factory.id;
                    
                    AddressBook abtemp = contxt.AddressBooks.FirstOrDefault(
                        o => o.AddressName.Trim() == routeName && o.AddressType == bookType.id);
                    
                    if (abtemp == null)
                    {
                        //isNew = true; isEdit = false;
                        //Save();
                        address.CreatedBy = 1;
                        address.CreatedDate = DateTime.Now;
                        contxt.AddressBooks.Add(address);
                        contxt.Entry(address).State = System.Data.Entity.EntityState.Added;

                    }
                    else
                    {
                        //isNew = false; isEdit = true;
                        address.id = abtemp.id;
                        abtemp.ModifiedBy = 1;
                        abtemp.ModifiedDate = DateTime.Now;
                        abtemp.AddressName = address.AddressName;
                        abtemp.AddressLine01 = address.AddressLine01;
                        abtemp.AddressLine02 = address.AddressLine02;
                        abtemp.AddressBookType = address.AddressBookType;
                        abtemp.AddressType = bookType.id;
                        contxt.Entry(abtemp).CurrentValues.SetValues(address);// = System.Data.Entity.EntityState.Modified;
                        
                        abtemp = null;
                    }
                    contxt.SaveChanges();
                    reccnt++;
                    if (reccnt % 100 == 0)
                        pgAb.Value++;
                    pgAb.Refresh();
                    address = new AddressBook();
                    //Application.
                }
                lmsg.Text = reccnt.ToString() + " Record updated";
                if (reccnt < 100)
                    pgAb.Value = pgAb.Value +( 100 - pgAb.Value) ;
                pgAb.Refresh();
                this.Cursor = Cursors.Default;
                
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
