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

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt= new DataClasses1DataContext();
           // dataGridView1.DataSource=dt.ACCOUNTANT_DETAILs.ToList();
        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
           using( DataClasses1DataContext dt= new DataClasses1DataContext())
            {
            ACCOUNTANT_DETAIL ac= new ACCOUNTANT_DETAIL();
                ac.Name = name1.Text;
                ac.BirthDate = Convert.ToDateTime(dob1.Text);
                ac.PhoneNo = Convert.ToInt64(phone1.Text);
                ac.MailID = mail1.Text;
                ac.Address= address1.Text;

                dt.ACCOUNTANT_DETAILs.InsertOnSubmit(ac);
                dt.SubmitChanges();
           }
            MessageBox.Show("Account created successfully");
        }

        private void upload_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"H:/Ajith/Ajith.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
