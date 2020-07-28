namespace BLSystem
{
    partial class FormSupplierMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplierMaster));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lrt = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtp02 = new System.Windows.Forms.TextBox();
            this.ltp02 = new System.Windows.Forms.Label();
            this.tbTp01 = new System.Windows.Forms.TextBox();
            this.ltp01 = new System.Windows.Forms.Label();
            this.pnlimp = new System.Windows.Forms.Panel();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.bImport = new System.Windows.Forms.Button();
            this.chkbDel = new System.Windows.Forms.CheckBox();
            this.dtLLD = new System.Windows.Forms.DateTimePicker();
            this.lLfd = new System.Windows.Forms.Label();
            this.chkbStatus = new System.Windows.Forms.CheckBox();
            this.tbWelfareId = new System.Windows.Forms.TextBox();
            this.lwfn = new System.Windows.Forms.Label();
            this.dtSDate = new System.Windows.Forms.DateTimePicker();
            this.ls = new System.Windows.Forms.Label();
            this.chkbSaving = new System.Windows.Forms.CheckBox();
            this.dtWRegDate = new System.Windows.Forms.DateTimePicker();
            this.lWD = new System.Windows.Forms.Label();
            this.chkbWF = new System.Windows.Forms.CheckBox();
            this.nRegNo = new System.Windows.Forms.NumericUpDown();
            this.lRNo = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lcity = new System.Windows.Forms.Label();
            this.tbAL02 = new System.Windows.Forms.TextBox();
            this.lAl02 = new System.Windows.Forms.Label();
            this.tbAL01 = new System.Windows.Forms.TextBox();
            this.la01 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.lF = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lt = new System.Windows.Forms.Label();
            this.tc01 = new System.Windows.Forms.TabControl();
            this.tpSupMaster = new System.Windows.Forms.TabPage();
            this.tpSupList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.pnlimp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRegNo)).BeginInit();
            this.tc01.SuspendLayout();
            this.tpSupMaster.SuspendLayout();
            this.tpSupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1231, 59);
            this.panelTop.TabIndex = 4;
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
            this.panelMid.Controls.Add(this.dtRegDate);
            this.panelMid.Controls.Add(this.label2);
            this.panelMid.Controls.Add(this.cboRoute);
            this.panelMid.Controls.Add(this.lrt);
            this.panelMid.Controls.Add(this.tbemail);
            this.panelMid.Controls.Add(this.label1);
            this.panelMid.Controls.Add(this.tbtp02);
            this.panelMid.Controls.Add(this.ltp02);
            this.panelMid.Controls.Add(this.tbTp01);
            this.panelMid.Controls.Add(this.ltp01);
            this.panelMid.Controls.Add(this.pnlimp);
            this.panelMid.Controls.Add(this.chkbDel);
            this.panelMid.Controls.Add(this.dtLLD);
            this.panelMid.Controls.Add(this.lLfd);
            this.panelMid.Controls.Add(this.chkbStatus);
            this.panelMid.Controls.Add(this.tbWelfareId);
            this.panelMid.Controls.Add(this.lwfn);
            this.panelMid.Controls.Add(this.dtSDate);
            this.panelMid.Controls.Add(this.ls);
            this.panelMid.Controls.Add(this.chkbSaving);
            this.panelMid.Controls.Add(this.dtWRegDate);
            this.panelMid.Controls.Add(this.lWD);
            this.panelMid.Controls.Add(this.chkbWF);
            this.panelMid.Controls.Add(this.nRegNo);
            this.panelMid.Controls.Add(this.lRNo);
            this.panelMid.Controls.Add(this.tbCity);
            this.panelMid.Controls.Add(this.lcity);
            this.panelMid.Controls.Add(this.tbAL02);
            this.panelMid.Controls.Add(this.lAl02);
            this.panelMid.Controls.Add(this.tbAL01);
            this.panelMid.Controls.Add(this.la01);
            this.panelMid.Controls.Add(this.tbName);
            this.panelMid.Controls.Add(this.ln);
            this.panelMid.Controls.Add(this.cboFactory);
            this.panelMid.Controls.Add(this.lF);
            this.panelMid.Controls.Add(this.cboType);
            this.panelMid.Controls.Add(this.lt);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(3, 3);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1217, 464);
            this.panelMid.TabIndex = 0;
            // 
            // cboRoute
            // 
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(902, 30);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(257, 28);
            this.cboRoute.TabIndex = 35;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lrt
            // 
            this.lrt.AutoSize = true;
            this.lrt.Location = new System.Drawing.Point(821, 33);
            this.lrt.Name = "lrt";
            this.lrt.Size = new System.Drawing.Size(63, 20);
            this.lrt.TabIndex = 34;
            this.lrt.Text = "Route :";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(145, 284);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(449, 27);
            this.tbemail.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Email :";
            // 
            // tbtp02
            // 
            this.tbtp02.Location = new System.Drawing.Point(724, 241);
            this.tbtp02.Name = "tbtp02";
            this.tbtp02.Size = new System.Drawing.Size(435, 27);
            this.tbtp02.TabIndex = 31;
            // 
            // ltp02
            // 
            this.ltp02.AutoSize = true;
            this.ltp02.Location = new System.Drawing.Point(601, 244);
            this.ltp02.Name = "ltp02";
            this.ltp02.Size = new System.Drawing.Size(114, 20);
            this.ltp02.TabIndex = 30;
            this.ltp02.Text = "Telephone 02:";
            // 
            // tbTp01
            // 
            this.tbTp01.Location = new System.Drawing.Point(145, 241);
            this.tbTp01.Name = "tbTp01";
            this.tbTp01.Size = new System.Drawing.Size(449, 27);
            this.tbTp01.TabIndex = 29;
            // 
            // ltp01
            // 
            this.ltp01.AutoSize = true;
            this.ltp01.Location = new System.Drawing.Point(22, 244);
            this.ltp01.Name = "ltp01";
            this.ltp01.Size = new System.Drawing.Size(114, 20);
            this.ltp01.TabIndex = 28;
            this.ltp01.Text = "Telephone 01:";
            // 
            // pnlimp
            // 
            this.pnlimp.Controls.Add(this.pgb);
            this.pnlimp.Controls.Add(this.bImport);
            this.pnlimp.Location = new System.Drawing.Point(11, 394);
            this.pnlimp.Name = "pnlimp";
            this.pnlimp.Size = new System.Drawing.Size(795, 65);
            this.pnlimp.TabIndex = 27;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(154, 26);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(576, 23);
            this.pgb.TabIndex = 27;
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(27, 15);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 39);
            this.bImport.TabIndex = 26;
            this.bImport.Text = "&Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // chkbDel
            // 
            this.chkbDel.AutoSize = true;
            this.chkbDel.Location = new System.Drawing.Point(515, 207);
            this.chkbDel.Name = "chkbDel";
            this.chkbDel.Size = new System.Drawing.Size(89, 24);
            this.chkbDel.TabIndex = 25;
            this.chkbDel.Text = "Deleted";
            this.chkbDel.UseVisualStyleBackColor = true;
            // 
            // dtLLD
            // 
            this.dtLLD.CustomFormat = "dd/MM/yyyy";
            this.dtLLD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLLD.Location = new System.Drawing.Point(279, 208);
            this.dtLLD.Name = "dtLLD";
            this.dtLLD.Size = new System.Drawing.Size(193, 27);
            this.dtLLD.TabIndex = 24;
            // 
            // lLfd
            // 
            this.lLfd.AutoSize = true;
            this.lLfd.Location = new System.Drawing.Point(141, 208);
            this.lLfd.Name = "lLfd";
            this.lLfd.Size = new System.Drawing.Size(131, 20);
            this.lLfd.TabIndex = 23;
            this.lLfd.Text = "Last Leaf Date :";
            // 
            // chkbStatus
            // 
            this.chkbStatus.AutoSize = true;
            this.chkbStatus.Location = new System.Drawing.Point(60, 208);
            this.chkbStatus.Name = "chkbStatus";
            this.chkbStatus.Size = new System.Drawing.Size(79, 24);
            this.chkbStatus.TabIndex = 22;
            this.chkbStatus.Text = "Status";
            this.chkbStatus.UseVisualStyleBackColor = true;
            // 
            // tbWelfareId
            // 
            this.tbWelfareId.Location = new System.Drawing.Point(143, 165);
            this.tbWelfareId.Name = "tbWelfareId";
            this.tbWelfareId.Size = new System.Drawing.Size(449, 27);
            this.tbWelfareId.TabIndex = 18;
            // 
            // lwfn
            // 
            this.lwfn.AutoSize = true;
            this.lwfn.Location = new System.Drawing.Point(34, 165);
            this.lwfn.Name = "lwfn";
            this.lwfn.Size = new System.Drawing.Size(103, 20);
            this.lwfn.TabIndex = 17;
            this.lwfn.Text = "Welfare No :";
            // 
            // dtSDate
            // 
            this.dtSDate.CustomFormat = "dd/MM/yyyy";
            this.dtSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSDate.Location = new System.Drawing.Point(966, 165);
            this.dtSDate.Name = "dtSDate";
            this.dtSDate.Size = new System.Drawing.Size(193, 27);
            this.dtSDate.TabIndex = 21;
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Location = new System.Drawing.Point(805, 165);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(154, 20);
            this.ls.TabIndex = 20;
            this.ls.Text = "Saving  Reg. Date :";
            // 
            // chkbSaving
            // 
            this.chkbSaving.AutoSize = true;
            this.chkbSaving.Location = new System.Drawing.Point(609, 165);
            this.chkbSaving.Name = "chkbSaving";
            this.chkbSaving.Size = new System.Drawing.Size(167, 24);
            this.chkbSaving.TabIndex = 19;
            this.chkbSaving.Text = "Saving Registered";
            this.chkbSaving.UseVisualStyleBackColor = true;
            // 
            // dtWRegDate
            // 
            this.dtWRegDate.CustomFormat = "dd/MM/yyyy";
            this.dtWRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWRegDate.Location = new System.Drawing.Point(966, 132);
            this.dtWRegDate.Name = "dtWRegDate";
            this.dtWRegDate.Size = new System.Drawing.Size(193, 27);
            this.dtWRegDate.TabIndex = 16;
            // 
            // lWD
            // 
            this.lWD.AutoSize = true;
            this.lWD.Location = new System.Drawing.Point(797, 132);
            this.lWD.Name = "lWD";
            this.lWD.Size = new System.Drawing.Size(162, 20);
            this.lWD.TabIndex = 15;
            this.lWD.Text = "Welfare  Reg. Date :";
            // 
            // chkbWF
            // 
            this.chkbWF.AutoSize = true;
            this.chkbWF.Location = new System.Drawing.Point(609, 132);
            this.chkbWF.Name = "chkbWF";
            this.chkbWF.Size = new System.Drawing.Size(175, 24);
            this.chkbWF.TabIndex = 14;
            this.chkbWF.Text = "Welfare Registered";
            this.chkbWF.UseVisualStyleBackColor = true;
            // 
            // nRegNo
            // 
            this.nRegNo.Location = new System.Drawing.Point(145, 62);
            this.nRegNo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nRegNo.Name = "nRegNo";
            this.nRegNo.Size = new System.Drawing.Size(120, 27);
            this.nRegNo.TabIndex = 5;
            // 
            // lRNo
            // 
            this.lRNo.AutoSize = true;
            this.lRNo.Location = new System.Drawing.Point(66, 65);
            this.lRNo.Name = "lRNo";
            this.lRNo.Size = new System.Drawing.Size(75, 20);
            this.lRNo.TabIndex = 4;
            this.lRNo.Text = "Reg No :";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(145, 129);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(449, 27);
            this.tbCity.TabIndex = 13;
            // 
            // lcity
            // 
            this.lcity.AutoSize = true;
            this.lcity.Location = new System.Drawing.Point(95, 132);
            this.lcity.Name = "lcity";
            this.lcity.Size = new System.Drawing.Size(43, 20);
            this.lcity.TabIndex = 12;
            this.lcity.Text = "City:";
            // 
            // tbAL02
            // 
            this.tbAL02.Location = new System.Drawing.Point(747, 98);
            this.tbAL02.Name = "tbAL02";
            this.tbAL02.Size = new System.Drawing.Size(412, 27);
            this.tbAL02.TabIndex = 11;
            // 
            // lAl02
            // 
            this.lAl02.AutoSize = true;
            this.lAl02.Location = new System.Drawing.Point(605, 101);
            this.lAl02.Name = "lAl02";
            this.lAl02.Size = new System.Drawing.Size(136, 20);
            this.lAl02.TabIndex = 10;
            this.lAl02.Text = "Address Line 02:";
            // 
            // tbAL01
            // 
            this.tbAL01.Location = new System.Drawing.Point(145, 96);
            this.tbAL01.Name = "tbAL01";
            this.tbAL01.Size = new System.Drawing.Size(449, 27);
            this.tbAL01.TabIndex = 9;
            // 
            // la01
            // 
            this.la01.AutoSize = true;
            this.la01.Location = new System.Drawing.Point(2, 99);
            this.la01.Name = "la01";
            this.la01.Size = new System.Drawing.Size(136, 20);
            this.la01.TabIndex = 8;
            this.la01.Text = "Address Line 01:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(466, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(693, 27);
            this.tbName.TabIndex = 7;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(382, 68);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(63, 20);
            this.ln.TabIndex = 6;
            this.ln.Text = "Name :";
            // 
            // cboFactory
            // 
            this.cboFactory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFactory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.Location = new System.Drawing.Point(593, 27);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(213, 28);
            this.cboFactory.TabIndex = 3;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // lF
            // 
            this.lF.AutoSize = true;
            this.lF.Location = new System.Drawing.Point(512, 30);
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
            this.cboType.Location = new System.Drawing.Point(145, 27);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(358, 28);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Location = new System.Drawing.Point(84, 30);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(55, 20);
            this.lt.TabIndex = 0;
            this.lt.Text = "Type :";
            // 
            // tc01
            // 
            this.tc01.Controls.Add(this.tpSupMaster);
            this.tc01.Controls.Add(this.tpSupList);
            this.tc01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc01.Location = new System.Drawing.Point(0, 59);
            this.tc01.Name = "tc01";
            this.tc01.SelectedIndex = 0;
            this.tc01.Size = new System.Drawing.Size(1231, 503);
            this.tc01.TabIndex = 6;
            // 
            // tpSupMaster
            // 
            this.tpSupMaster.Controls.Add(this.panelMid);
            this.tpSupMaster.Location = new System.Drawing.Point(4, 29);
            this.tpSupMaster.Name = "tpSupMaster";
            this.tpSupMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupMaster.Size = new System.Drawing.Size(1223, 470);
            this.tpSupMaster.TabIndex = 0;
            this.tpSupMaster.Text = "Supplier Master";
            this.tpSupMaster.UseVisualStyleBackColor = true;
            // 
            // tpSupList
            // 
            this.tpSupList.Controls.Add(this.dataGridView1);
            this.tpSupList.Location = new System.Drawing.Point(4, 29);
            this.tpSupList.Name = "tpSupList";
            this.tpSupList.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupList.Size = new System.Drawing.Size(1223, 470);
            this.tpSupList.TabIndex = 1;
            this.tpSupList.Text = "Supplier List";
            this.tpSupList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.AddressL01,
            this.AddressL02,
            this.id,
            this.RegNo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            // 
            // AddressL01
            // 
            this.AddressL01.HeaderText = "Address Line 01";
            this.AddressL01.Name = "AddressL01";
            // 
            // AddressL02
            // 
            this.AddressL02.HeaderText = "AddressLine02";
            this.AddressL02.Name = "AddressL02";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // RegNo
            // 
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.Name = "RegNo";
            // 
            // dtRegDate
            // 
            this.dtRegDate.CustomFormat = "dd/MM/yyyy";
            this.dtRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRegDate.Location = new System.Drawing.Point(966, 203);
            this.dtRegDate.Name = "dtRegDate";
            this.dtRegDate.Size = new System.Drawing.Size(193, 27);
            this.dtRegDate.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Registered Date :";
            // 
            // FormSupplierMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 562);
            this.Controls.Add(this.tc01);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplierMaster";
            this.Text = "Supplier Master";
            this.Load += new System.EventHandler(this.FormSupplierMaster_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.pnlimp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nRegNo)).EndInit();
            this.tc01.ResumeLayout(false);
            this.tpSupMaster.ResumeLayout(false);
            this.tpSupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tc01;
        private System.Windows.Forms.TabPage tpSupMaster;
        private System.Windows.Forms.TabPage tpSupList;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lcity;
        private System.Windows.Forms.TextBox tbAL02;
        private System.Windows.Forms.Label lAl02;
        private System.Windows.Forms.TextBox tbAL01;
        private System.Windows.Forms.Label la01;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.Label lF;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.Label lRNo;
        private System.Windows.Forms.NumericUpDown nRegNo;
        private System.Windows.Forms.DateTimePicker dtSDate;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.CheckBox chkbSaving;
        private System.Windows.Forms.DateTimePicker dtWRegDate;
        private System.Windows.Forms.Label lWD;
        private System.Windows.Forms.CheckBox chkbWF;
        private System.Windows.Forms.TextBox tbWelfareId;
        private System.Windows.Forms.Label lwfn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressL01;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressL02;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DateTimePicker dtLLD;
        private System.Windows.Forms.Label lLfd;
        private System.Windows.Forms.CheckBox chkbStatus;
        private System.Windows.Forms.CheckBox chkbDel;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Panel pnlimp;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.TextBox tbTp01;
        private System.Windows.Forms.Label ltp01;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtp02;
        private System.Windows.Forms.Label ltp02;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label lrt;
        private System.Windows.Forms.DateTimePicker dtRegDate;
        private System.Windows.Forms.Label label2;
    }
}