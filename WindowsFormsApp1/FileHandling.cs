using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FileHandling : Form
    {
        public static string textFilePath2 = @"C:\Users\mee\Desktop\fileHandling\test.txt";
        FileStream fs = File.Open(textFilePath2, FileMode.Create);
        byte[] rsByteArray;

        public FileHandling()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.rsByteArray = Encoding.Default.GetBytes(richer.Text);
            fs.Write(rsByteArray, 0,
                rsByteArray.Length);
        }

        private void retrieve_Click(object sender, EventArgs e)
        {
            this.fs.Position = 0;

            // Create byte array to hold file data
            List<byte>fileByteArray = new List<byte>();

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray.Add((byte)fs.ReadByte());
            }

            // Convert from bytes to string and output
            richer.Text = Encoding.Default.GetString(fileByteArray.ToArray());

            // Clos
            

        }
    }
}
