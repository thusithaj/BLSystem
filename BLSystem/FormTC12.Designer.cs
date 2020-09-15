namespace BLSystem
{
    partial class FormTC12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTC12));
            this.panelTop = new System.Windows.Forms.Panel();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboAct = new System.Windows.Forms.ComboBox();
            this.lSS = new System.Windows.Forms.Label();
            this.nSupTo = new System.Windows.Forms.NumericUpDown();
            this.nSupFrom = new System.Windows.Forms.NumericUpDown();
            this.lSNFrom = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lR = new System.Windows.Forms.Label();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSupTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSupFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnProcess);
            this.panelTop.Controls.Add(this.dtM);
            this.panelTop.Controls.Add(this.lm);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.cboAct);
            this.panelTop.Controls.Add(this.lSS);
            this.panelTop.Controls.Add(this.nSupTo);
            this.panelTop.Controls.Add(this.nSupFrom);
            this.panelTop.Controls.Add(this.lSNFrom);
            this.panelTop.Controls.Add(this.cboRoute);
            this.panelTop.Controls.Add(this.lR);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 113);
            this.panelTop.TabIndex = 0;
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM/yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(616, 61);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(134, 27);
            this.dtM.TabIndex = 9;
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(545, 66);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(65, 20);
            this.lm.TabIndex = 8;
            this.lm.Text = "Month :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status :";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BLSystem.Properties.Resources.document_print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1052, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 61);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboAct
            // 
            this.cboAct.FormattingEnabled = true;
            this.cboAct.Location = new System.Drawing.Point(107, 61);
            this.cboAct.Name = "cboAct";
            this.cboAct.Size = new System.Drawing.Size(245, 28);
            this.cboAct.TabIndex = 6;
            this.cboAct.SelectedIndexChanged += new System.EventHandler(this.cboAct_SelectedIndexChanged);
            // 
            // lSS
            // 
            this.lSS.AutoSize = true;
            this.lSS.Location = new System.Drawing.Point(34, 61);
            this.lSS.Name = "lSS";
            this.lSS.Size = new System.Drawing.Size(67, 20);
            this.lSS.TabIndex = 5;
            this.lSS.Text = "Status :";
            // 
            // nSupTo
            // 
            this.nSupTo.Location = new System.Drawing.Point(784, 23);
            this.nSupTo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nSupTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSupTo.Name = "nSupTo";
            this.nSupTo.Size = new System.Drawing.Size(162, 27);
            this.nSupTo.TabIndex = 4;
            this.nSupTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSupTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nSupFrom
            // 
            this.nSupFrom.Location = new System.Drawing.Point(616, 21);
            this.nSupFrom.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nSupFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSupFrom.Name = "nSupFrom";
            this.nSupFrom.Size = new System.Drawing.Size(162, 27);
            this.nSupFrom.TabIndex = 3;
            this.nSupFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSupFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lSNFrom
            // 
            this.lSNFrom.AutoSize = true;
            this.lSNFrom.Location = new System.Drawing.Point(521, 23);
            this.lSNFrom.Name = "lSNFrom";
            this.lSNFrom.Size = new System.Drawing.Size(89, 20);
            this.lSNFrom.TabIndex = 2;
            this.lSNFrom.Text = "Suppliers :";
            this.lSNFrom.Click += new System.EventHandler(this.lSNFrom_Click);
            // 
            // cboRoute
            // 
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(107, 20);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(391, 28);
            this.cboRoute.TabIndex = 1;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.Location = new System.Drawing.Point(38, 23);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(63, 20);
            this.lR.TabIndex = 0;
            this.lR.Text = "Route :";
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 113);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1182, 449);
            this.crv.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BLSystem.Properties.Resources.gnome_chess;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(949, 49);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(97, 61);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "P&rocess";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // FormTC12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 562);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTC12";
            this.Text = "Supplier Receipt Print";
            this.Load += new System.EventHandler(this.FormTC12_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSupFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.NumericUpDown nSupFrom;
        private System.Windows.Forms.Label lSNFrom;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label lR;
        private System.Windows.Forms.Label lSS;
        private System.Windows.Forms.NumericUpDown nSupTo;
        private System.Windows.Forms.ComboBox cboAct;
        private System.Windows.Forms.Button btnPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtM;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.Button btnProcess;
    }
}