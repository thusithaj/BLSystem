using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;
namespace BLSystem
{
    public partial class FormPrint : Form
    {
        public string ReportName { get; set; }
        public DataTable table { get; set; }
        public int PrintState { get; set; }
        public string ReportType { get; set; }
        PMModel contxt;
        ReportDocument report;
        SqlConnection sqlcn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter da;
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            report = new ReportDocument();
            
            if(PrintState == 1)
            {
                report.Load(Application.StartupPath + "\\" + ReportName);
                panelTop.Visible = false;
                PrintReport();
            }
            else
            {
                ReportType = "BL";
                LoadReports();
            }
        }

        private void LoadReports()
        {
            DataTable reportDefs = new DataTable();
            string reportPath = Application.StartupPath + "\\reportDefs.xml";
            reportDefs.ReadXml(reportPath);
            reportDefs = reportDefs.Select("ReportType='" + ReportType + "'").CopyToDataTable();
            cboReport.DataSource = reportDefs;
            cboReport.DisplayMember = "ReportName";
            cboReport.ValueMember = "ReportName";
        }

        private void PrintReport()
        {
            report.SetDataSource(table);
            crv.ReportSource = report;
            crv.RefreshReport();
            //throw new NotImplementedException();
        }

        private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReport.SelectedItem != null)
            {
                DataRowView dvr = (DataRowView)cboReport.SelectedItem;
                ReportName = dvr["ReportName"].ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            DataTable dataTable = SetDBDataSource();
            //CheckrollTableAdapters.DisplayPaysheetTableAdapter chkPayAdapter = new CheckrollTableAdapters.DisplayPaysheetTableAdapter();
            //Checkroll.DisplayPaysheetDataTable dispTable = new Checkroll.DisplayPaysheetDataTable();
            report.FileName = Application.StartupPath + "\\" + ReportName;
            report.SetDataSource(dataTable);
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

        private DataTable SetDBDataSource()
        {
            sql = " select c.trDate,c.regNo,c.Route RouteName,c.Name RegName,c.Qty from Collection_tbl C inner join " +
                " main_reg m on c.regNo = m.regNo where c.Route Like   '%' " +
                " AND MONTH (c.TrDate) =" + String.Format("{0:MM}", dtM.Value) + " AND " +
                " YEAR(c.TrDate) = " + String.Format("{0:yyyy}", dtM.Value) + " AND " +
                " C.RegNo NOT IN ( SELECT RegNo FROm ExcludeSupplier )";
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
    }
}
