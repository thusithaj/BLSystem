using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace BLSystem
{
    public class OldBlObj
    {
        OleDbConnection olecn;
        OleDbCommand olecmd;
        OleDbDataAdapter oleda;
        string oldcn;
        //string sql;
        DataTable table;
        public OldBlObj()
        {
            string oldcn = System.Configuration.ConfigurationManager.ConnectionStrings["blold"].ConnectionString;
            olecn = new OleDbConnection(oldcn);
        }

        public DataTable GetDataTable( string strsql)
        {
            olecmd = new OleDbCommand(strsql, olecn);
            table = new DataTable();
            oleda = new OleDbDataAdapter(olecmd);
            oleda.Fill(table);
            olecn.Close();
            return table;
        }
        public void SaveBulkData( DataTable table)
        {
            
        }

    }
}
