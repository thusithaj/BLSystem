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
    public partial class FormFiscalPeriod : Form
    {
        PMModel contxt;
        FiscalPeriod period;
        List<FiscalPeriod> periods;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        DataTable status;
        bool isFormLoading = true;

        public FormFiscalPeriod()
        {
            InitializeComponent();
        }

        private void FormFiscalPeriod_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            period = new FiscalPeriod();
            LoadPeriods();
            LoadStatus();
            isNew = false; isEdit = false;

            isFormLoading = false;

        }

        private void LoadStatus()
        {
            status = new DataTable();
            status.Columns.Add(new DataColumn("id", typeof(int)));
            status.Columns.Add(new DataColumn("Status", typeof(string)));
            status.Rows.Add(status.NewRow());
            status.Rows[status.Rows.Count - 1]["id"] = 0;
            status.Rows[status.Rows.Count - 1]["Status"] = "Open";
            status.Rows.Add(status.NewRow());
            status.Rows[status.Rows.Count - 1]["id"] = 1;
            status.Rows[status.Rows.Count - 1]["Status"] = "Updated";
            status.Rows.Add(status.NewRow());
            status.Rows[status.Rows.Count - 1]["id"] = 2;
            status.Rows[status.Rows.Count - 1]["Status"] = "Closed";
            status.Rows.Add(status.NewRow());
            status.Rows[status.Rows.Count - 1]["id"] = 9;
            status.Rows[status.Rows.Count - 1]["Status"] = "Incative";
            cboStatus.DataSource = status;
            cboStatus.DisplayMember = "Status";
            cboStatus.ValueMember = "id";
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isFormLoading)
            {
                DataRowView dr =(DataRowView) cboStatus.SelectedItem;
                period.Status = int.Parse(dr["id"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNew = true; isEdit = false;
            panelMid.Enabled = true;
            state = FORMSTATE.ADD;
            SetButtons();
            dtM.Focus();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetContents();
            try
            {
                Save();
                MessageBox.Show(" Record Saved ");
                isNew = false; isEdit=false ;
                state = FORMSTATE.NOOP;
                SetButtons();
                LoadPeriods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Record Not Saved \n" + ex.Message);
            }
        }

        private void Save()
        {
            if (isNew)
            {
                contxt.FiscalPeriods.Add(period);
                contxt.Entry(period).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
                contxt.Entry(period).Reload();
            }
            if (isEdit)
            {
                FiscalPeriod ptemp = contxt.FiscalPeriods.FirstOrDefault(o => o.id == period.id);
                if (ptemp != null)
                {
                    ptemp.FromDate = period.FromDate;
                    ptemp.Todate = period.Todate;
                    ptemp.Status = period.Status;
                    contxt.Entry(ptemp).State = System.Data.Entity.EntityState.Modified;
                    contxt.SaveChanges();
                    contxt.Entry(period).Reload();
                }
            }
            //throw new NotImplementedException();
        }

        private void GetContents()
        {
            period.FromDate = new DateTime(dtM.Value.Year, dtM.Value.Month, 1);
            period.Todate = period.FromDate.Value.AddMonths(1).AddDays(-1);
            
            //throw new NotImplementedException();
        }

        private void dgvFP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isFormLoading)
            {
                period = (FiscalPeriod)dgvFP.Rows[e.RowIndex].DataBoundItem;
                isNew = false; isEdit = true;
                state = FORMSTATE.EDIT;
                SetButtons();
                ShowObject();
            }
        }

        private void ShowObject()
        {
            dtM.Value = period.FromDate.Value;
            cboStatus.SelectedValue = period.Status;
            //throw new NotImplementedException();
        }

        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctxCopy_Click(object sender, EventArgs e)
        {
            dgvFP.SelectAll();
            dgvFP.DoDragDrop(dgvFP.DataSource, DragDropEffects.Copy);
        }

        private void LoadPeriods()
        {
            periods = contxt.FiscalPeriods.ToList();
            dgvFP.DataSource = null;

            dgvFP.DataSource = periods;
            //throw new NotImplementedException();
        }
    }
}
