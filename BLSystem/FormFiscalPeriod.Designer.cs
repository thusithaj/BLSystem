namespace BLSystem
{
    partial class FormFiscalPeriod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiscalPeriod));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.lst = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lm = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.dgvFP = new System.Windows.Forms.DataGridView();
            this.Fromdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiscalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).BeginInit();
            this.ctxGrid.SuspendLayout();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1116, 57);
            this.panelTop.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(626, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BLSystem.Properties.Resources.application_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(882, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BLSystem.Properties.Resources.document_save_5;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(754, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 52);
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
            this.btnDelete.Location = new System.Drawing.Point(420, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 52);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::BLSystem.Properties.Resources.document_quick_restart1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(286, 2);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 52);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BLSystem.Properties.Resources.edit_3;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(152, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BLSystem.Properties.Resources.address_book_new;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(18, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.lst);
            this.panelMid.Controls.Add(this.cboStatus);
            this.panelMid.Controls.Add(this.dtM);
            this.panelMid.Controls.Add(this.lm);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 57);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1116, 136);
            this.panelMid.TabIndex = 3;
            // 
            // lst
            // 
            this.lst.AutoSize = true;
            this.lst.Location = new System.Drawing.Point(282, 42);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(68, 23);
            this.lst.TabIndex = 5;
            this.lst.Text = "Status :";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(367, 39);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(234, 31);
            this.cboStatus.TabIndex = 4;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM/yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(124, 42);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(134, 30);
            this.dtM.TabIndex = 3;
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(38, 42);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(66, 23);
            this.lm.TabIndex = 2;
            this.lm.Text = "Month :";
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.dgvFP);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(0, 193);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1116, 454);
            this.panelBot.TabIndex = 4;
            // 
            // dgvFP
            // 
            this.dgvFP.AllowDrop = true;
            this.dgvFP.AllowUserToAddRows = false;
            this.dgvFP.AllowUserToDeleteRows = false;
            this.dgvFP.AllowUserToOrderColumns = true;
            this.dgvFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fromdate,
            this.ToDate,
            this.FiscalStatus});
            this.dgvFP.ContextMenuStrip = this.ctxGrid;
            this.dgvFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFP.Location = new System.Drawing.Point(0, 0);
            this.dgvFP.Name = "dgvFP";
            this.dgvFP.RowTemplate.Height = 24;
            this.dgvFP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFP.Size = new System.Drawing.Size(1116, 454);
            this.dgvFP.TabIndex = 0;
            this.dgvFP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFP_CellContentClick);
            this.dgvFP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFP_CellDoubleClick);
            // 
            // Fromdate
            // 
            this.Fromdate.DataPropertyName = "Fromdate";
            this.Fromdate.HeaderText = "From Date";
            this.Fromdate.Name = "Fromdate";
            // 
            // ToDate
            // 
            this.ToDate.DataPropertyName = "ToDate";
            this.ToDate.HeaderText = "To Date";
            this.ToDate.Name = "ToDate";
            // 
            // FiscalStatus
            // 
            this.FiscalStatus.DataPropertyName = "Status";
            this.FiscalStatus.HeaderText = "Status";
            this.FiscalStatus.Name = "FiscalStatus";
            // 
            // ctxGrid
            // 
            this.ctxGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCopy});
            this.ctxGrid.Name = "ctxGrid";
            this.ctxGrid.Size = new System.Drawing.Size(211, 56);
            // 
            // ctxCopy
            // 
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ctxCopy.Size = new System.Drawing.Size(210, 24);
            this.ctxCopy.Text = "&Copy Grid";
            this.ctxCopy.Click += new System.EventHandler(this.ctxCopy_Click);
            // 
            // FormFiscalPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 647);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFiscalPeriod";
            this.Text = "Fiscal Period";
            this.Load += new System.EventHandler(this.FormFiscalPeriod_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFP)).EndInit();
            this.ctxGrid.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.DataGridView dgvFP;
        private System.Windows.Forms.DateTimePicker dtM;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.Label lst;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fromdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiscalStatus;
        private System.Windows.Forms.ContextMenuStrip ctxGrid;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
    }
}