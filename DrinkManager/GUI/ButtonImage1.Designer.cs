namespace DrinkManager.GUI
{
    partial class ButtonImage1
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
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 55);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(80, 25);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.Click += new System.EventHandler(this.ptbIcon_Click);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseDown);
            this.lblText.MouseEnter += new System.EventHandler(this.ButtonImage1_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.ButtonImage1_MouseLeave);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseUp);
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbIcon.Location = new System.Drawing.Point(15, 5);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(50, 50);
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.Click += new System.EventHandler(this.ptbIcon_Click);
            this.ptbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseDown);
            this.ptbIcon.MouseEnter += new System.EventHandler(this.ButtonImage1_MouseEnter);
            this.ptbIcon.MouseLeave += new System.EventHandler(this.ButtonImage1_MouseLeave);
            this.ptbIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseUp);
            // 
            // ButtonImage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.ptbIcon);
            this.Name = "ButtonImage1";
            this.Size = new System.Drawing.Size(80, 80);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ButtonImage1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ButtonImage1_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonImage1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Label lblText;
    }
}
