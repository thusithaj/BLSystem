using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration.Install;

namespace BLSystem
{
    public partial class BLSystemMain : Form
    {
        //private int childFormNumber = 0;

        public BLSystemMain()
        {
            InitializeComponent();
            RuntimeValues.Factory = System.Configuration.ConfigurationManager.AppSettings["Factory"].ToString();
            //RuntimeValues.FactoryName = System.Configuration.ConfigurationManager.AppSettings["FactoryName"].ToString();
            RuntimeValues.Company = System.Configuration.ConfigurationManager.AppSettings["Company"].ToString();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            formAddressBookType childForm = new formAddressBookType();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            FormAddressBook childForm = new FormAddressBook();
            childForm.MdiParent = this;
            childForm.FormType = "None";
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory childForm = new FormFactory();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaction childForm = new FormTransaction();
            childForm.formMode = "Sales";
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPriceList childForm = new FormPriceList();
            childForm.formMode = "Purchase";
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPriceList childForm = new FormPriceList();
            childForm.formMode = "Sales";
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompany childForm = new FormCompany();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplierMaster childForm = new FormSupplierMaster();
            childForm.MdiParent = this;
            childForm.TypeName = "Suppliers";
            //childForm.FormT
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts childForm = new FormProducts();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaction childForm = new FormTransaction();
            childForm.formMode = "Financial";
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
            
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaction childForm = new FormTransaction();
            childForm.formMode = "Purchase";
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplierMaster childForm = new FormSupplierMaster();
            childForm.MdiParent = this;
            childForm.TypeName = "Customers";
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void BLSystemMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcessMonth childForm = new FormProcessMonth();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void partnerLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPartnerLedger childForm = new FormPartnerLedger();
            childForm.ReportName = "PartnerLedger.rpt";
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void profitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPartnerLedger childForm = new FormPartnerLedger();
            childForm.ReportName = "SimpleProfitLoss.rpt";
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportTrn childForm = new FormImportTrn();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void fiscalPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiscalPeriod childForm = new FormFiscalPeriod();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void routeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRouteMaster childForm = new FormRouteMaster();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void supplierDeductionRateUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplierRate childForm = new FormSupplierRate();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void addRouteQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addRouteQtyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormExtraEntry childForm = new FormExtraEntry();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void monthlyDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcess childForm = new FormProcess();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void monthlyReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrint childForm = new FormPrint();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void supplierReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTC12 childForm = new FormTC12();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.ReportName = "SupplierReceipt2.rpt";
            childForm.Show();
        }
    }
}
