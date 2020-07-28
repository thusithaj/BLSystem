using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLSystem
{
    public class OldBlObj
    {
        System.Data.OleDb.OleDbConnection olecn;
        System.Data.OleDb.OleDbCommand olecmd;
        System.Data.OleDb.OleDbDataAdapter oleda;
        string oldcn;
        //string sql;
        DataTable table;
        public OldBlObj()
        {
            string oldcn = System.Configuration.ConfigurationManager.ConnectionStrings["blold"].ConnectionString;
            olecn = new System.Data.OleDb.OleDbConnection(oldcn);
        }

        public DataTable GetDataTable( string strsql)
        {
            olecmd = new System.Data.OleDb.OleDbCommand(strsql, olecn);
            table = new DataTable();
            oleda = new System.Data.OleDb.OleDbDataAdapter(olecmd);
            oleda.Fill(table);
            olecn.Close();
            return table;
        }

    }
}
