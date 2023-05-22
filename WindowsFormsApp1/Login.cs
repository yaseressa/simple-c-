using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CI1L1E6;Initial Catalog=users;Integrated Security=True");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }



  

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void gunaPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "example@email.com")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {

                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.PasswordChar = '-';
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Password";
                pass.PasswordChar = default; // '\0'
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "example@email.com";

            }
        }

        private void logb_Click(object sender, EventArgs e)
        {
            if (email.Text != "example@email.com" || pass.Text != "Password")
            {
                conn.Open();
                string qry = $"select * from users where email='{email.Text}' and password='{pass.Text}'";
                SqlCommand sc = new SqlCommand(qry, conn);
                var ser = sc.ExecuteReader();
                if (ser.Read())
                {
                    new Registration("Admin", DateTime.Now.ToString()).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, "Invalid Credentials.", "Warning", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                conn.Close();
            }
        }
    }
}
