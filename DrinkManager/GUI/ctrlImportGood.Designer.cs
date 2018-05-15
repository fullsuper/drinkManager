namespace DrinkManager.GUI
{
    partial class ctrlImportGood
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
            this.rtbRating = new System.Windows.Forms.RichTextBox();
            this.lstProduct = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbSelectedItem = new System.Windows.Forms.GroupBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.cbbCensor = new System.Windows.Forms.ComboBox();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbOK = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpDateTrading = new System.Windows.Forms.DateTimePicker();
            this.grbSelectedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbRating
            // 
            this.rtbRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRating.Location = new System.Drawing.Point(428, 19);
            this.rtbRating.Name = "rtbRating";
            this.rtbRating.Size = new System.Drawing.Size(322, 70);
            this.rtbRating.TabIndex = 32;
            this.rtbRating.Text = "";
            // 
            // lstProduct
            // 
            this.lstProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clAmount,
            this.clValue});
            this.lstProduct.FullRowSelect = true;
            this.lstProduct.Location = new System.Drawing.Point(425, 95);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(325, 234);
            this.lstProduct.TabIndex = 30;
            this.lstProduct.TileSize = new System.Drawing.Size(10, 10);
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            this.lstProduct.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 34;
            // 
            // clName
            // 
            this.clName.Text = "Sản Phẩm";
            this.clName.Width = 182;
            // 
            // clAmount
            // 
            this.clAmount.Text = "SL";
            this.clAmount.Width = 49;
            // 
            // clValue
            // 
            this.clValue.Text = "Giá";
            this.clValue.Width = 53;
            // 
            // grbSelectedItem
            // 
            this.grbSelectedItem.Controls.Add(this.nudPrice);
            this.grbSelectedItem.Controls.Add(this.nudAmount);
            this.grbSelectedItem.Controls.Add(this.label2);
            this.grbSelectedItem.Controls.Add(this.label1);
            this.grbSelectedItem.Controls.Add(this.txtID);
            this.grbSelectedItem.Controls.Add(this.txtName);
            this.grbSelectedItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelectedItem.Location = new System.Drawing.Point(85, 374);
            this.grbSelectedItem.Name = "grbSelectedItem";
            this.grbSelectedItem.Size = new System.Drawing.Size(537, 67);
            this.grbSelectedItem.TabIndex = 28;
            this.grbSelectedItem.TabStop = false;
            this.grbSelectedItem.Text = "Sản phẩm đang chọn";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(307, 28);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(99, 33);
            this.nudAmount.TabIndex = 7;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(20, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 33);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(61, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 33);
            this.txtName.TabIndex = 4;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.itemName,
            this.amount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Location = new System.Drawing.Point(26, 95);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.Size = new System.Drawing.Size(337, 234);
            this.dgvItem.TabIndex = 25;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // cbbCensor
            // 
            this.cbbCensor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCensor.FormattingEnabled = true;
            this.cbbCensor.Location = new System.Drawing.Point(102, 62);
            this.cbbCensor.Name = "cbbCensor";
            this.cbbCensor.Size = new System.Drawing.Size(320, 27);
            this.cbbCensor.TabIndex = 23;
            this.cbbCensor.Text = "- Người kiểm duyệt -";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(102, 19);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(320, 27);
            this.cbbSupplier.TabIndex = 24;
            this.cbbSupplier.Text = "- Chọn Nhà Sản Xuất -";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "iid";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.DataPropertyName = "nameitem";
            this.itemName.HeaderText = "Tên sản phẩm";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "SL";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 40;
            // 
            // ptbOK
            // 
            this.ptbOK.BackgroundImage = global::DrinkManager.Properties.Resources.truck_1_512;
            this.ptbOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbOK.Location = new System.Drawing.Point(632, 374);
            this.ptbOK.Name = "ptbOK";
            this.ptbOK.Padding = new System.Windows.Forms.Padding(5);
            this.ptbOK.Size = new System.Drawing.Size(96, 61);
            this.ptbOK.TabIndex = 31;
            this.ptbOK.TabStop = false;
            this.ptbOK.Click += new System.EventHandler(this.ptbOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DrinkManager.Properties.Resources.food;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::DrinkManager.Properties.Resources.left;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Location = new System.Drawing.Point(369, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 50);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.BackgroundImage = global::DrinkManager.Properties.Resources.right;
            this.btnChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoice.Location = new System.Drawing.Point(369, 151);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(50, 50);
            this.btnChoice.TabIndex = 27;
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(412, 28);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(119, 33);
            this.nudPrice.TabIndex = 7;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // dtpDateTrading
            // 
            this.dtpDateTrading.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTrading.Location = new System.Drawing.Point(632, 348);
            this.dtpDateTrading.Name = "dtpDateTrading";
            this.dtpDateTrading.Size = new System.Drawing.Size(96, 20);
            this.dtpDateTrading.TabIndex = 33;
            // 
            // ctrlImportGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateTrading);
            this.Controls.Add(this.rtbRating);
            this.Controls.Add(this.ptbOK);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbSelectedItem);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.cbbCensor);
            this.Controls.Add(this.cbbSupplier);
            this.Name = "ctrlImportGood";
            this.Size = new System.Drawing.Size(784, 461);
            this.grbSelectedItem.ResumeLayout(false);
            this.grbSelectedItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRating;
        private System.Windows.Forms.PictureBox ptbOK;
        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.ColumnHeader clValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbSelectedItem;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox cbbCensor;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DateTimePicker dtpDateTrading;
    }
}
