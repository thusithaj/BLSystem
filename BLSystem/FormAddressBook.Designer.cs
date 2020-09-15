namespace BLSystem
{
    partial class FormAddressBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddressBook));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelMBot = new System.Windows.Forms.Panel();
            this.lmsg = new System.Windows.Forms.Label();
            this.pgAb = new System.Windows.Forms.ProgressBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAL02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAL01 = new System.Windows.Forms.TextBox();
            this.la01 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.lF = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lt = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.dgvAB = new System.Windows.Forms.DataGridView();
            this.ABName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelMBot.SuspendLayout();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAB)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1215, 72);
            this.panelTop.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(626, 16);
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
            this.btnExit.Location = new System.Drawing.Point(882, 19);
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
            this.btnSave.Location = new System.Drawing.Point(754, 18);
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
            this.btnDelete.Location = new System.Drawing.Point(420, 15);
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
            this.btnRefresh.Location = new System.Drawing.Point(286, 15);
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
            this.btnEdit.Location = new System.Drawing.Point(152, 15);
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
            this.btnAdd.Location = new System.Drawing.Point(18, 15);
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
            this.panelMid.Controls.Add(this.panelMBot);
            this.panelMid.Controls.Add(this.textBox1);
            this.panelMid.Controls.Add(this.label2);
            this.panelMid.Controls.Add(this.tbAL02);
            this.panelMid.Controls.Add(this.label1);
            this.panelMid.Controls.Add(this.tbAL01);
            this.panelMid.Controls.Add(this.la01);
            this.panelMid.Controls.Add(this.tbName);
            this.panelMid.Controls.Add(this.ln);
            this.panelMid.Controls.Add(this.cboFactory);
            this.panelMid.Controls.Add(this.lF);
            this.panelMid.Controls.Add(this.cboType);
            this.panelMid.Controls.Add(this.lt);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 72);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1215, 263);
            this.panelMid.TabIndex = 2;
            // 
            // panelMBot
            // 
            this.panelMBot.Controls.Add(this.lmsg);
            this.panelMBot.Controls.Add(this.pgAb);
            this.panelMBot.Controls.Add(this.btnImport);
            this.panelMBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMBot.Location = new System.Drawing.Point(0, 212);
            this.panelMBot.Name = "panelMBot";
            this.panelMBot.Size = new System.Drawing.Size(1215, 51);
            this.panelMBot.TabIndex = 12;
            // 
            // lmsg
            // 
            this.lmsg.AutoSize = true;
            this.lmsg.ForeColor = System.Drawing.Color.Brown;
            this.lmsg.Location = new System.Drawing.Point(512, 19);
            this.lmsg.Name = "lmsg";
            this.lmsg.Size = new System.Drawing.Size(21, 20);
            this.lmsg.TabIndex = 2;
            this.lmsg.Text = "...";
            // 
            // pgAb
            // 
            this.pgAb.Location = new System.Drawing.Point(174, 16);
            this.pgAb.Name = "pgAb";
            this.pgAb.Size = new System.Drawing.Size(298, 23);
            this.pgAb.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Image = global::BLSystem.Properties.Resources.gnome_fs_blockdev;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(49, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 48);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "&Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 27);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "City:";
            // 
            // tbAL02
            // 
            this.tbAL02.Location = new System.Drawing.Point(159, 103);
            this.tbAL02.Name = "tbAL02";
            this.tbAL02.Size = new System.Drawing.Size(549, 27);
            this.tbAL02.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address Line 02:";
            // 
            // tbAL01
            // 
            this.tbAL01.Location = new System.Drawing.Point(683, 61);
            this.tbAL01.Name = "tbAL01";
            this.tbAL01.Size = new System.Drawing.Size(549, 27);
            this.tbAL01.TabIndex = 7;
            // 
            // la01
            // 
            this.la01.AutoSize = true;
            this.la01.Location = new System.Drawing.Point(527, 64);
            this.la01.Name = "la01";
            this.la01.Size = new System.Drawing.Size(136, 20);
            this.la01.TabIndex = 6;
            this.la01.Text = "Address Line 01:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(358, 27);
            this.tbName.TabIndex = 5;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(90, 64);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(63, 20);
            this.ln.TabIndex = 4;
            this.ln.Text = "Name :";
            // 
            // cboFactory
            // 
            this.cboFactory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFactory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.Location = new System.Drawing.Point(683, 24);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(358, 28);
            this.cboFactory.TabIndex = 3;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // lF
            // 
            this.lF.AutoSize = true;
            this.lF.Location = new System.Drawing.Point(588, 27);
            this.lF.Name = "lF";
            this.lF.Size = new System.Drawing.Size(75, 20);
            this.lF.TabIndex = 2;
            this.lF.Text = "Factory :";
            // 
            // cboType
            // 
            this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(159, 24);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(358, 28);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Location = new System.Drawing.Point(98, 27);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(55, 20);
            this.lt.TabIndex = 0;
            this.lt.Text = "Type :";
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.dgvAB);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(0, 335);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1215, 227);
            this.panelBot.TabIndex = 3;
            // 
            // dgvAB
            // 
            this.dgvAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ABName,
            this.AddL01,
            this.AddL02,
            this.City,
            this.ID});
            this.dgvAB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAB.Location = new System.Drawing.Point(0, 0);
            this.dgvAB.Name = "dgvAB";
            this.dgvAB.RowTemplate.Height = 24;
            this.dgvAB.Size = new System.Drawing.Size(1215, 227);
            this.dgvAB.TabIndex = 0;
            // 
            // ABName
            // 
            this.ABName.DataPropertyName = "AddressName";
            this.ABName.HeaderText = "Name";
            this.ABName.Name = "ABName";
            // 
            // AddL01
            // 
            this.AddL01.DataPropertyName = "AddressLine01";
            this.AddL01.HeaderText = "Address Line 01";
            this.AddL01.Name = "AddL01";
            // 
            // AddL02
            // 
            this.AddL02.DataPropertyName = "AddressLine02";
            this.AddL02.HeaderText = "Address Line 02";
            this.AddL02.Name = "AddL02";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            // 
            // FormAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 562);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddressBook";
            this.Text = "Address Book ";
            this.Load += new System.EventHandler(this.FormAddressBook_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panelMBot.ResumeLayout(false);
            this.panelMBot.PerformLayout();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAB)).EndInit();
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
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.Label lF;
        private System.Windows.Forms.Label la01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAL02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAL01;
        private System.Windows.Forms.DataGridView dgvAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddL01;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddL02;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Panel panelMBot;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ProgressBar pgAb;
        private System.Windows.Forms.Label lmsg;
    }
}