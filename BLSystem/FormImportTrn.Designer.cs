﻿namespace BLSystem
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
            this.gbR = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRM = new System.Windows.Forms.Label();
            this.pbR = new System.Windows.Forms.ProgressBar();
            this.btnRImport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkClose = new System.Windows.Forms.CheckBox();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.gpbOth = new System.Windows.Forms.GroupBox();
            this.lo = new System.Windows.Forms.Label();
            this.pbOth = new System.Windows.Forms.ProgressBar();
            this.btnImpAll = new System.Windows.Forms.Button();
            this.cboAll = new System.Windows.Forms.ComboBox();
            this.groupBoxQty = new System.Windows.Forms.GroupBox();
            this.gbPgQty = new System.Windows.Forms.GroupBox();
            this.lmsgQ = new System.Windows.Forms.Label();
            this.pgbQty = new System.Windows.Forms.ProgressBar();
            this.btnImpQty = new System.Windows.Forms.Button();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lm = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.gbR.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.gpbOth.SuspendLayout();
            this.groupBoxQty.SuspendLayout();
            this.gbPgQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gbR);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.chkClose);
            this.panelTop.Controls.Add(this.gbOther);
            this.panelTop.Controls.Add(this.groupBoxQty);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1126, 372);
            this.panelTop.TabIndex = 0;
            // 
            // gbR
            // 
            this.gbR.Controls.Add(this.groupBox2);
            this.gbR.Controls.Add(this.btnRImport);
            this.gbR.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbR.Location = new System.Drawing.Point(0, 198);
            this.gbR.Name = "gbR";
            this.gbR.Size = new System.Drawing.Size(1126, 100);
            this.gbR.TabIndex = 4;
            this.gbR.TabStop = false;
            this.gbR.Text = "Routes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRM);
            this.groupBox2.Controls.Add(this.pbR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(574, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Progress";
            // 
            // lbRM
            // 
            this.lbRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRM.ForeColor = System.Drawing.Color.Red;
            this.lbRM.Location = new System.Drawing.Point(153, 42);
            this.lbRM.Name = "lbRM";
            this.lbRM.Size = new System.Drawing.Size(349, 27);
            this.lbRM.TabIndex = 1;
            this.lbRM.Text = "...";
            // 
            // pbR
            // 
            this.pbR.Location = new System.Drawing.Point(157, 16);
            this.pbR.Name = "pbR";
            this.pbR.Size = new System.Drawing.Size(345, 23);
            this.pbR.TabIndex = 0;
            // 
            // btnRImport
            // 
            this.btnRImport.Image = global::BLSystem.Properties.Resources.gnomeicu;
            this.btnRImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRImport.Location = new System.Drawing.Point(24, 26);
            this.btnRImport.Name = "btnRImport";
            this.btnRImport.Size = new System.Drawing.Size(135, 44);
            this.btnRImport.TabIndex = 3;
            this.btnRImport.Text = "Import &Routes";
            this.btnRImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRImport.UseVisualStyleBackColor = true;
            this.btnRImport.Click += new System.EventHandler(this.btnRImport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BLSystem.Properties.Resources.edit_delete_6;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(202, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkClose
            // 
            this.chkClose.AutoSize = true;
            this.chkClose.Location = new System.Drawing.Point(15, 322);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(127, 24);
            this.chkClose.TabIndex = 2;
            this.chkClose.Text = "Close Period";
            this.chkClose.UseVisualStyleBackColor = true;
            this.chkClose.CheckedChanged += new System.EventHandler(this.chkClose_CheckedChanged);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.gpbOth);
            this.gbOther.Controls.Add(this.btnImpAll);
            this.gbOther.Controls.Add(this.cboAll);
            this.gbOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOther.Location = new System.Drawing.Point(0, 98);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(1126, 100);
            this.gbOther.TabIndex = 1;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Leaf Suppliers";
            // 
            // gpbOth
            // 
            this.gpbOth.Controls.Add(this.lo);
            this.gpbOth.Controls.Add(this.pbOth);
            this.gpbOth.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpbOth.Location = new System.Drawing.Point(574, 23);
            this.gpbOth.Name = "gpbOth";
            this.gpbOth.Size = new System.Drawing.Size(549, 74);
            this.gpbOth.TabIndex = 4;
            this.gpbOth.TabStop = false;
            this.gpbOth.Text = "Other Progress";
            // 
            // lo
            // 
            this.lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lo.ForeColor = System.Drawing.Color.Red;
            this.lo.Location = new System.Drawing.Point(153, 42);
            this.lo.Name = "lo";
            this.lo.Size = new System.Drawing.Size(349, 27);
            this.lo.TabIndex = 1;
            this.lo.Text = "...";
            // 
            // pbOth
            // 
            this.pbOth.Location = new System.Drawing.Point(157, 16);
            this.pbOth.Name = "pbOth";
            this.pbOth.Size = new System.Drawing.Size(345, 23);
            this.pbOth.TabIndex = 0;
            // 
            // btnImpAll
            // 
            this.btnImpAll.Image = global::BLSystem.Properties.Resources.gnomeicu;
            this.btnImpAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpAll.Location = new System.Drawing.Point(370, 28);
            this.btnImpAll.Name = "btnImpAll";
            this.btnImpAll.Size = new System.Drawing.Size(101, 44);
            this.btnImpAll.TabIndex = 3;
            this.btnImpAll.Text = "Import &All";
            this.btnImpAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpAll.UseVisualStyleBackColor = true;
            this.btnImpAll.Click += new System.EventHandler(this.btnImpAll_Click);
            // 
            // cboAll
            // 
            this.cboAll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAll.FormattingEnabled = true;
            this.cboAll.Location = new System.Drawing.Point(24, 37);
            this.cboAll.Name = "cboAll";
            this.cboAll.Size = new System.Drawing.Size(312, 28);
            this.cboAll.TabIndex = 0;
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
            // pgbQty
            // 
            this.pgbQty.Location = new System.Drawing.Point(157, 16);
            this.pgbQty.Name = "pgbQty";
            this.pgbQty.Size = new System.Drawing.Size(345, 23);
            this.pgbQty.TabIndex = 0;
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
            this.btnImpQty.Click += new System.EventHandler(this.btnImpQty_Click);
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
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(27, 44);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(65, 20);
            this.lm.TabIndex = 0;
            this.lm.Text = "Month :";
            // 
            // FormImportTrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 626);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormImportTrn";
            this.Text = "Import Transactions";
            this.Load += new System.EventHandler(this.FormImportTrn_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.gbR.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbOther.ResumeLayout(false);
            this.gpbOth.ResumeLayout(false);
            this.groupBoxQty.ResumeLayout(false);
            this.groupBoxQty.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbOth;
        private System.Windows.Forms.Label lo;
        private System.Windows.Forms.ProgressBar pbOth;
        private System.Windows.Forms.CheckBox chkClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbRM;
        private System.Windows.Forms.ProgressBar pbR;
        private System.Windows.Forms.Button btnRImport;
    }
}