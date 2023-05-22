
namespace WindowsFormsApp1
{
    partial class HomeCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeCom));
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.count = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2GradientPanel2.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.Controls.Add(this.count);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox2);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(62, 75);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(471, 139);
            this.guna2GradientPanel2.TabIndex = 41;
            this.guna2GradientPanel2.UseTransparentBackground = true;
            this.guna2GradientPanel2.Click += new System.EventHandler(this.guna2GradientPanel2_Click);
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.Color.Transparent;
            this.count.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Bold);
            this.count.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.count.Location = new System.Drawing.Point(397, 53);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(39, 43);
            this.count.TabIndex = 44;
            this.count.Text = "12";
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Unispace", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(174, 53);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 42);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Students";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(14, 19);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(104, 104);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 17;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(397, 37);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(39, 43);
            this.guna2HtmlLabel3.TabIndex = 44;
            this.guna2HtmlLabel3.Text = "12";
            // 
            // HomeCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel2);
            this.Name = "HomeCom";
            this.Size = new System.Drawing.Size(650, 450);
            this.Load += new System.EventHandler(this.HomeCom_Load);
            this.LocationChanged += new System.EventHandler(this.HomeCom_LocationChanged);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel count;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}
