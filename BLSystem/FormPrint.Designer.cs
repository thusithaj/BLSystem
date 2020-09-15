namespace BLSystem
{
    partial class FormPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.panelTop = new System.Windows.Forms.Panel();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lr = new System.Windows.Forms.Label();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lM = new System.Windows.Forms.Label();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dtM);
            this.panelTop.Controls.Add(this.lM);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.cboReport);
            this.panelTop.Controls.Add(this.lr);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1081, 54);
            this.panelTop.TabIndex = 0;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 54);
            this.crv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1081, 527);
            this.crv.TabIndex = 1;
            this.crv.ToolPanelWidth = 250;
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(355, 20);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(69, 20);
            this.lr.TabIndex = 2;
            this.lr.Text = "Report :";
            // 
            // cboReport
            // 
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(445, 17);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(417, 28);
            this.cboReport.TabIndex = 3;
            this.cboReport.SelectedIndexChanged += new System.EventHandler(this.cboReport_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BLSystem.Properties.Resources.document_print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(922, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 51);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lM
            // 
            this.lM.AutoSize = true;
            this.lM.Location = new System.Drawing.Point(38, 20);
            this.lM.Name = "lM";
            this.lM.Size = new System.Drawing.Size(67, 20);
            this.lM.TabIndex = 0;
            this.lM.Text = "Period :";
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM/yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(111, 20);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(150, 27);
            this.dtM.TabIndex = 1;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 581);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrint";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.Label lM;
        private System.Windows.Forms.DateTimePicker dtM;
    }
}