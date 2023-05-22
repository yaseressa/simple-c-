
namespace WindowsFormsApp1
{
    partial class FileHandling
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
            this.log = new Guna.UI.WinForms.GunaLabel();
            this.upload = new Guna.UI.WinForms.GunaButton();
            this.retrieve = new Guna.UI.WinForms.GunaButton();
            this.richer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold);
            this.log.ForeColor = System.Drawing.Color.MidnightBlue;
            this.log.Location = new System.Drawing.Point(190, 63);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(191, 33);
            this.log.TabIndex = 12;
            this.log.Text = "File: Filed";
            // 
            // upload
            // 
            this.upload.AnimationHoverSpeed = 0.07F;
            this.upload.AnimationSpeed = 0.03F;
            this.upload.BackColor = System.Drawing.Color.Transparent;
            this.upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.upload.BorderColor = System.Drawing.Color.Black;
            this.upload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.upload.FocusedColor = System.Drawing.Color.Empty;
            this.upload.Font = new System.Drawing.Font("Nunito", 12F);
            this.upload.ForeColor = System.Drawing.Color.Gainsboro;
            this.upload.Image = null;
            this.upload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upload.ImageSize = new System.Drawing.Size(25, 25);
            this.upload.Location = new System.Drawing.Point(503, 183);
            this.upload.Name = "upload";
            this.upload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.upload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.upload.OnHoverForeColor = System.Drawing.Color.White;
            this.upload.OnHoverImage = null;
            this.upload.OnPressedColor = System.Drawing.Color.Black;
            this.upload.Radius = 7;
            this.upload.Size = new System.Drawing.Size(93, 39);
            this.upload.TabIndex = 13;
            this.upload.Text = "Upload";
            this.upload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upload.Click += new System.EventHandler(this.add_Click);
            // 
            // retrieve
            // 
            this.retrieve.AnimationHoverSpeed = 0.07F;
            this.retrieve.AnimationSpeed = 0.03F;
            this.retrieve.BackColor = System.Drawing.Color.Transparent;
            this.retrieve.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.retrieve.BorderColor = System.Drawing.Color.Black;
            this.retrieve.DialogResult = System.Windows.Forms.DialogResult.None;
            this.retrieve.FocusedColor = System.Drawing.Color.Empty;
            this.retrieve.Font = new System.Drawing.Font("Nunito", 12F);
            this.retrieve.ForeColor = System.Drawing.Color.Gainsboro;
            this.retrieve.Image = null;
            this.retrieve.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.retrieve.ImageSize = new System.Drawing.Size(25, 25);
            this.retrieve.Location = new System.Drawing.Point(503, 228);
            this.retrieve.Name = "retrieve";
            this.retrieve.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.retrieve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.retrieve.OnHoverForeColor = System.Drawing.Color.White;
            this.retrieve.OnHoverImage = null;
            this.retrieve.OnPressedColor = System.Drawing.Color.Black;
            this.retrieve.Radius = 7;
            this.retrieve.Size = new System.Drawing.Size(93, 39);
            this.retrieve.TabIndex = 14;
            this.retrieve.Text = "Retrieve";
            this.retrieve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.retrieve.Click += new System.EventHandler(this.retrieve_Click);
            // 
            // richer
            // 
            this.richer.Location = new System.Drawing.Point(151, 110);
            this.richer.Name = "richer";
            this.richer.Size = new System.Drawing.Size(281, 328);
            this.richer.TabIndex = 15;
            this.richer.Text = "";
            // 
            // FileHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richer);
            this.Controls.Add(this.retrieve);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.log);
            this.Name = "FileHandling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel log;
        private Guna.UI.WinForms.GunaButton upload;
        private Guna.UI.WinForms.GunaButton retrieve;
        private System.Windows.Forms.RichTextBox richer;
    }
}