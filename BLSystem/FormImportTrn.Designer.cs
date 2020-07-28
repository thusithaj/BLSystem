namespace BLSystem
{
    partial class FormImportTrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportTrn));
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBoxQty = new System.Windows.Forms.GroupBox();
            this.lm = new System.Windows.Forms.Label();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.btnImpQty = new System.Windows.Forms.Button();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.cboAll = new System.Windows.Forms.ComboBox();
            this.btnImpAll = new System.Windows.Forms.Button();
            this.gbPgQty = new System.Windows.Forms.GroupBox();
            this.pgbQty = new System.Windows.Forms.ProgressBar();
            this.lmsgQ = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.groupBoxQty.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gbPgQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gbOther);
            this.panelTop.Controls.Add(this.groupBoxQty);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1126, 372);
            this.panelTop.TabIndex = 0;
            // 
            // groupBoxQty
            // 
            this.groupBoxQty.Controls.Add(this.gbPgQty);
            this.groupBoxQty.Controls.Add(this.btnImpQty);
            this.groupBoxQty.Controls.Add(this.dtM);
            this.groupBoxQty.Controls.Add(this.lm);
            this.groupBoxQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxQty.Location = new System.Drawing.Point(0, 0);
            this.groupBoxQty.Name = "groupBoxQty";
            this.groupBoxQty.Size = new System.Drawing.Size(1126, 98);
            this.groupBoxQty.TabIndex = 0;
            this.groupBoxQty.TabStop = false;
            this.groupBoxQty.Text = "Supplied Qty";
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(27, 44);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(65, 20);
            this.lm.TabIndex = 0;
            this.lm.Text = "Month :";
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM/yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(98, 39);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(134, 27);
            this.dtM.TabIndex = 1;
            // 
            // btnImpQty
            // 
            this.btnImpQty.Image = global::BLSystem.Properties.Resources.gnomeicu;
            this.btnImpQty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpQty.Location = new System.Drawing.Point(302, 32);
            this.btnImpQty.Name = "btnImpQty";
            this.btnImpQty.Size = new System.Drawing.Size(89, 44);
            this.btnImpQty.TabIndex = 2;
            this.btnImpQty.Text = "&Import";
            this.btnImpQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpQty.UseVisualStyleBackColor = true;
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.btnImpAll);
            this.gbOther.Controls.Add(this.cboAll);
            this.gbOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOther.Location = new System.Drawing.Point(0, 98);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(1126, 100);
            this.gbOther.TabIndex = 1;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other Transaction";
            // 
            // cboAll
            // 
            this.cboAll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAll.FormattingEnabled = true;
            this.cboAll.Location = new System.Drawing.Point(48, 37);
            this.cboAll.Name = "cboAll";
            this.cboAll.Size = new System.Drawing.Size(312, 28);
            this.cboAll.TabIndex = 0;
            // 
            // btnImpAll
            // 
            this.btnImpAll.Image = global::BLSystem.Properties.Resources.gnomeicu;
            this.btnImpAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpAll.Location = new System.Drawing.Point(427, 28);
            this.btnImpAll.Name = "btnImpAll";
            this.btnImpAll.Size = new System.Drawing.Size(101, 44);
            this.btnImpAll.TabIndex = 3;
            this.btnImpAll.Text = "Import &All";
            this.btnImpAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpAll.UseVisualStyleBackColor = true;
            // 
            // gbPgQty
            // 
            this.gbPgQty.Controls.Add(this.lmsgQ);
            this.gbPgQty.Controls.Add(this.pgbQty);
            this.gbPgQty.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPgQty.Location = new System.Drawing.Point(574, 23);
            this.gbPgQty.Name = "gbPgQty";
            this.gbPgQty.Size = new System.Drawing.Size(549, 72);
            this.gbPgQty.TabIndex = 3;
            this.gbPgQty.TabStop = false;
            this.gbPgQty.Text = "Qty Progress";
            // 
            // pgbQty
            // 
            this.pgbQty.Location = new System.Drawing.Point(157, 16);
            this.pgbQty.Name = "pgbQty";
            this.pgbQty.Size = new System.Drawing.Size(345, 23);
            this.pgbQty.TabIndex = 0;
            // 
            // lmsgQ
            // 
            this.lmsgQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmsgQ.ForeColor = System.Drawing.Color.Red;
            this.lmsgQ.Location = new System.Drawing.Point(153, 42);
            this.lmsgQ.Name = "lmsgQ";
            this.lmsgQ.Size = new System.Drawing.Size(349, 27);
            this.lmsgQ.TabIndex = 1;
            this.lmsgQ.Text = "...";
            // 
            // FormImportTrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 626);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormImportTrn";
            this.Text = "Import Transactions";
            this.panelTop.ResumeLayout(false);
            this.groupBoxQty.ResumeLayout(false);
            this.groupBoxQty.PerformLayout();
            this.gbOther.ResumeLayout(false);
            this.gbPgQty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBoxQty;
        private System.Windows.Forms.Button btnImpQty;
        private System.Windows.Forms.DateTimePicker dtM;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.ComboBox cboAll;
        private System.Windows.Forms.Button btnImpAll;
        private System.Windows.Forms.GroupBox gbPgQty;
        private System.Windows.Forms.Label lmsgQ;
        private System.Windows.Forms.ProgressBar pgbQty;
    }
}