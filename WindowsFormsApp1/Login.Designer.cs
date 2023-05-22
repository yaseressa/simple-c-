
namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pass = new Guna.UI.WinForms.GunaLineTextBox();
            this.email = new Guna.UI.WinForms.GunaLineTextBox();
            this.logb = new Guna.UI.WinForms.GunaButton();
            this.log = new Guna.UI.WinForms.GunaLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(227, -28);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(774, 558);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPictureBox1_MouseDown);
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(-153, -18);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(934, 558);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 2;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.pass);
            this.guna2Panel1.Controls.Add(this.email);
            this.guna2Panel1.Controls.Add(this.logb);
            this.guna2Panel1.Controls.Add(this.log);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(431, 94);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2Panel1.ShadowDecoration.Depth = 100;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(330, 343);
            this.guna2Panel1.TabIndex = 11;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // pass
            // 
            this.pass.Animated = true;
            this.pass.AutoCompleteCustomSource.AddRange(new string[] {
            "admin"});
            this.pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pass.BackColor = System.Drawing.Color.Gainsboro;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pass.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pass.LineColor = System.Drawing.Color.Navy;
            this.pass.Location = new System.Drawing.Point(52, 178);
            this.pass.Name = "pass";
            this.pass.Padding = new System.Windows.Forms.Padding(10);
            this.pass.PasswordChar = '\0';
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(239, 33);
            this.pass.TabIndex = 11;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.AutoCompleteCustomSource.AddRange(new string[] {
            "admin@email.com"});
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.email.BackColor = System.Drawing.Color.Gainsboro;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.LineColor = System.Drawing.Color.Navy;
            this.email.Location = new System.Drawing.Point(54, 121);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(10);
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(235, 33);
            this.email.TabIndex = 10;
            this.email.Text = "example@email.com";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // logb
            // 
            this.logb.AnimationHoverSpeed = 0.07F;
            this.logb.AnimationSpeed = 0.03F;
            this.logb.BackColor = System.Drawing.Color.Transparent;
            this.logb.BaseColor = System.Drawing.Color.Navy;
            this.logb.BorderColor = System.Drawing.Color.Black;
            this.logb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logb.FocusedColor = System.Drawing.Color.Empty;
            this.logb.Font = new System.Drawing.Font("Unispace", 12F);
            this.logb.ForeColor = System.Drawing.Color.Gainsboro;
            this.logb.Image = ((System.Drawing.Image)(resources.GetObject("logb.Image")));
            this.logb.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logb.ImageSize = new System.Drawing.Size(25, 25);
            this.logb.Location = new System.Drawing.Point(129, 246);
            this.logb.Name = "logb";
            this.logb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logb.OnHoverForeColor = System.Drawing.Color.White;
            this.logb.OnHoverImage = null;
            this.logb.OnPressedColor = System.Drawing.Color.Black;
            this.logb.Radius = 10;
            this.logb.Size = new System.Drawing.Size(85, 39);
            this.logb.TabIndex = 9;
            this.logb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logb.Click += new System.EventHandler(this.logb_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold);
            this.log.ForeColor = System.Drawing.Color.MidnightBlue;
            this.log.Location = new System.Drawing.Point(116, 57);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(111, 33);
            this.log.TabIndex = 8;
            this.log.Text = "LOG-IN";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-86, 94);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(545, 343);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 1000;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(858, -2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(69, 68);
            this.guna2ImageButton1.TabIndex = 13;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPictureBox3);
            this.Font = new System.Drawing.Font("uni 05_53", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaLineTextBox pass;
        private Guna.UI.WinForms.GunaLineTextBox email;
        private Guna.UI.WinForms.GunaButton logb;
        private Guna.UI.WinForms.GunaLabel log;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

