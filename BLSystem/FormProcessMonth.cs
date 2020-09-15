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
    public partial class FormProcessMonth : Form
    {
        PMModel contxt;
        string sp_name;
        PriceList priceList;
        bool isNew = false, isEdit = false;
        enum FORMSTATE { ADD, EDIT, VIEW, DELETE, NOOP };
        FORMSTATE state;
        public FormProcessMonth()
        {
            InitializeComponent();
        }

        private void FormProcessMonth_Load(object sender, EventArgs e)
        {
            contxt = new PMModel();
            priceList = new PriceList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pg.Value = 0;
            try
            {
                Process();
                MessageBox.Show("Process of the selected month return success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Process of the selected month return an Error \n" +ex.Message);
            }
        }

        private void Process()
        {
            sp_name = "EXEC ProcessCostandPrice @P0" ;
            lmsg.Text = "Prices and Cost Updating started ...";
            contxt.Database.ExecuteSqlCommand(sp_name, dtPeriod.Value.Month);
            pg.Value += 33;
            
            if (chkLock.Checked)
            {
                string[] sqlpara = new string[2];
                sqlpara[0] = "2";
                sqlpara[1] = dtPeriod.Value.Month.ToString();
                contxt.Database.ExecuteSqlCommand("Update PriceList Set Status = @P0 Where Month(EffectFrom) = @P1", sqlpara);
                pg.Value += 33;
            }
            sp_name = " EXEC ProcessFinancials @P0";
            contxt.Database.ExecuteSqlCommand(sp_name, dtPeriod.Value.Month);
            pg.Value = 100;
            lmsg.Text = "Prices and Cost Updating started ...Finished";
        }
    }
}
