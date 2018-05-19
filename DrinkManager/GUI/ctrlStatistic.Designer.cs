namespace DrinkManager
{
    partial class ctrlStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlStatisticCustomer = new System.Windows.Forms.Panel();
            this.dgvFriendlyCustomer = new System.Windows.Forms.DataGridView();
            this.clnCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnFilt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlProductImport = new System.Windows.Forms.Panel();
            this.dgvImportGood = new System.Windows.Forms.DataGridView();
            this.nudYearImport = new System.Windows.Forms.NumericUpDown();
            this.nudMonthImport = new System.Windows.Forms.NumericUpDown();
            this.btnRefiltImport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.pnlStatisticCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendlyCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.pnlProductImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthImport)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticToolStripMenuItem,
            this.statisticToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlStatisticCustomer
            // 
            this.pnlStatisticCustomer.Controls.Add(this.dgvFriendlyCustomer);
            this.pnlStatisticCustomer.Controls.Add(this.nudYear);
            this.pnlStatisticCustomer.Controls.Add(this.nudMonth);
            this.pnlStatisticCustomer.Controls.Add(this.label3);
            this.pnlStatisticCustomer.Controls.Add(this.label4);
            this.pnlStatisticCustomer.Controls.Add(this.lblSum);
            this.pnlStatisticCustomer.Controls.Add(this.btnFilt);
            this.pnlStatisticCustomer.Controls.Add(this.label1);
            this.pnlStatisticCustomer.Controls.Add(this.label2);
            this.pnlStatisticCustomer.Location = new System.Drawing.Point(3, 27);
            this.pnlStatisticCustomer.Name = "pnlStatisticCustomer";
            this.pnlStatisticCustomer.Size = new System.Drawing.Size(784, 431);
            this.pnlStatisticCustomer.TabIndex = 10;
            this.pnlStatisticCustomer.Visible = false;
            // 
            // dgvFriendlyCustomer
            // 
            this.dgvFriendlyCustomer.AllowUserToAddRows = false;
            this.dgvFriendlyCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvFriendlyCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFriendlyCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvFriendlyCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFriendlyCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFriendlyCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFriendlyCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFriendlyCustomer.ColumnHeadersHeight = 30;
            this.dgvFriendlyCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFriendlyCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCID,
            this.clnName,
            this.clnAddress,
            this.clnPhone});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFriendlyCustomer.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFriendlyCustomer.EnableHeadersVisualStyles = false;
            this.dgvFriendlyCustomer.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFriendlyCustomer.Location = new System.Drawing.Point(81, 86);
            this.dgvFriendlyCustomer.Name = "dgvFriendlyCustomer";
            this.dgvFriendlyCustomer.ReadOnly = true;
            this.dgvFriendlyCustomer.Size = new System.Drawing.Size(600, 273);
            this.dgvFriendlyCustomer.TabIndex = 17;
            // 
            // clnCID
            // 
            this.clnCID.DataPropertyName = "cid";
            this.clnCID.HeaderText = "Mã Khách Hàng";
            this.clnCID.Name = "clnCID";
            this.clnCID.ReadOnly = true;
            this.clnCID.Width = 120;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "name";
            this.clnName.HeaderText = "Tên Khách Hàng";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            // 
            // clnAddress
            // 
            this.clnAddress.DataPropertyName = "time";
            this.clnAddress.HeaderText = "Số Lần Ghé Quán";
            this.clnAddress.Name = "clnAddress";
            this.clnAddress.ReadOnly = true;
            this.clnAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAddress.Width = 150;
            // 
            // clnPhone
            // 
            this.clnPhone.DataPropertyName = "sumprice";
            this.clnPhone.HeaderText = "Tổng Tiền";
            this.clnPhone.Name = "clnPhone";
            this.clnPhone.ReadOnly = true;
            this.clnPhone.Width = 80;
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(318, 36);
            this.nudYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(79, 33);
            this.nudYear.TabIndex = 16;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonth.Location = new System.Drawing.Point(166, 36);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(74, 33);
            this.nudMonth.TabIndex = 15;
            this.nudMonth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng thu nhập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSum
            // 
            this.lblSum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(501, 375);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(115, 25);
            this.lblSum.TabIndex = 14;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFilt
            // 
            this.btnFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilt.Location = new System.Drawing.Point(596, 29);
            this.btnFilt.Name = "btnFilt";
            this.btnFilt.Size = new System.Drawing.Size(85, 40);
            this.btnFilt.TabIndex = 11;
            this.btnFilt.Text = "Refilt";
            this.btnFilt.UseVisualStyleBackColor = true;
            this.btnFilt.Click += new System.EventHandler(this.btnFilt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Month";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.statisticToolStripMenuItem.Text = "StatisticCustomer";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem1
            // 
            this.statisticToolStripMenuItem1.Name = "statisticToolStripMenuItem1";
            this.statisticToolStripMenuItem1.Size = new System.Drawing.Size(138, 20);
            this.statisticToolStripMenuItem1.Text = "StatisticProductImport";
            this.statisticToolStripMenuItem1.Click += new System.EventHandler(this.statisticToolStripMenuItem1_Click);
            // 
            // pnlProductImport
            // 
            this.pnlProductImport.Controls.Add(this.nudYearImport);
            this.pnlProductImport.Controls.Add(this.nudMonthImport);
            this.pnlProductImport.Controls.Add(this.btnRefiltImport);
            this.pnlProductImport.Controls.Add(this.label5);
            this.pnlProductImport.Controls.Add(this.label6);
            this.pnlProductImport.Controls.Add(this.dgvImportGood);
            this.pnlProductImport.Location = new System.Drawing.Point(3, 27);
            this.pnlProductImport.Name = "pnlProductImport";
            this.pnlProductImport.Size = new System.Drawing.Size(784, 431);
            this.pnlProductImport.TabIndex = 11;
            // 
            // dgvImportGood
            // 
            this.dgvImportGood.AllowUserToAddRows = false;
            this.dgvImportGood.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvImportGood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvImportGood.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportGood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImportGood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvImportGood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportGood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvImportGood.ColumnHeadersHeight = 30;
            this.dgvImportGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImportGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnType,
            this.dataGridViewTextBoxColumn1,
            this.clnHireDate,
            this.dataGridViewTextBoxColumn2,
            this.clnSalary});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportGood.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvImportGood.EnableHeadersVisualStyles = false;
            this.dgvImportGood.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvImportGood.Location = new System.Drawing.Point(13, 67);
            this.dgvImportGood.Name = "dgvImportGood";
            this.dgvImportGood.ReadOnly = true;
            this.dgvImportGood.Size = new System.Drawing.Size(753, 335);
            this.dgvImportGood.TabIndex = 5;
            // 
            // nudYearImport
            // 
            this.nudYearImport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYearImport.Location = new System.Drawing.Point(274, 28);
            this.nudYearImport.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudYearImport.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudYearImport.Name = "nudYearImport";
            this.nudYearImport.Size = new System.Drawing.Size(79, 33);
            this.nudYearImport.TabIndex = 21;
            this.nudYearImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYearImport.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // nudMonthImport
            // 
            this.nudMonthImport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonthImport.Location = new System.Drawing.Point(122, 28);
            this.nudMonthImport.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonthImport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthImport.Name = "nudMonthImport";
            this.nudMonthImport.Size = new System.Drawing.Size(74, 33);
            this.nudMonthImport.TabIndex = 20;
            this.nudMonthImport.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnRefiltImport
            // 
            this.btnRefiltImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefiltImport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefiltImport.Location = new System.Drawing.Point(648, 22);
            this.btnRefiltImport.Name = "btnRefiltImport";
            this.btnRefiltImport.Size = new System.Drawing.Size(85, 40);
            this.btnRefiltImport.TabIndex = 19;
            this.btnRefiltImport.Text = "Refilt";
            this.btnRefiltImport.UseVisualStyleBackColor = true;
            this.btnRefiltImport.Click += new System.EventHandler(this.btnRefiltImport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Month";
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "dsid";
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnID.Width = 20;
            // 
            // clnType
            // 
            this.clnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnType.DataPropertyName = "nameitem";
            this.clnType.HeaderText = "Sản Phẩm";
            this.clnType.Name = "clnType";
            this.clnType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn1.HeaderText = "SL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // clnHireDate
            // 
            this.clnHireDate.DataPropertyName = "censor";
            this.clnHireDate.HeaderText = "Kiểm Soát";
            this.clnHireDate.Name = "clnHireDate";
            this.clnHireDate.ReadOnly = true;
            this.clnHireDate.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tradingdate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // clnSalary
            // 
            this.clnSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnSalary.DataPropertyName = "rate";
            this.clnSalary.HeaderText = "Đánh Giá";
            this.clnSalary.Name = "clnSalary";
            this.clnSalary.ReadOnly = true;
            // 
            // ctrlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlProductImport);
            this.Controls.Add(this.pnlStatisticCustomer);
            this.Name = "ctrlStatistic";
            this.Size = new System.Drawing.Size(784, 461);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStatisticCustomer.ResumeLayout(false);
            this.pnlStatisticCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendlyCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.pnlProductImport.ResumeLayout(false);
            this.pnlProductImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlStatisticCustomer;
        private System.Windows.Forms.DataGridView dgvFriendlyCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnFilt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProductImport;
        private System.Windows.Forms.DataGridView dgvImportGood;
        private System.Windows.Forms.NumericUpDown nudYearImport;
        private System.Windows.Forms.NumericUpDown nudMonthImport;
        private System.Windows.Forms.Button btnRefiltImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSalary;
    }
}
