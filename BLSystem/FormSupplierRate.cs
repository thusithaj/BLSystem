using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BLSystem
{
    public partial class FormSupplierRate : Form
    {
        PMModel contxt;
        SqlConnection sqlcn;
        SqlCommand cmd;
        string tabName;
        DataTable table;
        int RegNo;
        decimal rate;
        bool isActive, isBogus;

        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public FormSupplierRate()
        {
            InitializeComponent();
        }

        private void FormSupplierRate_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            state = FORMSTATE.NOOP;
            isFormLoading = false;
        }

        private void SetMonthTable()
        {
            //tabName = "Main_Reg_" + dtM.Value.Year.ToString().Trim() + "_" + String.Format("{0:MMM}", dtM.Value);
            tabName = "Main_Reg";

        }

        private void dtM_Validated(object sender, EventArgs e)
        {
            SetMonthTable();
            try
            {
                GetSuppliers();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Month \n" + ex.Message);
            }
        }

        private void cboSup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!isFormLoading)
            {
                DataRowView dvr = (DataRowView)cboSup.SelectedItem;
                RegNo = int.Parse( dvr["RegNo"].ToString());
                rate = decimal.Parse(dvr["DeductionRate"].ToString()== "" ? "0" : dvr["DeductionRate"].ToString());
                isActive = bool.Parse(dvr["isACtive"].ToString() =="" ? "false": dvr["isACtive"].ToString());
                isBogus = bool.Parse(dvr["isBogus"].ToString() == "" ?"false" : dvr["isBogus"].ToString());
                tbSupName.Text = dvr["RegName"].ToString();
                lR.Text= dvr["RouteName"].ToString();
                isNew = false; isEdit = true;
                state = FORMSTATE.EDIT;
                nDRate.Value = rate; chkActive.Checked = isActive;
                chkBL.Checked = isBogus;
                SetButtons();
                
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New feature is not supported");

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkBL.Checked = false;
            }
        }

        private void chkBL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBL.Checked)
            {
                chkActive.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateValues();
                MessageBox.Show("Updating was successful \n" );
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured during updating \n" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            contxt.Database.Connection.Close();
            this.Close();
        }

        private void cboSup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                nDRate.Focus();
            }
        }

        private void nDRate_Enter(object sender, EventArgs e)
        {
            nDRate.Select(0, nDRate.Value.ToString().Length + 3);
        }

        private void cboSup_Enter(object sender, EventArgs e)
        {
            cboSup.Select(0,cboSup.Text.Length);
        }

        private void GetSuppliers()
        {
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection) contxt.Database.Connection;
            SqlDataAdapter sqlda = new SqlDataAdapter();
            cmd = new SqlCommand();
            string sql = "Select * From " + tabName + " Order by RegNo" ;
            table = new DataTable();
            cmd.CommandText = sql;
            cmd.Connection = sqlcn;
            if (contxt.Database.Connection.State == ConnectionState.Closed)
                contxt.Database.Connection.Open();
            sqlda.SelectCommand = cmd;
            //SqlDataReader reader = cmd;
            sqlda.Fill(table);
            cboSup.DataSource = table;
            cboSup.DisplayMember = "RegNo";
            cboSup.ValueMember = "RegNo";
            contxt.Database.Connection.Close();
        }
        private void UpdateValues()
        {
            rate = nDRate.Value;
            isActive = chkActive.Checked;
            isBogus = chkBL.Checked;
            string sql = " Update " + tabName + " Set isActive = " + (isActive == true ? "1" : "0") + ", isBogus = " + (isBogus == true ? "1" : "0") +
                " , DeductionRate =" + rate.ToString() + " Where RegNo =" + RegNo.ToString();
            cmd = new SqlCommand();
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            cmd.CommandText = sql;
            cmd.Connection = sqlcn;
            if (contxt.Database.Connection.State == ConnectionState.Closed)
                contxt.Database.Connection.Open();
            cmd.ExecuteNonQuery();
            contxt.Database.Connection.Close();
        }
    }
}
