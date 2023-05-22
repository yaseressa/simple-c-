using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StRegister : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CI1L1E6;Initial Catalog=users;Integrated Security=True");
        string img;
        MemoryStream mstream;
        public StRegister()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string qry = " select name,department,level,date,address, image from Student where id ='" + txtID.Text + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                SqlDataReader DataRead = sc.ExecuteReader();
                DataRead.Read();


                if (DataRead.HasRows)
                {
                    txtName.Text = DataRead[0].ToString();
                    cmbDepartment.Text = DataRead[1].ToString();
                    cmbLevel.Text = DataRead[2].ToString();
                    dtDate.Text = DataRead[3].ToString();
                    txtAddress.Text = DataRead[4].ToString();
                    byte[] images = (byte[])DataRead[5];

                    if (images == null)
                    {
                        btnPhotoUp.Image = null;

                    }
                    else
                    {
                        this.mstream = new MemoryStream(images);
                        btnPhotoUp.Image = Image.FromStream(mstream);
                    }
                }
                else
                {
                    MessageBox.Show(" this data is not available...");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                byte[] imageBt = null;
                FileStream fStream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                imageBt = br.ReadBytes((int)fStream.Length);
                string id = txtID.Text;
                string name = txtName.Text;
                string department = cmbDepartment.Text;
                string level = cmbLevel.Text;
                var date = dtDate.Value.Date;
                string address = txtAddress.Text;

                conn.Open();
                string qry = "insert into Student(id, name, department, level, date, address, image) values('" + id + "', '" + name + "', '" + department + "','" + level + "', @date, '" + address + "',@imageBt)";
                SqlCommand sc = new SqlCommand(qry, conn);
                sc.Parameters.Add(new SqlParameter("@imageBt", imageBt));
                sc.Parameters.Add(new SqlParameter("@date", date));

                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("data saved");

                }
                else
                {
                    MessageBox.Show("data not saved");
                }
                //showData();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPhotoUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            // image filters  
            od.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (od.ShowDialog() == DialogResult.OK)
            {
                img = od.FileName.ToString();
                btnPhotoUp.ImageLocation = img;
            }
        }

        private void btnPhotoDel_Click(object sender, EventArgs e)
        {
            if (btnPhotoUp.Image != null)
            {
                btnPhotoUp.Image.Dispose();
                btnPhotoUp.Image = null;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBt = null;
                FileStream fStream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                imageBt = br.ReadBytes((int)fStream.Length);

                string id = txtID.Text;
                string name = txtName.Text;
                string department = cmbDepartment.Text;
                string level = cmbLevel.Text;
                string address = txtAddress.Text;

                conn.Open();
                string qry = "update student set name = '" + name + "', department='" + department + "', level='" + level + "', date= @date , address = '" + address + "', image = @img where id='" + id + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                if (this.mstream != null) {
                    sc.Parameters.Add(new SqlParameter("@img", mstream.ToArray()));
                    sc.Parameters.Add(new SqlParameter("@date", dtDate.Value.Date));

                }
                else
                {
                    sc.Parameters.Add(new SqlParameter("@imageBt", imageBt));
                    sc.Parameters.Add(new SqlParameter("@date", dtDate.Value.Date));
                }
                int i = sc.ExecuteNonQuery();
                conn.Close();

                if (i >= 1)
                {
                    MessageBox.Show("data updated");

                }
                else
                {
                    MessageBox.Show("data not updated");
                }
                //showData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            conn.Open();
            string qry = "delete from student where id='" + txtID.Text + "'";
            SqlCommand sc = new SqlCommand(qry, conn);
            int i = sc.ExecuteNonQuery();
            if (Convert.ToBoolean(new SqlCommand(qry, conn).ExecuteNonQuery()))
            {
                MessageBox.Show("data deleted");

            }
            else
            {
                MessageBox.Show("data deleted");
            }
            conn.Close();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID. 293752")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.White;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID. 293752";
                txtID.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name. Omer";
                txtName.ForeColor = Color.MidnightBlue;
            }

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name. Omer")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.White;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.White;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = Color.MidnightBlue;
            }
        }

        private void cmbDepartment_Enter(object sender, EventArgs e)
        {
            cmbDepartment.ForeColor = Color.MidnightBlue;

        }

        private void cmbLevel_Enter(object sender, EventArgs e)
        {
            cmbLevel.ForeColor = Color.MidnightBlue;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbLevel_Leave(object sender, EventArgs e)
        {
            cmbLevel.ForeColor = Color.White;
        }

        private void cmbDepartment_Leave(object sender, EventArgs e)
        {
            cmbDepartment.ForeColor = Color.White;
        }

        private void StRegister_Load(object sender, EventArgs e)
        {

        }

        private void StRegister_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}