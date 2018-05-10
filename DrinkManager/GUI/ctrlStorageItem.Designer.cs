using System.Drawing;

namespace DrinkManager.GUI
{
    partial class ctrlStorageItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItemTable = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbCancel = new System.Windows.Forms.PictureBox();
            this.ptbSave = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new DrinkManager.GUI.ButtonImage1();
            this.btnFilt = new DrinkManager.GUI.ButtonImage1();
            this.btnDelete = new DrinkManager.GUI.ButtonImage1();
            this.btnAdd = new DrinkManager.GUI.ButtonImage1();
            this.btnCustom = new DrinkManager.GUI.ButtonImage1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemTable
            // 
            this.dgvItemTable.AllowUserToAddRows = false;
            this.dgvItemTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvItemTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemTable.ColumnHeadersHeight = 30;
            this.dgvItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnType,
            this.clnName,
            this.clnPrice,
            this.clnAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemTable.EnableHeadersVisualStyles = false;
            this.dgvItemTable.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItemTable.Location = new System.Drawing.Point(15, 110);
            this.dgvItemTable.Name = "dgvItemTable";
            this.dgvItemTable.ReadOnly = true;
            this.dgvItemTable.Size = new System.Drawing.Size(500, 335);
            this.dgvItemTable.TabIndex = 0;
            this.dgvItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemTable_CellClick);
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "iid";
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnID.Width = 30;
            // 
            // clnType
            // 
            this.clnType.DataPropertyName = "typeitem";
            this.clnType.HeaderText = "Loại";
            this.clnType.Name = "clnType";
            this.clnType.ReadOnly = true;
            this.clnType.Width = 80;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "nameitem";
            this.clnName.HeaderText = "Sản phẩm";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnPrice
            // 
            this.clnPrice.DataPropertyName = "price";
            this.clnPrice.HeaderText = "Giá";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnAmount
            // 
            this.clnAmount.DataPropertyName = "amount";
            this.clnAmount.HeaderText = "Lượng";
            this.clnAmount.Name = "clnAmount";
            this.clnAmount.ReadOnly = true;
            this.clnAmount.Width = 60;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ptbCancel);
            this.panel1.Controls.Add(this.ptbSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(528, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 410);
            this.panel1.TabIndex = 2;
            // 
            // ptbCancel
            // 
            this.ptbCancel.BackgroundImage = global::DrinkManager.Properties.Resources.close_button;
            this.ptbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCancel.Location = new System.Drawing.Point(135, 353);
            this.ptbCancel.Name = "ptbCancel";
            this.ptbCancel.Size = new System.Drawing.Size(100, 50);
            this.ptbCancel.TabIndex = 6;
            this.ptbCancel.TabStop = false;
            this.ptbCancel.Click += new System.EventHandler(this.ptbCancel_Click);
            this.ptbCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbCancel_MouseDown);
            this.ptbCancel.MouseEnter += new System.EventHandler(this.ptbCancel_MouseEnter);
            this.ptbCancel.MouseLeave += new System.EventHandler(this.ptbCancel_MouseLeave);
            this.ptbCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbCancel_MouseUp);
            // 
            // ptbSave
            // 
            this.ptbSave.BackgroundImage = global::DrinkManager.Properties.Resources.save;
            this.ptbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSave.Location = new System.Drawing.Point(13, 353);
            this.ptbSave.Name = "ptbSave";
            this.ptbSave.Size = new System.Drawing.Size(100, 50);
            this.ptbSave.TabIndex = 6;
            this.ptbSave.TabStop = false;
            this.ptbSave.Click += new System.EventHandler(this.ptbSave_Click);
            this.ptbSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbCancel_MouseDown);
            this.ptbSave.MouseEnter += new System.EventHandler(this.ptbCancel_MouseEnter);
            this.ptbSave.MouseLeave += new System.EventHandler(this.ptbCancel_MouseLeave);
            this.ptbSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbCancel_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Item";
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(77, 315);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(158, 32);
            this.txtValue.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(77, 255);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 32);
            this.txtAmount.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(77, 194);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(158, 32);
            this.txtType.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(77, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 32);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(77, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 32);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Information";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLoad.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.ImageIcon = global::DrinkManager.Properties.Resources.reload;
            this.btnLoad.Location = new System.Drawing.Point(435, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 80);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.TextButton = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFilt
            // 
            this.btnFilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFilt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnFilt.ImageIcon = global::DrinkManager.Properties.Resources.find1;
            this.btnFilt.Location = new System.Drawing.Point(330, 25);
            this.btnFilt.Name = "btnFilt";
            this.btnFilt.Size = new System.Drawing.Size(80, 80);
            this.btnFilt.TabIndex = 3;
            this.btnFilt.TextButton = "Filter";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.ImageIcon = global::DrinkManager.Properties.Resources.itemdelete;
            this.btnDelete.Location = new System.Drawing.Point(225, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 80);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextButton = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.ImageIcon = global::DrinkManager.Properties.Resources.addicon1;
            this.btnAdd.Location = new System.Drawing.Point(120, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextButton = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCustom.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCustom.ImageIcon = global::DrinkManager.Properties.Resources.repair;
            this.btnCustom.Location = new System.Drawing.Point(15, 25);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(80, 80);
            this.btnCustom.TabIndex = 3;
            this.btnCustom.TextButton = "Custom";
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // ctrlStorageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnFilt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItemTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlStorageItem";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private ButtonImage1 btnCustom;
        private ButtonImage1 btnAdd;
        private ButtonImage1 btnDelete;
        private ButtonImage1 btnFilt;
        private ButtonImage1 btnLoad;
        private System.Windows.Forms.PictureBox ptbCancel;
        private System.Windows.Forms.PictureBox ptbSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAmount;
    }
}
