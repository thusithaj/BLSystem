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
    public partial class FormProcess : Form
    {
        PMModel contxt;
        RouteMaster route;
        List<RouteMaster> routes;
        string sql;
        SqlConnection sqlcn;
        SqlCommand cmd;
        DataTable table;
        public FormProcess()
        {
            InitializeComponent();
        }

        private void FormProcess_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            sqlcn = new SqlConnection();
            sqlcn = (SqlConnection) contxt.Database.Connection;
            routes = new List<RouteMaster>();
            LoadRoutes();
            table = new DataTable();

        }
        private void LoadRoutes()
        {
            routes = contxt.RouteMasters.ToList();
            
            dgvR.DataSource = null;
            dgvR.AutoGenerateColumns = false;
            dgvR.DataSource = routes;
        }
        private void CalculateDeduction()
        {
            contxt.Database.Connection.Open();
            foreach (RouteMaster r in routes)
            {
                sql = " Select RouteName, RegNo, RegName, TotKg, " + r.DdRate + " DdRate , " +
                    "isnull(DeductionRate,0)DeductionRate, TotKg *" + (r.DdRate/100) +" NetQty from Main_Reg " +
                    "Where routeName='" + r.rName + "' AND TotKg > 0";
                cmd = new SqlCommand(sql, sqlcn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                table.Merge(data);
            }
            contxt.Database.Connection.Close();
        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            CalculateDeduction();
            PrintReport();
        }

        private void PrintReport()
        {
            FormPrint print = new FormPrint();
            print.Owner = this;
            print.PrintState = 1;
            print.ReportName = "PreVerification.rpt";
            print.table = table;
            print.WindowState = FormWindowState.Maximized;
            print.Show();
            //throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
