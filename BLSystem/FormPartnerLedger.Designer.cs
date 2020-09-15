namespace BLSystem
{
    partial class FormPartnerLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartnerLedger));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lMonth = new System.Windows.Forms.Label();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.lPartner = new System.Windows.Forms.Label();
            this.cboPartner = new System.Windows.Forms.ComboBox();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bPrint = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.bPrint);
            this.panelTop.Controls.Add(this.cboPartner);
            this.panelTop.Controls.Add(this.lPartner);
            this.panelTop.Controls.Add(this.dtMonth);
            this.panelTop.Controls.Add(this.lMonth);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 75);
            this.panelTop.TabIndex = 0;
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Location = new System.Drawing.Point(36, 25);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(65, 20);
            this.lMonth.TabIndex = 0;
            this.lMonth.Text = "Month :";
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "MMM-yyyy";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(107, 23);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.Size = new System.Drawing.Size(130, 27);
            this.dtMonth.TabIndex = 1;
            // 
            // lPartner
            // 
            this.lPartner.AutoSize = true;
            this.lPartner.Location = new System.Drawing.Point(274, 28);
            this.lPartner.Name = "lPartner";
            this.lPartner.Size = new System.Drawing.Size(74, 20);
            this.lPartner.TabIndex = 2;
            this.lPartner.Text = "Partner :";
            // 
            // cboPartner
            // 
            this.cboPartner.FormattingEnabled = true;
            this.cboPartner.Location = new System.Drawing.Point(354, 28);
            this.cboPartner.Name = "cboPartner";
            this.cboPartner.Size = new System.Drawing.Size(431, 28);
            this.cboPartner.TabIndex = 3;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 75);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1000, 487);
            this.crv.TabIndex = 1;
            // 
            // bPrint
            // 
            this.bPrint.Image = global::BLSystem.Properties.Resources.gnome_panel;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(809, 19);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(87, 39);
            this.bPrint.TabIndex = 4;
            this.bPrint.Text = "&Preview";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // FormPartnerLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPartnerLedger";
            this.Text = "Partner   Ledger";
            this.Load += new System.EventHandler(this.FormPartnerLedger_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DateTimePicker dtMonth;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.ComboBox cboPartner;
        private System.Windows.Forms.Label lPartner;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Button bPrint;
    }
}