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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace BLSystem
{
    public partial class FormTC12 : Form
    {
        PMModel contxt;
        List<RouteMaster> routes;
        RouteMaster route;
        SqlConnection sqlcn;
        SqlDataAdapter da;
        SqlCommand cmd;
        string sql;
        bool isFormLoading = true;
        //int SuppplierFrom = 0, SupplierTo = 0;
        public string ReportName { get; set; }
        public DataTable table { get; set; }
        int activeStat = 0;

        ReportDocument report;

        public FormTC12()
        {
            InitializeComponent();
        }

        private void lSNFrom_Click(object sender, EventArgs e)
        {

        }

        private void FormTC12_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            routes = new List<RouteMaster>();
            route = new RouteMaster();

            LoadRoutes();
            LoadAct();
            report = new ReportDocument();
            report.Load(Application.StartupPath + "\\" + ReportName);
            isFormLoading = false;
            nSupTo.Value = 99999999;
        }

        private void LoadAct()
        {
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("id", typeof(int)));
            data.Columns.Add(new DataColumn("Stat", typeof(string)));
            data.Rows.Add(data.NewRow());
            data.Rows[data.Rows.Count - 1]["id"] = 0;
            data.Rows[data.Rows.Count - 1]["Stat"] = "Inactive";
            data.Rows.Add(data.NewRow());
            data.Rows[data.Rows.Count - 1]["id"] = 1;
            data.Rows[data.Rows.Count - 1]["Stat"] = "Active";
            cboAct.DataSource = data;
            cboAct.DisplayMember = "Stat";
            cboAct.ValueMember = "id";

            //throw new NotImplementedException();
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!isFormLoading)
            //{
               
            //}
            route = (RouteMaster)cboRoute.SelectedItem;
            if (route.rName == "All")
                route.rName = "%";
        }

        private void LoadRoutes()
        {
            RouteMaster rtemp = new RouteMaster();
            rtemp.rName = "All";
            rtemp.ind = -1;
            routes.Add(rtemp);
            foreach( RouteMaster r in contxt.RouteMasters.ToList())
            {
                routes.Add(r);
            }
            cboRoute.DataSource = routes;
            cboRoute.DisplayMember = "rName";
            cboRoute.ValueMember = "rName";
            //throw new NotImplementedException();
        }

        private DataTable SetDBDataSource( string sql)
        {
            //sqlcn = new SqlConnection();
            

            table = new DataTable();
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            cmd = new SqlCommand(sql, sqlcn);
            contxt.Database.Connection.Open();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            contxt.Database.Connection.Close();
            return table;
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboAct.SelectedItem != null)
            {
                DataRowView dvr = (DataRowView)cboAct.SelectedItem;
                activeStat = int.Parse(dvr["id"].ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            DataSet ds = new DataSet();
            sql = "Select Main_Reg.* From Main_Reg  Inner Join Collection_Tbl c On Main_Reg.RegNo = C.RegNo " +
                " Where  Month(trDate) = " + dtM.Value.Month + " AND Year(c.trDate) =" + dtM.Value.Year + " AND " +
                " ISNULL(isACtive,0) = " + activeStat + " AND Main_Reg.RouteName LIKE '" + route.rName.Trim() + "%' AND " +
                " Main_Reg.RegNo Between " + nSupFrom.Value + " AND " + nSupTo.Value + " Order By Main_Reg.RegNo, C.trDate";

            DataTable dataTable = SetDBDataSource( sql);
            ds.Tables.Add(dataTable);

            sql = "Select Collection_Tbl.trDate ,Collection_Tbl.RegNo, Collection_Tbl.Name RegName,Collection_Tbl.Route RouteName, Collection_Tbl.Qty " +
                " From Main_Reg  Inner Join Collection_Tbl  On Main_Reg.RegNo = Collection_Tbl.RegNo " +
                " Where  Month(trDate) = " + dtM.Value.Month + " AND Year(Collection_Tbl.trDate) =" + dtM.Value.Year + " AND " +
                " ISNULL(isACtive,0) = " + activeStat + " AND Main_Reg.RouteName LIKE '" + route.rName.Trim() + "%' AND " +
                " Main_Reg.RegNo Between " + nSupFrom.Value + " AND " + nSupTo.Value + " Order By Main_Reg.RegNo, Collection_Tbl.trDate";
            DataTable dataTable2 = SetDBDataSource(sql);
            ds.Tables.Add(dataTable2);
            //CheckrollTableAdapters.DisplayPaysheetTableAdapter chkPayAdapter = new CheckrollTableAdapters.DisplayPaysheetTableAdapter();
            //Checkroll.DisplayPaysheetDataTable dispTable = new Checkroll.DisplayPaysheetDataTable();
            report.FileName = Application.StartupPath + "\\" + ReportName;
            report.Database.Tables[0].SetDataSource(dataTable);
            report.Database.Tables[1].SetDataSource(dataTable2);
            //report.SetDataSource(ds);
            string strMonth = String.Format("{0:MMM-yyyy}", dtM.Value);
            report.SetParameterValue("TrnMonth", strMonth);
            report.SetParameterValue("FactoryName", RuntimeValues.Factory);
            crv.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach (CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {

                crv.ParameterFieldInfo.Add(fld);

            }

            crv.ReportSource = report;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessTransactions();
                MessageBox.Show("Update process completed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update process not completed  successfully \n" + ex.Message);
            }
        }

        private void ProcessTransactions()
        {
            sql = " EXEC Process_Bogus " + dtM.Value.Month + " , " + dtM.Value.Year + ", '" + route.rName + "'";
            ExecuteSQLDIrect(sql);
            //throw new NotImplementedException();
        }

        private void ExecuteSQLDIrect(string sql)
        {
            if (contxt.Database.Connection.State == ConnectionState.Open)
                contxt.Database.Connection.Close();
            contxt.Database.Connection.Open();
            contxt.Database.ExecuteSqlCommand(sql);
            contxt.Database.Connection.Close();
            //throw new NotImplementedException();
        }
    }
}
