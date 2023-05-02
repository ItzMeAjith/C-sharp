using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_Sql_Windows_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // int id=Convert.ToInt32(textBox1.Text);
            DataClasses1DataContext dt= new DataClasses1DataContext();
            Clg_Dept cp=dt.Clg_Depts.First(x=>x.Rollno==1);
            dataGridView1.DataSource = cp;
            textBox1.Text = cp.Stdname;
        }
    }
}
