namespace BLSystem
{
    partial class FormSupplierRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplierRate));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lM = new System.Windows.Forms.Label();
            this.chkBL = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lDR = new System.Windows.Forms.Label();
            this.nDRate = new System.Windows.Forms.NumericUpDown();
            this.cboSup = new System.Windows.Forms.ComboBox();
            this.lsn = new System.Windows.Forms.Label();
            this.tbSupName = new System.Windows.Forms.TextBox();
            this.lR = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnCancel);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(8);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1496, 64);
            this.panelTop.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(978, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 56);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BLSystem.Properties.Resources.application_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1378, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BLSystem.Properties.Resources.document_save_5;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1178, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::BLSystem.Properties.Resources.edit_delete_6;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(656, -1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 56);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::BLSystem.Properties.Resources.document_quick_restart1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(448, -1);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 56);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BLSystem.Properties.Resources.edit_3;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(238, -1);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 56);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BLSystem.Properties.Resources.address_book_new;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(28, -1);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.lR);
            this.panelMid.Controls.Add(this.tbSupName);
            this.panelMid.Controls.Add(this.dtM);
            this.panelMid.Controls.Add(this.lM);
            this.panelMid.Controls.Add(this.chkBL);
            this.panelMid.Controls.Add(this.chkActive);
            this.panelMid.Controls.Add(this.lDR);
            this.panelMid.Controls.Add(this.nDRate);
            this.panelMid.Controls.Add(this.cboSup);
            this.panelMid.Controls.Add(this.lsn);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 64);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1496, 123);
            this.panelMid.TabIndex = 4;
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM-yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(114, 31);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(147, 27);
            this.dtM.TabIndex = 1;
            this.dtM.Validated += new System.EventHandler(this.dtM_Validated);
            // 
            // lM
            // 
            this.lM.AutoSize = true;
            this.lM.Location = new System.Drawing.Point(29, 34);
            this.lM.Name = "lM";
            this.lM.Size = new System.Drawing.Size(65, 20);
            this.lM.TabIndex = 0;
            this.lM.Text = "Month :";
            // 
            // chkBL
            // 
            this.chkBL.AutoSize = true;
            this.chkBL.Location = new System.Drawing.Point(1319, 35);
            this.chkBL.Name = "chkBL";
            this.chkBL.Size = new System.Drawing.Size(124, 24);
            this.chkBL.TabIndex = 7;
            this.chkBL.Text = "B/L Supplier";
            this.chkBL.UseVisualStyleBackColor = true;
            this.chkBL.CheckedChanged += new System.EventHandler(this.chkBL_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(1172, 35);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(77, 24);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // lDR
            // 
            this.lDR.AutoSize = true;
            this.lDR.Location = new System.Drawing.Point(800, 34);
            this.lDR.Name = "lDR";
            this.lDR.Size = new System.Drawing.Size(195, 20);
            this.lDR.TabIndex = 4;
            this.lDR.Text = "Supplier Deduction rate :";
            // 
            // nDRate
            // 
            this.nDRate.DecimalPlaces = 2;
            this.nDRate.Location = new System.Drawing.Point(1001, 32);
            this.nDRate.Name = "nDRate";
            this.nDRate.Size = new System.Drawing.Size(120, 27);
            this.nDRate.TabIndex = 5;
            this.nDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDRate.Enter += new System.EventHandler(this.nDRate_Enter);
            // 
            // cboSup
            // 
            this.cboSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(523, 29);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(228, 28);
            this.cboSup.TabIndex = 3;
            this.cboSup.SelectedIndexChanged += new System.EventHandler(this.cboSup_SelectedIndexChanged);
            this.cboSup.Enter += new System.EventHandler(this.cboSup_Enter);
            this.cboSup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboSup_KeyUp);
            // 
            // lsn
            // 
            this.lsn.AutoSize = true;
            this.lsn.Location = new System.Drawing.Point(398, 32);
            this.lsn.Name = "lsn";
            this.lsn.Size = new System.Drawing.Size(106, 20);
            this.lsn.TabIndex = 2;
            this.lsn.Text = "Supplier No :";
            // 
            // tbSupName
            // 
            this.tbSupName.Enabled = false;
            this.tbSupName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbSupName.Location = new System.Drawing.Point(523, 64);
            this.tbSupName.Name = "tbSupName";
            this.tbSupName.Size = new System.Drawing.Size(498, 27);
            this.tbSupName.TabIndex = 8;
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.ForeColor = System.Drawing.Color.DarkRed;
            this.lR.Location = new System.Drawing.Point(523, 98);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(21, 20);
            this.lR.TabIndex = 9;
            this.lR.Text = "...";
            // 
            // FormSupplierRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 562);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplierRate";
            this.Text = "Supplier Deduction Rate";
            this.Load += new System.EventHandler(this.FormSupplierRate_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.ComboBox cboSup;
        private System.Windows.Forms.Label lsn;
        private System.Windows.Forms.Label lDR;
        private System.Windows.Forms.NumericUpDown nDRate;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkBL;
        private System.Windows.Forms.Label lM;
        private System.Windows.Forms.DateTimePicker dtM;
        private System.Windows.Forms.TextBox tbSupName;
        private System.Windows.Forms.Label lR;
    }
}