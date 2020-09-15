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
    public partial class FormRouteMaster : Form
    {
        PMModel contxt;
        RouteMaster route;
        List<RouteMaster> routes;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        //bool isFormLoading = true;

        public FormRouteMaster()
        {
            InitializeComponent();
        }

        private void FormRouteMaster_Load(object sender, EventArgs e)
        {
            state = FORMSTATE.NOOP;
            SetButtons();
            isNew = false; isEdit = false;
            contxt = new PMModel();
            LoadRoutes();
            route = new RouteMaster();
            panelMid.Enabled = false;
        }

        private void LoadRoutes()
        {
            routes = contxt.RouteMasters.ToList();
            cboRoute.DataSource = null;
            dgvR.DataSource = null;
            cboRoute.DataSource = routes;
            cboRoute.DisplayMember = "rName";
            cboRoute.ValueMember = "ind";
            dgvR.DataSource = routes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (routes.Count > 0)
            {
                MessageBox.Show("Adding new Routes is not enabled! Editing and updating is valid");
            }
            else
            {
                isNew = true; isEdit = false;
                state = FORMSTATE.ADD;
                SetButtons();
                panelMid.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true; isNew = false;
            state = FORMSTATE.EDIT;
            SetButtons();
            ShowObject();
            panelMid.Enabled = true;
            cboRoute.Focus();
        }

        private void ShowObject()
        {
            if (route == null || route.ind == 0) return;
            cboRoute.SelectedItem = route;
            chkActive.Checked =(bool) route.trActive ;
            nDRate.Value = route.DdRate;
            //throw new NotImplementedException();
        }

        private void GetObject()
        {
            route.rName = cboRoute.Text;
            route.trActive =(bool) chkActive.Checked;
            route.DdRate = nDRate.Value;
        }
        private void Save()
        {
            if (isNew)
            {
                contxt.RouteMasters.Add(route);
                contxt.Entry(route).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                contxt.Entry(route).Reload();
            }
            if(isEdit)
            {
                RouteMaster r = contxt.RouteMasters.FirstOrDefault(o => o.ind == route.ind);
                if (r != null)
                {
                    r.rName = route.rName;
                    r.rCode = route.rCode == "" ? "NNN" : route.rCode;
                    r.trActive = route.trActive;
                    r.DdRate = route.DdRate;
                    contxt.Entry(r).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    contxt.Entry(route).Reload();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetObject();
            try
            {
                Save();
                isNew = false; isEdit = false;
                state = FORMSTATE.NOOP;
                SetButtons();
                MessageBox.Show("Record Saved successfully");
                panelMid.Enabled = false;
                routes = contxt.RouteMasters.ToList();
                dgvR.Refresh();
                //LoadRoutes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Record saving returned an error \n" + ex.Message);
            }
        }

        private void dgvR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            route = (RouteMaster) dgvR.Rows[e.RowIndex].DataBoundItem;
            btnEdit_Click(sender, new EventArgs());
        }

        private void dgvR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvR_CellContentClick(sender, e);
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoute.SelectedItem != null )
            {
                route = (RouteMaster)cboRoute.SelectedItem;
                ShowObject();
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
