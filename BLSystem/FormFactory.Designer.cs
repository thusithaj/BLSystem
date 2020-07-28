namespace BLSystem
{
    partial class FormFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactory));
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
            this.lfn = new System.Windows.Forms.Label();
            this.tbFacName = new System.Windows.Forms.TextBox();
            this.lCo = new System.Windows.Forms.Label();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.dgvFac = new System.Windows.Forms.DataGridView();
            this.Factory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1082, 59);
            this.panelTop.TabIndex = 3;
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
            this.panelMid.Controls.Add(this.cboCom);
            this.panelMid.Controls.Add(this.lCo);
            this.panelMid.Controls.Add(this.tbFacName);
            this.panelMid.Controls.Add(this.lfn);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 59);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1082, 124);
            this.panelMid.TabIndex = 4;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.dgvFac);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(0, 183);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1082, 379);
            this.panelBot.TabIndex = 5;
            // 
            // lfn
            // 
            this.lfn.AutoSize = true;
            this.lfn.Location = new System.Drawing.Point(552, 22);
            this.lfn.Name = "lfn";
            this.lfn.Size = new System.Drawing.Size(68, 20);
            this.lfn.TabIndex = 0;
            this.lfn.Text = "Name : ";
            // 
            // tbFacName
            // 
            this.tbFacName.Location = new System.Drawing.Point(626, 19);
            this.tbFacName.Name = "tbFacName";
            this.tbFacName.Size = new System.Drawing.Size(384, 27);
            this.tbFacName.TabIndex = 1;
            // 
            // lCo
            // 
            this.lCo.AutoSize = true;
            this.lCo.Location = new System.Drawing.Point(14, 22);
            this.lCo.Name = "lCo";
            this.lCo.Size = new System.Drawing.Size(94, 20);
            this.lCo.TabIndex = 2;
            this.lCo.Text = "Company : ";
            // 
            // cboCom
            // 
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(114, 18);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(370, 28);
            this.cboCom.TabIndex = 3;
            this.cboCom.SelectedIndexChanged += new System.EventHandler(this.cboCom_SelectedIndexChanged);
            // 
            // dgvFac
            // 
            this.dgvFac.AllowUserToAddRows = false;
            this.dgvFac.AllowUserToDeleteRows = false;
            this.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factory,
            this.ID,
            this.Company});
            this.dgvFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFac.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFac.Location = new System.Drawing.Point(0, 0);
            this.dgvFac.Name = "dgvFac";
            this.dgvFac.RowTemplate.Height = 24;
            this.dgvFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFac.Size = new System.Drawing.Size(1082, 379);
            this.dgvFac.TabIndex = 0;
            this.dgvFac.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFac_CellContentDoubleClick);
            // 
            // Factory
            // 
            this.Factory.DataPropertyName = "FactoryName";
            this.Factory.HeaderText = "Factory";
            this.Factory.Name = "Factory";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "CompanyMaster.CompanyName";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // FormFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 562);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFactory";
            this.Text = "Factory";
            this.Load += new System.EventHandler(this.FormFactory_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label lCo;
        private System.Windows.Forms.TextBox tbFacName;
        private System.Windows.Forms.Label lfn;
        private System.Windows.Forms.DataGridView dgvFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
    }
}