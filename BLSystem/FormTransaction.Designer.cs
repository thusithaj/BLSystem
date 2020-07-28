namespace BLSystem
{
    partial class FormTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaction));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.nAmt = new System.Windows.Forms.NumericUpDown();
            this.lam = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.lQt = new System.Windows.Forms.Label();
            this.cboSup = new System.Windows.Forms.ComboBox();
            this.lts = new System.Windows.Forms.Label();
            this.dtTrnDate = new System.Windows.Forms.DateTimePicker();
            this.ltd = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lti = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1408, 59);
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
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.btnImport);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 458);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1408, 69);
            this.panelBot.TabIndex = 7;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.nAmt);
            this.panelMid.Controls.Add(this.lam);
            this.panelMid.Controls.Add(this.nQty);
            this.panelMid.Controls.Add(this.lQt);
            this.panelMid.Controls.Add(this.cboSup);
            this.panelMid.Controls.Add(this.lts);
            this.panelMid.Controls.Add(this.dtTrnDate);
            this.panelMid.Controls.Add(this.ltd);
            this.panelMid.Controls.Add(this.cboProduct);
            this.panelMid.Controls.Add(this.lti);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 59);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1408, 399);
            this.panelMid.TabIndex = 8;
            // 
            // nAmt
            // 
            this.nAmt.DecimalPlaces = 2;
            this.nAmt.Location = new System.Drawing.Point(853, 61);
            this.nAmt.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
            this.nAmt.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147352576});
            this.nAmt.Name = "nAmt";
            this.nAmt.Size = new System.Drawing.Size(159, 27);
            this.nAmt.TabIndex = 9;
            this.nAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lam
            // 
            this.lam.AutoSize = true;
            this.lam.Location = new System.Drawing.Point(764, 62);
            this.lam.Name = "lam";
            this.lam.Size = new System.Drawing.Size(76, 20);
            this.lam.TabIndex = 8;
            this.lam.Text = "Amount :";
            // 
            // nQty
            // 
            this.nQty.DecimalPlaces = 2;
            this.nQty.Location = new System.Drawing.Point(573, 62);
            this.nQty.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
            this.nQty.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147352576});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(159, 27);
            this.nQty.TabIndex = 7;
            this.nQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lQt
            // 
            this.lQt.AutoSize = true;
            this.lQt.Location = new System.Drawing.Point(522, 64);
            this.lQt.Name = "lQt";
            this.lQt.Size = new System.Drawing.Size(45, 20);
            this.lQt.TabIndex = 6;
            this.lQt.Text = "Qty :";
            // 
            // cboSup
            // 
            this.cboSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(175, 61);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(313, 28);
            this.cboSup.TabIndex = 5;
            // 
            // lts
            // 
            this.lts.AutoSize = true;
            this.lts.Location = new System.Drawing.Point(78, 61);
            this.lts.Name = "lts";
            this.lts.Size = new System.Drawing.Size(80, 20);
            this.lts.TabIndex = 4;
            this.lts.Text = "Supplier :";
            // 
            // dtTrnDate
            // 
            this.dtTrnDate.CustomFormat = "dd/MM/yyyy";
            this.dtTrnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTrnDate.Location = new System.Drawing.Point(812, 21);
            this.dtTrnDate.Name = "dtTrnDate";
            this.dtTrnDate.Size = new System.Drawing.Size(200, 27);
            this.dtTrnDate.TabIndex = 3;
            // 
            // ltd
            // 
            this.ltd.AutoSize = true;
            this.ltd.Location = new System.Drawing.Point(698, 26);
            this.ltd.Name = "ltd";
            this.ltd.Size = new System.Drawing.Size(89, 20);
            this.ltd.TabIndex = 2;
            this.ltd.Text = "Trn. Date :";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(175, 23);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(474, 28);
            this.cboProduct.TabIndex = 1;
            // 
            // lti
            // 
            this.lti.AutoSize = true;
            this.lti.Location = new System.Drawing.Point(14, 26);
            this.lti.Name = "lti";
            this.lti.Size = new System.Drawing.Size(144, 20);
            this.lti.TabIndex = 0;
            this.lti.Text = "Add/Deduct Item :";
            // 
            // btnImport
            // 
            this.btnImport.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(18, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(92, 45);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 527);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTransaction";
            this.Text = "Transaction Entry";
            this.panelTop.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
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
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.NumericUpDown nAmt;
        private System.Windows.Forms.Label lam;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Label lQt;
        private System.Windows.Forms.ComboBox cboSup;
        private System.Windows.Forms.Label lts;
        private System.Windows.Forms.DateTimePicker dtTrnDate;
        private System.Windows.Forms.Label ltd;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lti;
        private System.Windows.Forms.Button btnImport;
    }
}