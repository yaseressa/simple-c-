using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public string user;
        public string date;
        public Registration(string u, string d)
        {
            InitializeComponent();
            var Home = new HomeCom();
            userc(Home);
            this.user = u;
            this.date = d;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var Home = new HomeCom();
            userc(Home);
        }
        private void userc(UserControl userControl)
        {
            container.Controls.Clear();
            container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            wel.Text = $"Welcome, {this.user}";
            last.Text = $"Last: {this.date}";
            timer1.Start();
        }


        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Login().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            userc(new StudentCom());

        }

        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
