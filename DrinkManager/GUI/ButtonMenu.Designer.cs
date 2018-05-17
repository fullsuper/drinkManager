namespace DrinkManager.GUI
{
    partial class ButtonMenu
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
            this.lblText = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(73, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 30);
            this.lblText.TabIndex = 1;
            this.lblText.Click += new System.EventHandler(this.ptbImage_Click);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.lblText.MouseEnter += new System.EventHandler(this.ButtonMenu_Enter);
            this.lblText.MouseLeave += new System.EventHandler(this.ButtonMenu_Leave);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // ptbImage
            // 
            this.ptbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage.Location = new System.Drawing.Point(17, 3);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(50, 50);
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            this.ptbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.ptbImage.MouseEnter += new System.EventHandler(this.ButtonMenu_Enter);
            this.ptbImage.MouseLeave += new System.EventHandler(this.ButtonMenu_Leave);
            this.ptbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            // 
            // ButtonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.ptbImage);
            this.Name = "ButtonMenu";
            this.Size = new System.Drawing.Size(174, 57);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ButtonMenu_Enter);
            this.MouseLeave += new System.EventHandler(this.ButtonMenu_Leave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMenu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label lblText;
    }
}
