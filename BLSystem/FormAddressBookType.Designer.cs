namespace BLSystem
{
    partial class formAddressBookType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddressBookType));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.lco = new System.Windows.Forms.Label();
            this.tbABTypeName = new System.Windows.Forms.TextBox();
            this.lTName = new System.Windows.Forms.Label();
            this.lc03 = new System.Windows.Forms.Label();
            this.lc02 = new System.Windows.Forms.Label();
            this.tbCat01 = new System.Windows.Forms.TextBox();
            this.tbCat03 = new System.Windows.Forms.TextBox();
            this.tbCat02 = new System.Windows.Forms.TextBox();
            this.lc01 = new System.Windows.Forms.Label();
            this.lCat01 = new System.Windows.Forms.Label();
            this.cboAddressBookType = new System.Windows.Forms.ComboBox();
            this.panelBot = new System.Windows.Forms.Panel();
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1384, 89);
            this.panelTop.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(541, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 61);
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
            this.btnExit.Location = new System.Drawing.Point(746, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 61);
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
            this.btnSave.Location = new System.Drawing.Point(644, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 61);
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
            this.btnDelete.Location = new System.Drawing.Point(338, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 61);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::BLSystem.Properties.Resources.document_quick_restart1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(219, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 61);
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
            this.btnEdit.Location = new System.Drawing.Point(116, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 61);
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
            this.btnAdd.Location = new System.Drawing.Point(14, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 61);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.panel1);
            this.panelMid.Controls.Add(this.lCat01);
            this.panelMid.Controls.Add(this.cboAddressBookType);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 89);
            this.panelMid.Margin = new System.Windows.Forms.Padding(4);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1384, 293);
            this.panelMid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCom);
            this.panel1.Controls.Add(this.lco);
            this.panel1.Controls.Add(this.tbABTypeName);
            this.panel1.Controls.Add(this.lTName);
            this.panel1.Controls.Add(this.lc03);
            this.panel1.Controls.Add(this.lc02);
            this.panel1.Controls.Add(this.tbCat01);
            this.panel1.Controls.Add(this.tbCat03);
            this.panel1.Controls.Add(this.tbCat02);
            this.panel1.Controls.Add(this.lc01);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 276);
            this.panel1.TabIndex = 4;
            // 
            // cboCom
            // 
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(145, 226);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(436, 28);
            this.cboCom.TabIndex = 10;
            this.cboCom.SelectedIndexChanged += new System.EventHandler(this.cboCom_SelectedIndexChanged);
            // 
            // lco
            // 
            this.lco.AutoSize = true;
            this.lco.Location = new System.Drawing.Point(26, 226);
            this.lco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lco.Name = "lco";
            this.lco.Size = new System.Drawing.Size(89, 20);
            this.lco.TabIndex = 9;
            this.lco.Text = "Company :";
            // 
            // tbABTypeName
            // 
            this.tbABTypeName.Location = new System.Drawing.Point(145, 21);
            this.tbABTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.tbABTypeName.Name = "tbABTypeName";
            this.tbABTypeName.Size = new System.Drawing.Size(436, 27);
            this.tbABTypeName.TabIndex = 1;
            this.tbABTypeName.Enter += new System.EventHandler(this.tbABTypeName_Enter);
            // 
            // lTName
            // 
            this.lTName.AutoSize = true;
            this.lTName.Location = new System.Drawing.Point(26, 21);
            this.lTName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTName.Name = "lTName";
            this.lTName.Size = new System.Drawing.Size(104, 20);
            this.lTName.TabIndex = 0;
            this.lTName.Text = "Type Name :";
            // 
            // lc03
            // 
            this.lc03.AutoSize = true;
            this.lc03.Location = new System.Drawing.Point(26, 179);
            this.lc03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lc03.Name = "lc03";
            this.lc03.Size = new System.Drawing.Size(109, 20);
            this.lc03.TabIndex = 6;
            this.lc03.Text = "Category 03 :";
            // 
            // lc02
            // 
            this.lc02.AutoSize = true;
            this.lc02.Location = new System.Drawing.Point(25, 126);
            this.lc02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lc02.Name = "lc02";
            this.lc02.Size = new System.Drawing.Size(109, 20);
            this.lc02.TabIndex = 4;
            this.lc02.Text = "Category 02 :";
            // 
            // tbCat01
            // 
            this.tbCat01.AutoCompleteCustomSource.AddRange(new string[] {
            "Purchase",
            "Sales",
            "Routes",
            "None",
            "Financial"});
            this.tbCat01.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbCat01.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCat01.Location = new System.Drawing.Point(145, 70);
            this.tbCat01.Margin = new System.Windows.Forms.Padding(4);
            this.tbCat01.Name = "tbCat01";
            this.tbCat01.Size = new System.Drawing.Size(436, 27);
            this.tbCat01.TabIndex = 3;
            // 
            // tbCat03
            // 
            this.tbCat03.Location = new System.Drawing.Point(145, 179);
            this.tbCat03.Margin = new System.Windows.Forms.Padding(4);
            this.tbCat03.Name = "tbCat03";
            this.tbCat03.Size = new System.Drawing.Size(436, 27);
            this.tbCat03.TabIndex = 7;
            // 
            // tbCat02
            // 
            this.tbCat02.Location = new System.Drawing.Point(145, 126);
            this.tbCat02.Margin = new System.Windows.Forms.Padding(4);
            this.tbCat02.Name = "tbCat02";
            this.tbCat02.Size = new System.Drawing.Size(436, 27);
            this.tbCat02.TabIndex = 5;
            // 
            // lc01
            // 
            this.lc01.AutoSize = true;
            this.lc01.Location = new System.Drawing.Point(26, 70);
            this.lc01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lc01.Name = "lc01";
            this.lc01.Size = new System.Drawing.Size(109, 20);
            this.lc01.TabIndex = 2;
            this.lc01.Text = "Category 01 :";
            // 
            // lCat01
            // 
            this.lCat01.AutoSize = true;
            this.lCat01.Location = new System.Drawing.Point(26, 70);
            this.lCat01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCat01.Name = "lCat01";
            this.lCat01.Size = new System.Drawing.Size(109, 20);
            this.lCat01.TabIndex = 2;
            this.lCat01.Text = "Category 01 :";
            // 
            // cboAddressBookType
            // 
            this.cboAddressBookType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAddressBookType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAddressBookType.FormattingEnabled = true;
            this.cboAddressBookType.Location = new System.Drawing.Point(145, 18);
            this.cboAddressBookType.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddressBookType.Name = "cboAddressBookType";
            this.cboAddressBookType.Size = new System.Drawing.Size(436, 28);
            this.cboAddressBookType.TabIndex = 1;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.dgvType);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(0, 382);
            this.panelBot.Margin = new System.Windows.Forms.Padding(4);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1384, 389);
            this.panelBot.TabIndex = 2;
            // 
            // dgvType
            // 
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeName,
            this.Cat01,
            this.Cat02,
            this.Cat03,
            this.ID});
            this.dgvType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvType.Location = new System.Drawing.Point(0, 0);
            this.dgvType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvType.Name = "dgvType";
            this.dgvType.RowTemplate.Height = 24;
            this.dgvType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvType.Size = new System.Drawing.Size(1384, 389);
            this.dgvType.TabIndex = 0;
            this.dgvType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvType_CellDoubleClick);
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "BookTypeName";
            this.TypeName.HeaderText = "Type Name";
            this.TypeName.Name = "TypeName";
            // 
            // Cat01
            // 
            this.Cat01.DataPropertyName = "Category01";
            this.Cat01.HeaderText = "Category 01";
            this.Cat01.Name = "Cat01";
            // 
            // Cat02
            // 
            this.Cat02.DataPropertyName = "Category02";
            this.Cat02.HeaderText = "Category 02";
            this.Cat02.Name = "Cat02";
            // 
            // Cat03
            // 
            this.Cat03.DataPropertyName = "Category03";
            this.Cat03.HeaderText = "Category03";
            this.Cat03.Name = "Cat03";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // formAddressBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 771);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAddressBookType";
            this.Text = "Address Book Type";
            this.Load += new System.EventHandler(this.formAddressBookType_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.ComboBox cboAddressBookType;
        private System.Windows.Forms.Label lCat01;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCat03;
        private System.Windows.Forms.TextBox tbCat02;
        private System.Windows.Forms.Label lc01;
        private System.Windows.Forms.Label lTName;
        private System.Windows.Forms.Label lc03;
        private System.Windows.Forms.Label lc02;
        private System.Windows.Forms.TextBox tbCat01;
        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat02;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat03;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox tbABTypeName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label lco;
    }
}

