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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet4.AccountInfo' table. You can move, or remove it, as needed.
            this.accountInfoTableAdapter4.Fill(this.bankDataSet4.AccountInfo);
            // TODO: This line of code loads data into the 'bankDataSet3.AccountInfo' table. You can move, or remove it, as needed.
            this.accountInfoTableAdapter3.Fill(this.bankDataSet3.AccountInfo);

            DataClasses1DataContext dt =new DataClasses1DataContext();
            dataGridView1.DataSource = dt.AccountInfos.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dt =new DataClasses1DataContext())
            {
                AccountInfo ac = new AccountInfo()
                {
                    AccountNo=Convert.ToInt32(Acnumber.Text),
                    Acc_Name = name.Text,
                    Phone=Convert.ToInt64(phoneno.Text),
                    AccOpeningDate=dateTimePicker1.Value,
                    AccountBalance= (decimal?)Convert.ToDouble(balance.Text)
                };
                dt.AccountInfos.InsertOnSubmit(ac);
                dt.SubmitChanges();
                MessageBox.Show("Inserted successfully");
            }
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            dataGridView1.DataSource = dt.AccountInfos.ToList();
        }
    }
}
