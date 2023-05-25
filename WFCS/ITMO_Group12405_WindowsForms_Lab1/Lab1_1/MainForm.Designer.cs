namespace Lab1_1
{
    partial class MainForm
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
            this.BorderStyle = new System.Windows.Forms.Button();
            this.Resize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorderStyle
            // 
            this.BorderStyle.Location = new System.Drawing.Point(306, 24);
            this.BorderStyle.Name = "BorderStyle";
            this.BorderStyle.Size = new System.Drawing.Size(257, 128);
            this.BorderStyle.TabIndex = 0;
            this.BorderStyle.Text = "Border Style";
            this.BorderStyle.UseVisualStyleBackColor = true;
            this.BorderStyle.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(31, 156);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(257, 128);
            this.Resize.TabIndex = 1;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 138);
            this.button1.TabIndex = 2;
            this.button1.Text = "Opacity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.BorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "MainForm";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BorderStyle;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button button1;
    }
}

