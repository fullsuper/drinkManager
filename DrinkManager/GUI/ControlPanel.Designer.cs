namespace DrinkManager.GUI
{
    partial class ControlPanel
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnImportGoods = new DrinkManager.GUI.ButtonMenu();
            this.btnPurchase = new DrinkManager.GUI.ButtonMenu();
            this.btnConfigure = new DrinkManager.GUI.ButtonMenu();
            this.btnBillStatistic = new DrinkManager.GUI.ButtonMenu();
            this.btnStaffManage = new DrinkManager.GUI.ButtonMenu();
            this.btnStorage = new DrinkManager.GUI.ButtonMenu();
            this.btnStatistic = new DrinkManager.GUI.ButtonMenu();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            this.ptbInfo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbQuit = new System.Windows.Forms.PictureBox();
            this.pnlMainScreen = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.pnlMenu.Controls.Add(this.btnImportGoods);
            this.pnlMenu.Controls.Add(this.btnPurchase);
            this.pnlMenu.Controls.Add(this.btnConfigure);
            this.pnlMenu.Controls.Add(this.btnBillStatistic);
            this.pnlMenu.Controls.Add(this.btnStaffManage);
            this.pnlMenu.Controls.Add(this.btnStorage);
            this.pnlMenu.Controls.Add(this.btnStatistic);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 561);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnImportGoods
            // 
            this.btnImportGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportGoods.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImportGoods.IconImage = global::DrinkManager.Properties.Resources.truck_1_512;
            this.btnImportGoods.Location = new System.Drawing.Point(0, 448);
            this.btnImportGoods.Name = "btnImportGoods";
            this.btnImportGoods.Size = new System.Drawing.Size(200, 58);
            this.btnImportGoods.TabIndex = 7;
            this.btnImportGoods.TextButton = "Import";
            this.btnImportGoods.Click += new System.EventHandler(this.btnImportGoods_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPurchase.IconImage = global::DrinkManager.Properties.Resources.shopping;
            this.btnPurchase.Location = new System.Drawing.Point(0, 390);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(200, 58);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.TextButton = "Purchase";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigure.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfigure.IconImage = global::DrinkManager.Properties.Resources.repair;
            this.btnConfigure.Location = new System.Drawing.Point(0, 332);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(200, 58);
            this.btnConfigure.TabIndex = 5;
            this.btnConfigure.TextButton = "Config";
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnBillStatistic
            // 
            this.btnBillStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBillStatistic.IconImage = global::DrinkManager.Properties.Resources.bill;
            this.btnBillStatistic.Location = new System.Drawing.Point(0, 274);
            this.btnBillStatistic.Name = "btnBillStatistic";
            this.btnBillStatistic.Size = new System.Drawing.Size(200, 58);
            this.btnBillStatistic.TabIndex = 4;
            this.btnBillStatistic.TextButton = "Bill";
            this.btnBillStatistic.Click += new System.EventHandler(this.btnBillStatistic_Click);
            // 
            // btnStaffManage
            // 
            this.btnStaffManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaffManage.IconImage = global::DrinkManager.Properties.Resources.employee;
            this.btnStaffManage.Location = new System.Drawing.Point(0, 216);
            this.btnStaffManage.Name = "btnStaffManage";
            this.btnStaffManage.Size = new System.Drawing.Size(200, 58);
            this.btnStaffManage.TabIndex = 3;
            this.btnStaffManage.TextButton = "Staff";
            this.btnStaffManage.Click += new System.EventHandler(this.btnStaffManage_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStorage.IconImage = global::DrinkManager.Properties.Resources.product;
            this.btnStorage.Location = new System.Drawing.Point(0, 158);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(200, 58);
            this.btnStorage.TabIndex = 2;
            this.btnStorage.TextButton = "Storage";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconImage = global::DrinkManager.Properties.Resources.addicon;
            this.btnStatistic.Location = new System.Drawing.Point(0, 100);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(200, 58);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.TextButton = "Statistic";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(49)))));
            this.pnlLogo.Controls.Add(this.lbl);
            this.pnlLogo.Controls.Add(this.ptbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(68, 24);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 50);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Drink\r\nManager";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = global::DrinkManager.Properties.Resources.backpack;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLogo.Location = new System.Drawing.Point(12, 24);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(50, 50);
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlHeader.Controls.Add(this.ptbHide);
            this.pnlHeader.Controls.Add(this.ptbInfo);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.ptbQuit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // ptbHide
            // 
            this.ptbHide.BackgroundImage = global::DrinkManager.Properties.Resources.hide;
            this.ptbHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbHide.Location = new System.Drawing.Point(670, 12);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(30, 30);
            this.ptbHide.TabIndex = 2;
            this.ptbHide.TabStop = false;
            // 
            // ptbInfo
            // 
            this.ptbInfo.BackgroundImage = global::DrinkManager.Properties.Resources.help;
            this.ptbInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbInfo.Location = new System.Drawing.Point(706, 12);
            this.ptbInfo.Name = "ptbInfo";
            this.ptbInfo.Size = new System.Drawing.Size(30, 30);
            this.ptbInfo.TabIndex = 2;
            this.ptbInfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào các bạn";
            // 
            // ptbQuit
            // 
            this.ptbQuit.BackgroundImage = global::DrinkManager.Properties.Resources.close_button;
            this.ptbQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbQuit.Location = new System.Drawing.Point(742, 12);
            this.ptbQuit.Name = "ptbQuit";
            this.ptbQuit.Size = new System.Drawing.Size(30, 30);
            this.ptbQuit.TabIndex = 0;
            this.ptbQuit.TabStop = false;
            this.ptbQuit.Click += new System.EventHandler(this.ptbQuit_Click);
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMainScreen.Location = new System.Drawing.Point(200, 100);
            this.pnlMainScreen.Name = "pnlMainScreen";
            this.pnlMainScreen.Size = new System.Drawing.Size(784, 461);
            this.pnlMainScreen.TabIndex = 2;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlMainScreen);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlPanel";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox ptbQuit;
        private System.Windows.Forms.PictureBox ptbHide;
        private System.Windows.Forms.PictureBox ptbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox ptbLogo;
        private ButtonMenu btnStatistic;
        private ButtonMenu btnStorage;
        private ButtonMenu btnStaffManage;
        private System.Windows.Forms.Panel pnlMainScreen;
        private ButtonMenu btnBillStatistic;
        private ButtonMenu btnConfigure;
        private ButtonMenu btnPurchase;
        private ButtonMenu btnImportGoods;
    }
}