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
    public partial class FormImportTrn : Form
    {
        OldBlObj old;
        SupplierLedger ledger;
        RouteQty ledgerMaster;
        AddressBook route;
        PMModel contxt;
        DataTable table;
        FiscalPeriod period;
        public FormImportTrn()
        {
            InitializeComponent();
        }

        private void FormImportTrn_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            ledger = new SupplierLedger();
            ledgerMaster = new RouteQty();
            route = new AddressBook();
        }

        private void ImportQty()
        {
            string sql = "Select * from Collection_tbl where Month(trDate)=" + dtM.Value.Month +
                " And  Year(trdate) = " + dtM.Value.Year +"  Order By trDate ";
            int i = 0, idiv = 0;
            table = new DataTable();
            old = new OldBlObj();
            table = old.GetDataTable(sql);
            idiv = table.Rows.Count / 100;
            CheckRowIntegrity();
            ExportBulkQty(table, "Collection_tbl");

            pgbQty.Value = 100;
            lmsgQ.Text = string.Format("Importing record {0,6}", table.Rows.Count);
        }

        private void CheckRowIntegrity()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            contxt.Database.Connection.Open();
            cmd.Connection = sqlcn;
            string sql = "Select  Count(*) cnt from collection_tbl Where Month(trDate) =" + dtM.Value.Month + " AND Year(trDate) = " + dtM.Value.Year;
            cmd.CommandText = sql;
            int rows = (int) cmd.ExecuteScalar();
            pgbQty.Value = 0;
            if (rows > 0)
            {
                sql = " Delete From collection_tbl Where Month(trDate) =" + dtM.Value.Month + " AND " +
                    "Year(trDate) = " + dtM.Value.Year + " AND RegNo  IN ( SELECT RegNo FROM Main_Reg WHERE ISNULL(iaActive,0) =1) ";                  ;
                cmd.CommandText = sql;
                rows = cmd.ExecuteNonQuery();
                sql = "Select Max(ind) maxId From collection_tbl";
                cmd.CommandText = sql;
                rows = cmd.ExecuteScalar().ToString()== "" ? 0: (int)cmd.ExecuteScalar();
                sql = " DBCC CHECKIDENT ('Collection_tbl' , RESEED ," + rows + " )";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            contxt.Database.Connection.Close();
            
        }

        private void btnImpQty_Click(object sender, EventArgs e)
        {
            if (CheckValidityPeriod())
            {
                ImportQty();
            }
        }
        private void ExportBulkQty( DataTable dataTable, string destTable)
        {
            SqlConnection sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            contxt.Database.Connection.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlcn);
            
            
            bulkCopy.DestinationTableName = destTable;
            try
            {
                bulkCopy.WriteToServer(dataTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error encountered while inserting \n" + ex.Message);
            }
            contxt.Database.Connection.Close();
        }
        private void ImportOther()
        {
            // Here we backup previous Main_Reg Table
            string tabName = "Main_Reg_" + dtM.Value.Year.ToString().Trim() + "_" + String.Format("{0:MMM}", dtM.Value.AddMonths(-1));
            int  idiv = 0;
            bool TableCreated = false;
            // Getting data from old system
            string sql = "Select * from Main_Reg" ;
            table = new DataTable();
            old = new OldBlObj();
            table = old.GetDataTable(sql);
            idiv = table.Rows.Count ;
            pbOth.Value = 0;
            // Here we check previous table exists
            if (CheckTable(tabName))
            {
                sql = "Drop Table " + tabName;
                ExecuteSQLDirect( sql);
                //sql = "Insert " + tabName + " Select * FROM Main_Reg";
                //ExecuteSQLDirect(sql);
                CreateTable(tabName);
                TableCreated = true;
            }
            else
            {
                CreateTable(tabName);
                TableCreated = true;
            }
            sql = "Truncate Table Main_Reg";
            ExecuteSQLDirect(sql);
            ExportBulkQty(table, "Main_Reg");
            // Here we are going update present suppliers with OLD parameters
            if ( TableCreated)
            {
                sql = " Update Main_Reg Set DeductionRate = " + tabName + ".DeductionRate, isActive =" + tabName + ".isActive," +
                    "isBogus=" + tabName + ".isBogus From " + tabName + " Where Main_Reg.RegNo =" + tabName + ".RegNo";
                ExecuteSQLDirect(sql);
            }
            // Here we marking active suppliers
            sql = " Update Main_Reg Set isActive = 1 Where RegNo in ( Select Distinct RegNo From Collection_Tbl Where" +
                " Month(trDate) =  " + dtM.Value.Month + " AND Year(trDate) = " + dtM.Value.Year + ")" ;
            ExecuteSQLDirect(sql);
            lo.Text = String.Format("Imported Master Records = {0,6}", idiv);
            pbOth.Value = 100;
            contxt.Database.Connection.Close();
        }

        private void ExecuteSQLDirect( string sql )
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            contxt.Database.Connection.Open();
            cmd.Connection = sqlcn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            contxt.Database.Connection.Close();
            
        }

        private bool CheckTable( string table)
        {
            bool tableExists = false;
            string sql = "select * from sys.objects where [name]='" + table +"'";
            SqlCommand cmd = new SqlCommand();
            SqlConnection sqlcn = new SqlConnection();
            sqlcn = (SqlConnection)contxt.Database.Connection;
            contxt.Database.Connection.Open();
            cmd.Connection = sqlcn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                tableExists = true;
            contxt.Database.Connection.Close();
            return tableExists;
        }
        private void btnImpAll_Click(object sender, EventArgs e)
        {

            if (CheckValidityPeriod())
                ImportOther();
            else
            {
                MessageBox.Show("Import Period is not setup. Please set up the period");
            }
        }

        private bool CheckValidityPeriod()
        {
            bool validity = false;
            period = contxt.FiscalPeriods.FirstOrDefault(o => o.FromDate.Value.Month == dtM.Value.Month &&
                o.FromDate.Value.Year == dtM.Value.Year);
            if ( period != null)
            if (period.Status == 0)
                validity = true;
            return validity;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenClosePeriod();
        }

        private void OpenClosePeriod()
        {
            period = contxt.FiscalPeriods.FirstOrDefault(o => o.FromDate.Value.Month == dtM.Value.Month &&
                o.FromDate.Value.Year == dtM.Value.Year);
            if (period == null)
            {
                period = new FiscalPeriod();
                period.FromDate = new DateTime(dtM.Value.Year, dtM.Value.Month, 1);
                period.Todate = period.FromDate.Value.AddMonths(1).AddDays(period.FromDate.Value.Day * -1);
                period.Status = chkClose.Checked ? 1 : 0; ;
                contxt.FiscalPeriods.Add(period);
                contxt.Entry(period).State = System.Data.Entity.EntityState.Added;
                contxt.SaveChanges();
            }
            else
            {
                period.Status = chkClose.Checked ? 1 : 0;
                contxt.Entry(period).State = System.Data.Entity.EntityState.Modified;
                contxt.SaveChanges();
            }
            
        }

        private void chkClose_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClose.Checked)
            {
                btnClose.Text = "&Close";

            }
            else
                btnClose.Text = "&Open";
        }
        private void CreateTable( string tabName)
        {
            string tabSql = " select * into " + tabName + " from Main_Reg " ;
            ExecuteSQLDirect(tabSql);
        }
        private void ImportRoutes()
        {
            string sql = " Truncate Table RouteMaster";
            if (CheckTable("RouteMaster"))
            {
                if (MessageBox.Show("The Route Table do exists in the Database!\n" +
                    " The data will be deleted. Continue updating",
                    "Warning",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    ExecuteSQLDirect(sql);
                }
                else
                {
                    return;
                }
            }
            ExecuteSQLDirect(sql);
            sql = "Select * from Route_List";
            table = new DataTable();
            old = new OldBlObj();
            pbR.Value = 0;
            table = old.GetDataTable(sql);
            int idiv = table.Rows.Count;
            ExportBulkQty(table, "RouteMaster");
            pbR.Value = 100;
            lbRM.Text = "Imported Records" + idiv;
        }

        private void btnRImport_Click(object sender, EventArgs e)
        {
            ImportRoutes();
        }
    }
}
