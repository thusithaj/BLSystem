namespace BLSystem
{
    partial class FormPriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPriceList));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.dgvSes = new System.Windows.Forms.DataGridView();
            this.litm = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.cboSup = new System.Windows.Forms.ComboBox();
            this.lprt = new System.Windows.Forms.Label();
            this.ldts = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lamt = new System.Windows.Forms.Label();
            this.nAmt = new System.Windows.Forms.NumericUpDown();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.EffectFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTrType = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1068, 59);
            this.panelTop.TabIndex = 5;
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
            this.panelMid.Controls.Add(this.cboTrType);
            this.panelMid.Controls.Add(this.chkActive);
            this.panelMid.Controls.Add(this.nAmt);
            this.panelMid.Controls.Add(this.lamt);
            this.panelMid.Controls.Add(this.dtTo);
            this.panelMid.Controls.Add(this.dtFrom);
            this.panelMid.Controls.Add(this.ldts);
            this.panelMid.Controls.Add(this.cboSup);
            this.panelMid.Controls.Add(this.lprt);
            this.panelMid.Controls.Add(this.cboProduct);
            this.panelMid.Controls.Add(this.litm);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 59);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1068, 165);
            this.panelMid.TabIndex = 7;
            // 
            // dgvSes
            // 
            this.dgvSes.AllowUserToAddRows = false;
            this.dgvSes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EffectFrom,
            this.EffectTo,
            this.ProductId,
            this.PartnerId,
            this.Amount,
            this.Status});
            this.dgvSes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSes.Location = new System.Drawing.Point(0, 224);
            this.dgvSes.Name = "dgvSes";
            this.dgvSes.RowTemplate.Height = 24;
            this.dgvSes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSes.Size = new System.Drawing.Size(1068, 338);
            this.dgvSes.TabIndex = 8;
            this.dgvSes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSes_CellDoubleClick);
            // 
            // litm
            // 
            this.litm.AutoSize = true;
            this.litm.Location = new System.Drawing.Point(32, 20);
            this.litm.Name = "litm";
            this.litm.Size = new System.Drawing.Size(51, 20);
            this.litm.TabIndex = 0;
            this.litm.Text = "Item :";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(89, 17);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(370, 28);
            this.cboProduct.TabIndex = 1;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // cboSup
            // 
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(556, 20);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(370, 28);
            this.cboSup.TabIndex = 3;
            this.cboSup.SelectedIndexChanged += new System.EventHandler(this.cboSup_SelectedIndexChanged);
            // 
            // lprt
            // 
            this.lprt.AutoSize = true;
            this.lprt.Location = new System.Drawing.Point(479, 23);
            this.lprt.Name = "lprt";
            this.lprt.Size = new System.Drawing.Size(74, 20);
            this.lprt.TabIndex = 2;
            this.lprt.Text = "Partner :";
            // 
            // ldts
            // 
            this.ldts.AutoSize = true;
            this.ldts.Location = new System.Drawing.Point(19, 59);
            this.ldts.Name = "ldts";
            this.ldts.Size = new System.Drawing.Size(64, 20);
            this.ldts.TabIndex = 4;
            this.ldts.Text = "Dates :";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(89, 59);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(115, 27);
            this.dtFrom.TabIndex = 5;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(223, 59);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(115, 27);
            this.dtTo.TabIndex = 6;
            // 
            // lamt
            // 
            this.lamt.AutoSize = true;
            this.lamt.Location = new System.Drawing.Point(477, 59);
            this.lamt.Name = "lamt";
            this.lamt.Size = new System.Drawing.Size(76, 20);
            this.lamt.TabIndex = 7;
            this.lamt.Text = "Amount :";
            // 
            // nAmt
            // 
            this.nAmt.DecimalPlaces = 2;
            this.nAmt.Location = new System.Drawing.Point(559, 57);
            this.nAmt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nAmt.Name = "nAmt";
            this.nAmt.Size = new System.Drawing.Size(154, 27);
            this.nAmt.TabIndex = 8;
            this.nAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(89, 105);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(77, 24);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // EffectFrom
            // 
            this.EffectFrom.DataPropertyName = "EffectFrom";
            this.EffectFrom.HeaderText = "From date";
            this.EffectFrom.Name = "EffectFrom";
            // 
            // EffectTo
            // 
            this.EffectTo.DataPropertyName = "EffectTo";
            this.EffectTo.HeaderText = "To date";
            this.EffectTo.Name = "EffectTo";
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            // 
            // PartnerId
            // 
            this.PartnerId.DataPropertyName = "PartnerId";
            this.PartnerId.FillWeight = 200F;
            this.PartnerId.HeaderText = "Partner";
            this.PartnerId.Name = "PartnerId";
            this.PartnerId.Width = 200;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Price";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // cboTrType
            // 
            this.cboTrType.FormattingEnabled = true;
            this.cboTrType.Location = new System.Drawing.Point(197, 101);
            this.cboTrType.Name = "cboTrType";
            this.cboTrType.Size = new System.Drawing.Size(474, 28);
            this.cboTrType.TabIndex = 10;
            this.cboTrType.Visible = false;
            this.cboTrType.SelectedIndexChanged += new System.EventHandler(this.cboTrType_SelectedIndexChanged);
            // 
            // FormPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.dgvSes);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPriceList";
            this.Text = "Price List";
            this.Load += new System.EventHandler(this.FormPriceList_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSes;
        private System.Windows.Forms.NumericUpDown nAmt;
        private System.Windows.Forms.Label lamt;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label ldts;
        private System.Windows.Forms.ComboBox cboSup;
        private System.Windows.Forms.Label lprt;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label litm;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cboTrType;
    }
}