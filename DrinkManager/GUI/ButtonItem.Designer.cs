namespace DrinkManager.GUI
{
    partial class ButtonItem
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
            this.lblContent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(3, 90);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(134, 50);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "label1";
            this.lblContent.Click += new System.EventHandler(this.pictureBox1_Click);
            this.lblContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseDown);
            this.lblContent.MouseEnter += new System.EventHandler(this.ButtonItem_MouseEnter);
            this.lblContent.MouseLeave += new System.EventHandler(this.ButtonItem_MouseLeave);
            this.lblContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DrinkManager.Properties.Resources.food;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ButtonItem_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ButtonItem_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseUp);
            // 
            // ButtonItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContent);
            this.Name = "ButtonItem";
            this.Size = new System.Drawing.Size(140, 140);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ButtonItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ButtonItem_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
