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
    public partial class FormSupplierMaster : Form
    {
        PMModel contxt;
        AddressBookType bookType;
        AddressBook address;
        AddressBook route;
        SupplierMaster supplier;
        List<SupplierMaster> suppliers;
        FactoryMaster factory;
        List<AddressBookType> bookTypes;
        List<AddressBook> addresses;
        List<FactoryMaster> factories;
        List<AddressBook> routes;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public string TypeName { get; set; }
        public FormSupplierMaster()
        {
            InitializeComponent();
        }

        private void FormSupplierMaster_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            bookType = new AddressBookType();
            bookTypes = new List<AddressBookType>();
            addresses = new List<AddressBook>();
            routes = new List<AddressBook>();
            factories = new List<FactoryMaster>();
            address = new AddressBook();
            route = new AddressBook();
            factory = new FactoryMaster();
            supplier = new SupplierMaster();
            //TypeName = "Suppliers";
            GetAddressBookTypeList();
            GetRoutes();
            GetFactories();
            state = FORMSTATE.NOOP;
            SetButtons();
            panelMid.Enabled = false;
            AdjustFields();
            LoadPartners();
            isFormLoading = false;
        }

        private void LoadPartners()
        {
            dgvPatner.DataSource = contxt.AddressBooks.Where(o => o.AddressBookType.BookTypeName.Trim() == TypeName).ToList();
            //throw new NotImplementedException();
        }

        private void AdjustFields()
        {
            if (TypeName == "Customers")
            {
                lwfn.Text = "Ref No :";
                chkbSaving.Visible = false;
                chkbWF.Visible = false;
                lWD.Visible = false;
                ls.Visible = false;
                dtWRegDate.Visible = false;
                dtSDate.Visible = false;
                tc01.TabPages[0].Text = TypeName;
            }
            //throw new NotImplementedException();
        }

        private void GetRoutes()
        {
            routes = contxt.AddressBooks.Where(o => o.AddressBookType.BookTypeName == "Route").ToList();
            cboRoute.DataSource = routes;
            cboRoute.DisplayMember = "AddressName";
            cboRoute.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void GetAddressBookTypeList()
        {
            if (contxt.AddressBookTypes.ToList().Count > 0 && isFormLoading)
            {
                bookTypes = contxt.AddressBookTypes.Where(o=>o.BookTypeName.Trim() == TypeName).ToList();
                cboType.DataSource = bookTypes;
                cboType.DisplayMember = "BookTypeName";
                cboType.ValueMember = "id";
            }
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
                contxt.Entry(address).Reload();
                
                supplier.CreatedDate = DateTime.Now;
                supplier.CreatedBy = 1;
                supplier.AddressBookId = address.id;
                contxt.SupplierMasters.Add(supplier);
                contxt.Entry(supplier).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                

            }
            if (isEdit)
            {
                // Update mechanism should be coded
                AddressBook book = contxt.AddressBooks.Where(o => o.id == address.id).FirstOrDefault();
                if(book != null)
                {
                    book.AddressLine01 = address.AddressLine01;
                    book.AddressLine02 = address.AddressLine02;
                    book.AddressName = address.AddressName;
                    book.AddressType = address.AddressType;
                    book.City = address.City;
                    book.ModifiedBy = 1;
                    book.ModifiedDate = DateTime.Now;
                    contxt.Entry(book).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    SupplierMaster master = contxt.SupplierMasters.Where(o => o.id == supplier.id).FirstOrDefault();
                    if(master != null)
                    {
                        master.AddressBookId = address.id;
                        master.ModifiedBy = 1;
                        master.ModifiedDate = DateTime.Now;
                        master.RegNo = supplier.RegNo;
                        master.SavingRegDate = supplier.SavingRegDate;
                        master.SavingRegistered = supplier.SavingRegistered;
                        master.WelfareId = supplier.WelfareId;
                        master.WelfareRegDate = supplier.WelfareRegDate;
                        master.WelfareRegistered = supplier.WelfareRegistered;
                        master.Status = supplier.Status;
                        contxt.Entry(master).State = System.Data.Entity.EntityState.Modified;
                        contxt.SaveChanges();

                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            state = FORMSTATE.ADD;
            panelMid.Enabled = true;
            SetButtons();
            cboType.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNew = false; isEdit = true;
            state = FORMSTATE.EDIT;
            panelMid.Enabled = true;
            SetButtons();
            cboType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetContents();
            try
            {
                Save();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                MessageBox.Show("Supplier Saved successfully");
                panelMid.Enabled = false;
                btnAdd.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Supplier added returned an Error \n" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            ImportOldData();
        }

        private void ImportOldData()
        {

            //System.Data.OleDb.OleDbConnection olecn;
            //System.Data.OleDb.OleDbCommand olecmd;
            //System.Data.OleDb.OleDbDataAdapter oleda;
            //string oldcn = System.Configuration.ConfigurationManager.ConnectionStrings["blold"].ConnectionString;
            //olecn = new System.Data.OleDb.OleDbConnection(oldcn);
            string sql = "Select * from Main_Reg";
            DataTable olds = new DataTable();
            Application.UseWaitCursor = true;
            OldBlObj old = new OldBlObj();
            olds = old.GetDataTable(sql);
            int reccnt = olds.Rows.Count;
            int intval = reccnt / 100;
            int newsup = 0;
            reccnt = 0;
            foreach ( DataRow dr in olds.Rows)
            {
                supplier.RegNo = int.Parse(dr["RegNo"].ToString());
                supplier.PayMode = dr["PayMode"].ToString();
                supplier.BankAccount = dr["AcNumber"].ToString();
                supplier.SavingRegistered = int.Parse(dr["SavingReg"].ToString()== "True" ? "1" :"0");
                supplier.WelfareRegistered = dr["WelfareReg"].ToString() == "Yes" ? 1 : 0;
                supplier.FactoryId = factory.id;
                DateTime rd;
                if (DateTime.TryParse(dr["RegDate"].ToString(), out rd))
                {
                    supplier.RegDate = rd;
                }
                route = routes.Where(o => o.AddressName.Trim() == dr["RouteName"].ToString().Trim()).FirstOrDefault();
                if (route == null)
                {
                    throw new Exception("The route is not registered");
                }
                else
                {
                    supplier.RouteId = route.id;
                }
                //if (dr["WelfareReg"].ToString() == "Yes")
                //    supplier.WelfareRegDate= DateTime.Parse(dr[])
                SupplierMaster stemp = contxt.SupplierMasters.FirstOrDefault(o => o.RegNo == supplier.RegNo);
                if (stemp == null)
                {
                    isNew = true; isEdit = false;
                    address.CreatedBy = 1;
                    address.CreatedDate = DateTime.Now;
                    contxt.AddressBooks.Add(address);
                    contxt.Entry(address).State = System.Data.Entity.EntityState.Added;
                    contxt.SaveChanges();
                    contxt.Entry(address).Reload();

                    supplier.CreatedDate = DateTime.Now;
                    supplier.CreatedBy = 1;
                    supplier.AddressBookId = address.id;

                    contxt.SupplierMasters.Add(supplier);
                    
                    contxt.Entry(supplier).State = System.Data.Entity.EntityState.Added;
                    newsup++;
                    
                }
                else
                { isNew = false; isEdit = true;
                    AddressBook atemp = contxt.AddressBooks.Where(o => o.id == stemp.AddressBookId).FirstOrDefault();
                    if (atemp == null)
                    {
                        address.AddressType = bookType.id;
                        address.FactoryId = factory.id;
                        address.AddressName = dr["RegName"].ToString();
                        address.AddressLine01 = dr["Address"].ToString();
                        address.TP01 = dr["TPno"].ToString();
                        address.CreatedBy = 1;
                        address.CreatedDate = DateTime.Now;
                        contxt.AddressBooks.Add(address);
                        contxt.Entry(address).State = System.Data.Entity.EntityState.Added;
                        contxt.SaveChanges();
                        contxt.Entry(address).Reload();
                    }
                    address.AddressType = bookType.id;
                    address.FactoryId = factory.id;
                    address.id = atemp.id;
                    address.AddressName = dr["RegName"].ToString();
                    address.AddressLine01 = dr["Address"].ToString();
                    address.TP01 = dr["TPno"].ToString();
                    address.ModifiedBy = 1;
                    address.ModifiedDate = DateTime.Now;
                    contxt.Entry(atemp).CurrentValues.SetValues(address);
                    contxt.SaveChanges();
                    // Here we are going to update supplier
                    supplier.id = stemp.id;
                    supplier.AddressBookId = address.id;
                    supplier.ModifiedBy = 1;
                    supplier.ModifiedDate = DateTime.Now;
                    contxt.Entry(stemp).CurrentValues.SetValues(supplier);
                    contxt.SaveChanges();

                }
                
                reccnt++;
                int upd = reccnt % 100 == 0 ? pgb.Value++ : 0;
                pgb.Refresh();
                address = new AddressBook();
                supplier = new SupplierMaster();

            }
            Application.UseWaitCursor = false;
            MessageBox.Show(" Suppliers imported =" + newsup);
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookType = (AddressBookType) cboType.SelectedItem;
        }

        private void cboFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory =(FactoryMaster) cboFactory.SelectedItem;
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            route = (AddressBook)cboRoute.SelectedItem;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPatner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            address = (AddressBook) dgvPatner.Rows[e.RowIndex].DataBoundItem;
            supplier = contxt.SupplierMasters.FirstOrDefault(o => o.AddressBookId == address.id);
            ShowContents();
            state = FORMSTATE.EDIT;
            isNew = false;isEdit = true;
            SetButtons();
            panelMid.Enabled = true;
        }

        private void ShowContents()
        {
            tbName.Text = address.AddressName;
            tbAL01.Text = address.AddressLine01;
            tbAL02.Text = address.AddressLine02;
            tbCity.Text = address.City;
            bookType = bookTypes.FirstOrDefault(o => o.id == address.AddressType);
            cboType.SelectedItem = bookType;
            factory = factories.FirstOrDefault(o => o.id == address.FactoryId);
            nRegNo.Value = supplier.RegNo;
            chkbSaving.Checked = supplier.SavingRegistered == 1 ? true : false;
            chkbWF.Checked= supplier.WelfareRegistered == 1 ? true : false;
            chkbStatus.Checked = supplier.Status == 1 ? true : false;
            chkbDel.Checked = supplier.Deleted == 1 ? true : false;
            route = routes.FirstOrDefault(o => o.id == supplier.RouteId);
            dtRegDate.Value = supplier.RegDate.Value;
            tbWelfareId.Text = supplier.WelfareId;
            //throw new NotImplementedException();
        }

        private void GetContents()
        {
            address.AddressName = tbName.Text;
            address.AddressLine01 = tbAL01.Text;
            address.AddressLine02 = tbAL02.Text;
            address.City = tbCity.Text;
            address.AddressType = bookType.id;
            address.FactoryId = factory.id;
            supplier.FactoryId = factory.id;
            supplier.RegNo = (int) nRegNo.Value;
            supplier.SavingRegistered = chkbSaving.Checked ? 1 : 0;
            supplier.WelfareRegistered = chkbWF.Checked ? 1 : 0;
            supplier.Status = chkbStatus.Checked ? 1 : 0;
            supplier.Deleted = chkbDel.Checked ? 1 : 0;
            supplier.RouteId = route.id;
            supplier.RegDate = dtRegDate.Value;
            supplier.WelfareId = tbWelfareId.Text;
        }
    }
}
