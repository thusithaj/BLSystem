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
    public partial class FormExtraEntry : Form
    {
        PMModel contxt;
        List<RouteMaster> routes;
        RouteMaster route;
        DataTable table;
        SqlConnection sqlcn;
        SqlCommand cmd;
        SqlDataAdapter da;
        string sql;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        bool isFormLoading = true;
        public FormExtraEntry()
        {
            InitializeComponent();
        }

        private void FormExtraEntry_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            routes = new List<RouteMaster>();
            route = new RouteMaster();
            state = FORMSTATE.NOOP;
            ShowRoutes();
            isFormLoading = false;

        }

        private void ShowRoutes()
        {
            routes = contxt.RouteMasters.ToList();
            cboRoute.DataSource = routes;
            cboRoute.DisplayMember = "rName";
            cboRoute.ValueMember = "ind";

            //throw new NotImplementedException();
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isFormLoading)
            {
                route = (RouteMaster)cboRoute.SelectedItem;
                GetSuppliersList();
            }
        }

        private void GetSuppliersList()
        {
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            sql = " Select regNo [Supplier No],RegName [Supplier Name],TotKg [To Date Qty] " +
                " From Main_Reg where isnull(isactive,0) = 0 and RTRIM(LTRIM(routename)) ='" + route.rName.Trim() + "'";
            cmd = new SqlCommand( sql,sqlcn);
            contxt.Database.Connection.Open();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            dgvSup.DataSource = null;
            dgvSup.DataSource = table;
            chkLSup.Items.Clear();

            foreach ( DataRow dr in table.Rows)
            {
                chkLSup.Items.Add(dr["Supplier No"].ToString() + " " + dr["Supplier Name"].ToString());
            }
            contxt.Database.Connection.Close();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DistributeQty();
                MessageBox.Show("Quantity distribution saved successfully");
                GetSuppliersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantity distribution retruned an Error \n " + ex.Message,
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DistributeQty()
        {
            string sp_name = " RandDistribute " + nQty.Value.ToString() + ",'" + string.Format("{0:yyyy-MM-dd}", dtM.Value) + "','" +
                route.rName + "',9," + nFiltDay.Value.ToString() + "," + nFiltQty.Value.ToString();
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            cmd = new SqlCommand(sp_name, sqlcn);
            contxt.Database.Connection.Open();
            cmd.ExecuteNonQuery();
            contxt.Database.Connection.Close();
            
        }

        private void GetDistributedData()
        {
            sql = " select c.trDate,c.regNo,c.Route RouteName,c.Name RegName,c.Qty from Collection_tbl C inner join " +
                " main_reg m on c.regNo = m.regNo where c.Route =  '" + route.rName.Trim() + "' " +
                " AND(isnull(isACtive, 0) = 0) AND c.TrDate ='" + String.Format("{0:yyyy-MM-dd}", dtM.Value) + "'" ;
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            cmd = new SqlCommand(sql, sqlcn);
            contxt.Database.Connection.Open();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            contxt.Database.Connection.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormPrint formPrint = new FormPrint();
            formPrint.Owner = this;
            formPrint.ReportName = "DistributionReport.rpt";
            GetDistributedData();
            formPrint.table = table;
            formPrint.PrintState = 1;
            formPrint.WindowState = FormWindowState.Maximized;
            formPrint.Show();
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
