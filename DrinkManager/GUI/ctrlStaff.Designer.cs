namespace DrinkManager.GUI
{
    partial class ctrlStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.ptbCancel = new System.Windows.Forms.PictureBox();
            this.ptbSave = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployeeTable = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new DrinkManager.GUI.ButtonImage1();
            this.btnFilt = new DrinkManager.GUI.ButtonImage1();
            this.btnDelete = new DrinkManager.GUI.ButtonImage1();
            this.btnAdd = new DrinkManager.GUI.ButtonImage1();
            this.btnCustom = new DrinkManager.GUI.ButtonImage1();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpHireDate);
            this.panel1.Controls.Add(this.cbbService);
            this.panel1.Controls.Add(this.ptbCancel);
            this.panel1.Controls.Add(this.ptbSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(526, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 420);
            this.panel1.TabIndex = 5;
            // 
            // cbbService
            // 
            this.cbbService.Enabled = false;
            this.cbbService.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(88, 95);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(149, 35);
            this.cbbService.TabIndex = 4;
            // 
            // ptbCancel
            // 
            this.ptbCancel.BackgroundImage = global::DrinkManager.Properties.Resources.close_button;
            this.ptbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCancel.Enabled = false;
            this.ptbCancel.Location = new System.Drawing.Point(135, 365);
            this.ptbCancel.Name = "ptbCancel";
            this.ptbCancel.Size = new System.Drawing.Size(100, 50);
            this.ptbCancel.TabIndex = 6;
            this.ptbCancel.TabStop = false;
            this.ptbCancel.Click += new System.EventHandler(this.ptbCancel_Click);
            // 
            // ptbSave
            // 
            this.ptbSave.BackgroundImage = global::DrinkManager.Properties.Resources.save;
            this.ptbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSave.Enabled = false;
            this.ptbSave.Location = new System.Drawing.Point(13, 365);
            this.ptbSave.Name = "ptbSave";
            this.ptbSave.Size = new System.Drawing.Size(100, 50);
            this.ptbSave.TabIndex = 6;
            this.ptbSave.TabStop = false;
            this.ptbSave.Click += new System.EventHandler(this.ptbSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "HireDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(88, 297);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(149, 32);
            this.txtSalary.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(88, 247);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(149, 32);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(88, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 32);
            this.txtName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(88, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 32);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Information";
            // 
            // dgvEmployeeTable
            // 
            this.dgvEmployeeTable.AllowUserToAddRows = false;
            this.dgvEmployeeTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvEmployeeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeeTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployeeTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployeeTable.ColumnHeadersHeight = 30;
            this.dgvEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnType,
            this.clnName,
            this.clnHireDate,
            this.clnPhone,
            this.clnSalary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployeeTable.EnableHeadersVisualStyles = false;
            this.dgvEmployeeTable.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmployeeTable.Location = new System.Drawing.Point(13, 105);
            this.dgvEmployeeTable.Name = "dgvEmployeeTable";
            this.dgvEmployeeTable.ReadOnly = true;
            this.dgvEmployeeTable.Size = new System.Drawing.Size(500, 335);
            this.dgvEmployeeTable.TabIndex = 4;
            this.dgvEmployeeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeTable_CellClick);
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "eid";
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnID.Width = 30;
            // 
            // clnType
            // 
            this.clnType.DataPropertyName = "typeservice";
            this.clnType.HeaderText = "Phục vụ";
            this.clnType.Name = "clnType";
            this.clnType.ReadOnly = true;
            this.clnType.Width = 80;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "name";
            this.clnName.HeaderText = "Họ Tên";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnHireDate
            // 
            this.clnHireDate.DataPropertyName = "hiredate";
            this.clnHireDate.HeaderText = "Ngày vào";
            this.clnHireDate.Name = "clnHireDate";
            this.clnHireDate.ReadOnly = true;
            this.clnHireDate.Width = 80;
            // 
            // clnPhone
            // 
            this.clnPhone.DataPropertyName = "phone";
            this.clnPhone.HeaderText = "SĐT";
            this.clnPhone.Name = "clnPhone";
            this.clnPhone.ReadOnly = true;
            // 
            // clnSalary
            // 
            this.clnSalary.DataPropertyName = "salary";
            this.clnSalary.HeaderText = "Lương";
            this.clnSalary.Name = "clnSalary";
            this.clnSalary.ReadOnly = true;
            this.clnSalary.Width = 60;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLoad.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.ImageIcon = global::DrinkManager.Properties.Resources.reload;
            this.btnLoad.Location = new System.Drawing.Point(433, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 80);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.TextButton = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFilt
            // 
            this.btnFilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFilt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnFilt.ImageIcon = global::DrinkManager.Properties.Resources.find1;
            this.btnFilt.Location = new System.Drawing.Point(328, 20);
            this.btnFilt.Name = "btnFilt";
            this.btnFilt.Size = new System.Drawing.Size(80, 80);
            this.btnFilt.TabIndex = 7;
            this.btnFilt.TextButton = "Filter";
            this.btnFilt.Click += new System.EventHandler(this.btnFilt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.ImageIcon = global::DrinkManager.Properties.Resources.itemdelete;
            this.btnDelete.Location = new System.Drawing.Point(223, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 80);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.TextButton = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.ImageIcon = global::DrinkManager.Properties.Resources.addicon1;
            this.btnAdd.Location = new System.Drawing.Point(118, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TextButton = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCustom.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCustom.ImageIcon = global::DrinkManager.Properties.Resources.repair;
            this.btnCustom.Location = new System.Drawing.Point(13, 20);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(80, 80);
            this.btnCustom.TabIndex = 10;
            this.btnCustom.TextButton = "Custom";
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CalendarFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Enabled = false;
            this.dtpHireDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(88, 201);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(149, 32);
            this.dtpHireDate.TabIndex = 6;
            this.dtpHireDate.Value = new System.DateTime(2018, 5, 9, 18, 48, 31, 0);
            // 
            // ctrlStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnFilt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployeeTable);
            this.Name = "ctrlStaff";
            this.Size = new System.Drawing.Size(784, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonImage1 btnLoad;
        private ButtonImage1 btnFilt;
        private ButtonImage1 btnDelete;
        private ButtonImage1 btnAdd;
        private ButtonImage1 btnCustom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbCancel;
        private System.Windows.Forms.PictureBox ptbSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployeeTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSalary;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
    }
}
