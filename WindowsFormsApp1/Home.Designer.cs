
namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.student = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.exam = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.last = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.wel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.student.SuspendLayout();
            this.exam.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(4, -4);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(148, 116);
            this.guna2ImageButton2.TabIndex = 15;
            this.guna2ImageButton2.UseTransparentBackground = true;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.BorderColor = System.Drawing.Color.Gainsboro;
            this.student.BorderRadius = 20;
            this.student.BorderThickness = 5;
            this.student.Controls.Add(this.guna2HtmlLabel1);
            this.student.Controls.Add(this.guna2ImageButton2);
            this.student.FillColor = System.Drawing.Color.Transparent;
            this.student.Location = new System.Drawing.Point(173, 165);
            this.student.Name = "student";
            this.student.ShadowDecoration.Color = System.Drawing.Color.White;
            this.student.ShadowDecoration.Depth = 100;
            this.student.ShadowDecoration.Enabled = true;
            this.student.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.student.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.student.Size = new System.Drawing.Size(155, 132);
            this.student.TabIndex = 16;
            this.student.UseTransparentBackground = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            this.student.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Fira Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 94);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Student";
            // 
            // exam
            // 
            this.exam.BackColor = System.Drawing.Color.Transparent;
            this.exam.BorderColor = System.Drawing.Color.Gainsboro;
            this.exam.BorderRadius = 20;
            this.exam.BorderThickness = 5;
            this.exam.Controls.Add(this.guna2HtmlLabel2);
            this.exam.Controls.Add(this.guna2ImageButton3);
            this.exam.FillColor = System.Drawing.Color.Transparent;
            this.exam.Location = new System.Drawing.Point(471, 165);
            this.exam.Name = "exam";
            this.exam.ShadowDecoration.Color = System.Drawing.Color.White;
            this.exam.ShadowDecoration.Depth = 100;
            this.exam.ShadowDecoration.Enabled = true;
            this.exam.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exam.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.exam.Size = new System.Drawing.Size(155, 132);
            this.exam.TabIndex = 18;
            this.exam.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Fira Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(55, 94);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(43, 23);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Exam";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.Location = new System.Drawing.Point(4, -4);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(148, 116);
            this.guna2ImageButton3.TabIndex = 15;
            this.guna2ImageButton3.UseTransparentBackground = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 50;
            this.guna2Panel3.Controls.Add(this.last);
            this.guna2Panel3.Controls.Add(this.wel);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.Location = new System.Drawing.Point(-63, -135);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(451, 205);
            this.guna2Panel3.TabIndex = 19;
            this.guna2Panel3.UseTransparentBackground = true;
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.Gainsboro;
            this.last.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Bold);
            this.last.ForeColor = System.Drawing.Color.Black;
            this.last.Location = new System.Drawing.Point(86, 139);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(106, 19);
            this.last.TabIndex = 22;
            this.last.Text = "guna2HtmlLabel5";
            // 
            // wel
            // 
            this.wel.BackColor = System.Drawing.Color.Gainsboro;
            this.wel.Font = new System.Drawing.Font("Fira Mono", 16F, System.Drawing.FontStyle.Bold);
            this.wel.ForeColor = System.Drawing.Color.Navy;
            this.wel.Location = new System.Drawing.Point(136, 164);
            this.wel.Name = "wel";
            this.wel.Size = new System.Drawing.Size(198, 28);
            this.wel.TabIndex = 20;
            this.wel.Text = "guna2HtmlLabel5";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel4.TabIndex = 1;
            this.guna2HtmlLabel4.Text = "guna2HtmlLabel4";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "guna2HtmlLabel3";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Gainsboro;
            this.time.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Bold);
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(682, 419);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(106, 19);
            this.time.TabIndex = 21;
            this.time.Text = "guna2HtmlLabel5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-47, -76);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(849, 558);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            this.gunaPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPictureBox1_MouseDown);
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(719, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(69, 68);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.student);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.student.ResumeLayout(false);
            this.student.PerformLayout();
            this.exam.ResumeLayout(false);
            this.exam.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Panel student;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel exam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel wel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel time;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel last;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}