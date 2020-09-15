namespace BLSystem
{
    partial class FormProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcess));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.dgvR = new System.Windows.Forms.DataGridView();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtM = new System.Windows.Forms.DateTimePicker();
            this.lP = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lP);
            this.panelTop.Controls.Add(this.dtM);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnFinal);
            this.panelTop.Controls.Add(this.btnDraft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 56);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BLSystem.Properties.Resources.application_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(859, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Image = global::BLSystem.Properties.Resources.gnomeicu;
            this.btnFinal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinal.Location = new System.Drawing.Point(762, 5);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(75, 40);
            this.btnFinal.TabIndex = 1;
            this.btnFinal.Text = "Final";
            this.btnFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinal.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            this.btnDraft.Image = global::BLSystem.Properties.Resources.gnome_mastermind;
            this.btnDraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraft.Location = new System.Drawing.Point(665, 5);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(75, 40);
            this.btnDraft.TabIndex = 0;
            this.btnDraft.Text = "Draft";
            this.btnDraft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDraft.UseVisualStyleBackColor = true;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // dgvR
            // 
            this.dgvR.AllowUserToAddRows = false;
            this.dgvR.AllowUserToDeleteRows = false;
            this.dgvR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouteName,
            this.DeductionRate});
            this.dgvR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvR.Location = new System.Drawing.Point(0, 56);
            this.dgvR.Name = "dgvR";
            this.dgvR.ReadOnly = true;
            this.dgvR.RowTemplate.Height = 24;
            this.dgvR.Size = new System.Drawing.Size(1000, 506);
            this.dgvR.TabIndex = 1;
            // 
            // RouteName
            // 
            this.RouteName.DataPropertyName = "rName";
            this.RouteName.HeaderText = "RouteName";
            this.RouteName.Name = "RouteName";
            this.RouteName.ReadOnly = true;
            this.RouteName.Width = 150;
            // 
            // DeductionRate
            // 
            this.DeductionRate.DataPropertyName = "dDrate";
            this.DeductionRate.HeaderText = "Deduction Rate";
            this.DeductionRate.Name = "DeductionRate";
            this.DeductionRate.ReadOnly = true;
            // 
            // dtM
            // 
            this.dtM.CustomFormat = "MMM-yyyy";
            this.dtM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtM.Location = new System.Drawing.Point(151, 13);
            this.dtM.Name = "dtM";
            this.dtM.Size = new System.Drawing.Size(137, 27);
            this.dtM.TabIndex = 3;
            // 
            // lP
            // 
            this.lP.AutoSize = true;
            this.lP.Location = new System.Drawing.Point(78, 15);
            this.lP.Name = "lP";
            this.lP.Size = new System.Drawing.Size(67, 20);
            this.lP.TabIndex = 4;
            this.lP.Text = "Period :";
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgvR);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProcess";
            this.Text = "Process";
            this.Load += new System.EventHandler(this.FormProcess_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.DataGridView dgvR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductionRate;
        private System.Windows.Forms.Label lP;
        private System.Windows.Forms.DateTimePicker dtM;
    }
}