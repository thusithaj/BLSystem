namespace BLSystem
{
    partial class FormExtraEntry
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lm = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.lq = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lr = new System.Windows.Forms.Label();
            this.chkLSup = new System.Windows.Forms.CheckedListBox();
            this.dgvSup = new System.Windows.Forms.DataGridView();
            this.lFQ = new System.Windows.Forms.Label();
            this.nFiltQty = new System.Windows.Forms.NumericUpDown();
            this.nFiltDay = new System.Windows.Forms.NumericUpDown();
            this.lFD = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiltQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiltDay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnPrint);
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
            this.panelTop.Size = new System.Drawing.Size(1467, 64);
            this.panelTop.TabIndex = 4;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.nFiltDay);
            this.panelMid.Controls.Add(this.lFD);
            this.panelMid.Controls.Add(this.nFiltQty);
            this.panelMid.Controls.Add(this.lFQ);
            this.panelMid.Controls.Add(this.dtM);
            this.panelMid.Controls.Add(this.lm);
            this.panelMid.Controls.Add(this.nQty);
            this.panelMid.Controls.Add(this.lq);
            this.panelMid.Controls.Add(this.cboRoute);
            this.panelMid.Controls.Add(this.lr);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 64);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1467, 122);
            this.panelMid.TabIndex = 5;
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "dd/MMM/yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(110, 17);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(134, 27);
            this.dtM.TabIndex = 1;
            // 
            // lm
            // 
            this.lm.AutoSize = true;
            this.lm.Location = new System.Drawing.Point(24, 20);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(70, 20);
            this.lm.TabIndex = 0;
            this.lm.Text = "Month  :";
            // 
            // nQty
            // 
            this.nQty.DecimalPlaces = 2;
            this.nQty.Location = new System.Drawing.Point(1010, 17);
            this.nQty.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(157, 27);
            this.nQty.TabIndex = 5;
            this.nQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lq
            // 
            this.lq.AutoSize = true;
            this.lq.Location = new System.Drawing.Point(954, 20);
            this.lq.Name = "lq";
            this.lq.Size = new System.Drawing.Size(50, 20);
            this.lq.TabIndex = 4;
            this.lq.Text = "Qty  :";
            // 
            // cboRoute
            // 
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(372, 16);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(422, 28);
            this.cboRoute.TabIndex = 3;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(298, 20);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(68, 20);
            this.lr.TabIndex = 2;
            this.lr.Text = "Route  :";
            // 
            // chkLSup
            // 
            this.chkLSup.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLSup.FormattingEnabled = true;
            this.chkLSup.Location = new System.Drawing.Point(0, 186);
            this.chkLSup.MultiColumn = true;
            this.chkLSup.Name = "chkLSup";
            this.chkLSup.ScrollAlwaysVisible = true;
            this.chkLSup.Size = new System.Drawing.Size(414, 376);
            this.chkLSup.TabIndex = 6;
            // 
            // dgvSup
            // 
            this.dgvSup.AllowUserToAddRows = false;
            this.dgvSup.AllowUserToDeleteRows = false;
            this.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSup.Location = new System.Drawing.Point(414, 186);
            this.dgvSup.Name = "dgvSup";
            this.dgvSup.ReadOnly = true;
            this.dgvSup.RowTemplate.Height = 24;
            this.dgvSup.Size = new System.Drawing.Size(1053, 376);
            this.dgvSup.TabIndex = 7;
            // 
            // lFQ
            // 
            this.lFQ.AutoSize = true;
            this.lFQ.Location = new System.Drawing.Point(24, 63);
            this.lFQ.Name = "lFQ";
            this.lFQ.Size = new System.Drawing.Size(88, 20);
            this.lFQ.TabIndex = 6;
            this.lFQ.Text = "Filter Qty :";
            // 
            // nFiltQty
            // 
            this.nFiltQty.DecimalPlaces = 2;
            this.nFiltQty.Location = new System.Drawing.Point(132, 61);
            this.nFiltQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nFiltQty.Name = "nFiltQty";
            this.nFiltQty.Size = new System.Drawing.Size(157, 27);
            this.nFiltQty.TabIndex = 7;
            this.nFiltQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nFiltDay
            // 
            this.nFiltDay.Location = new System.Drawing.Point(426, 63);
            this.nFiltDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nFiltDay.Name = "nFiltDay";
            this.nFiltDay.Size = new System.Drawing.Size(157, 27);
            this.nFiltDay.TabIndex = 9;
            this.nFiltDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lFD
            // 
            this.lFD.AutoSize = true;
            this.lFD.Location = new System.Drawing.Point(318, 65);
            this.lFD.Name = "lFD";
            this.lFD.Size = new System.Drawing.Size(101, 20);
            this.lFD.TabIndex = 8;
            this.lFD.Text = "Filter Days :";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::BLSystem.Properties.Resources.document_print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(766, -1);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 56);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BLSystem.Properties.Resources.db_add;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(520, -1);
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
            this.btnExit.Location = new System.Drawing.Point(1315, 2);
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
            this.btnSave.Location = new System.Drawing.Point(643, -1);
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
            this.btnDelete.Location = new System.Drawing.Point(397, -1);
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
            this.btnRefresh.Location = new System.Drawing.Point(274, -1);
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
            this.btnEdit.Location = new System.Drawing.Point(151, -1);
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
            // 
            // FormExtraEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 562);
            this.Controls.Add(this.dgvSup);
            this.Controls.Add(this.chkLSup);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExtraEntry";
            this.Text = "Extra Entry";
            this.Load += new System.EventHandler(this.FormExtraEntry_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiltQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiltDay)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Label lq;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.CheckedListBox chkLSup;
        private System.Windows.Forms.Label lm;
        private System.Windows.Forms.DateTimePicker dtM;
        private System.Windows.Forms.DataGridView dgvSup;
        private System.Windows.Forms.NumericUpDown nFiltDay;
        private System.Windows.Forms.Label lFD;
        private System.Windows.Forms.NumericUpDown nFiltQty;
        private System.Windows.Forms.Label lFQ;
        private System.Windows.Forms.Button btnPrint;
    }
}