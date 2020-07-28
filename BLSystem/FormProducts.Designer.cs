namespace BLSystem
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.lfac = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.lp = new System.Windows.Forms.Label();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.lttyp = new System.Windows.Forms.Label();
            this.cboTrnType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUOM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nOrder = new System.Windows.Forms.NumericUpDown();
            this.dgvPrd = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1086, 59);
            this.panelTop.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(626, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BLSystem.Properties.Resources.application_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(882, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 52);
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
            this.btnSave.Location = new System.Drawing.Point(754, 6);
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
            this.btnDelete.Location = new System.Drawing.Point(420, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(286, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 52);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BLSystem.Properties.Resources.edit_3;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(152, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BLSystem.Properties.Resources.address_book_new;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(18, 3);
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
            this.panelMid.Controls.Add(this.nOrder);
            this.panelMid.Controls.Add(this.label2);
            this.panelMid.Controls.Add(this.tbUOM);
            this.panelMid.Controls.Add(this.label1);
            this.panelMid.Controls.Add(this.cboTrnType);
            this.panelMid.Controls.Add(this.lttyp);
            this.panelMid.Controls.Add(this.tbPName);
            this.panelMid.Controls.Add(this.lp);
            this.panelMid.Controls.Add(this.cboFactory);
            this.panelMid.Controls.Add(this.lfac);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 59);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1086, 270);
            this.panelMid.TabIndex = 7;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.dgvPrd);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(0, 329);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1086, 233);
            this.panelBot.TabIndex = 8;
            // 
            // lfac
            // 
            this.lfac.AutoSize = true;
            this.lfac.Location = new System.Drawing.Point(70, 26);
            this.lfac.Name = "lfac";
            this.lfac.Size = new System.Drawing.Size(75, 20);
            this.lfac.TabIndex = 0;
            this.lfac.Text = "Factory :";
            // 
            // cboFactory
            // 
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.Location = new System.Drawing.Point(150, 26);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(418, 28);
            this.cboFactory.TabIndex = 1;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // lp
            // 
            this.lp.AutoSize = true;
            this.lp.Location = new System.Drawing.Point(574, 26);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(63, 20);
            this.lp.TabIndex = 2;
            this.lp.Text = "Name :";
            // 
            // tbPName
            // 
            this.tbPName.Location = new System.Drawing.Point(657, 26);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(418, 27);
            this.tbPName.TabIndex = 3;
            this.tbPName.Enter += new System.EventHandler(this.tbPName_Enter);
            // 
            // lttyp
            // 
            this.lttyp.AutoSize = true;
            this.lttyp.Location = new System.Drawing.Point(56, 68);
            this.lttyp.Name = "lttyp";
            this.lttyp.Size = new System.Drawing.Size(89, 20);
            this.lttyp.TabIndex = 4;
            this.lttyp.Text = "Trn. Type :";
            // 
            // cboTrnType
            // 
            this.cboTrnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrnType.FormattingEnabled = true;
            this.cboTrnType.Items.AddRange(new object[] {
            "DEBIT",
            "CREDIT"});
            this.cboTrnType.Location = new System.Drawing.Point(150, 68);
            this.cboTrnType.Name = "cboTrnType";
            this.cboTrnType.Size = new System.Drawing.Size(418, 28);
            this.cboTrnType.TabIndex = 5;
            this.cboTrnType.SelectedIndexChanged += new System.EventHandler(this.cboTrnType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "UOM :";
            // 
            // tbUOM
            // 
            this.tbUOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUOM.Location = new System.Drawing.Point(657, 68);
            this.tbUOM.Name = "tbUOM";
            this.tbUOM.Size = new System.Drawing.Size(173, 27);
            this.tbUOM.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order :";
            // 
            // nOrder
            // 
            this.nOrder.Location = new System.Drawing.Point(152, 108);
            this.nOrder.Name = "nOrder";
            this.nOrder.Size = new System.Drawing.Size(120, 27);
            this.nOrder.TabIndex = 9;
            this.nOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvPrd
            // 
            this.dgvPrd.AllowUserToAddRows = false;
            this.dgvPrd.AllowUserToDeleteRows = false;
            this.dgvPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.TrnType,
            this.UOM,
            this.PrintOrder,
            this.ID});
            this.dgvPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrd.Location = new System.Drawing.Point(0, 0);
            this.dgvPrd.MultiSelect = false;
            this.dgvPrd.Name = "dgvPrd";
            this.dgvPrd.RowTemplate.Height = 24;
            this.dgvPrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrd.Size = new System.Drawing.Size(1086, 233);
            this.dgvPrd.TabIndex = 0;
            this.dgvPrd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrd_CellContentDoubleClick);
            this.dgvPrd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrd_CellDoubleClick);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // TrnType
            // 
            this.TrnType.DataPropertyName = "TransactionType";
            this.TrnType.HeaderText = "Trn. Type";
            this.TrnType.Name = "TrnType";
            // 
            // UOM
            // 
            this.UOM.DataPropertyName = "UOM1";
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            // 
            // PrintOrder
            // 
            this.PrintOrder.DataPropertyName = "PrintOrder";
            this.PrintOrder.HeaderText = "Order";
            this.PrintOrder.Name = "PrintOrder";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 562);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProducts";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).EndInit();
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
        private System.Windows.Forms.Label lfac;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.Label lttyp;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.Label lp;
        private System.Windows.Forms.TextBox tbUOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrnType;
        private System.Windows.Forms.NumericUpDown nOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}