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
    public partial class HomeCom : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CI1L1E6;Initial Catalog=users;Integrated Security=True");
        public HomeCom()
        {
            InitializeComponent();
            conn.Open();
            string qry = "select * from student";
            SqlCommand sc = new SqlCommand(qry, conn);
            SqlDataReader DataRead = sc.ExecuteReader();
            int counter = 1;
            while (DataRead.Read())
            {
                // Use the row data, presumably
                counter++;
            }
            count.Text = "" + counter;

        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel2_Click(object sender, EventArgs e)
        {
            new StRegister().Show();
        }

        private void HomeCom_Load(object sender, EventArgs e)
        {
 
        }

        private void count_Click(object sender, EventArgs e)
        {

        }

        private void HomeCom_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
