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
    public partial class StudentCom : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CI1L1E6;Initial Catalog=users;Integrated Security=True");

        public StudentCom()
        {
            InitializeComponent();
            dg.DataSource = null;
            showData();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new StRegister().Show();

        }
        void showData()
        {
            string qry = " select * from student";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            var bind= new BindingSource(); 
            bind.DataSource = dt;
            dg.DataSource =  bind;
        }

        private void StudentCom_Load(object sender, EventArgs e)
        {
            dg.Refresh();

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
