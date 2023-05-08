using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LINQ_TO_SQL_ASSIGNMENT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt=new DataClasses1DataContext();
            GridView1.DataSource=dt.Clg_Depts.ToList();
            GridView1.DataBind();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dt=new DataClasses1DataContext())
            {
                int? ro = Convert.ToInt32(Del.Text);
               Clg_Dept cd= dt.Clg_Depts.FirstOrDefault(x=>x.Rollno==ro);
               dt.Clg_Depts.DeleteOnSubmit(cd);
                dt.SubmitChanges();
                MessageBox.Show($"Roll no {ro} deleted succcessfully!!!");
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                Clg_Dept cp = new Clg_Dept
                {
                    Stdname=name.Text,
                    Phoneno=Convert.ToInt64(phone.Text),
                    MailID=mail.Text,
                    Stdaddress=address.Text,
                    Bloodgrp=bgroup.Text,
                    DOB = Convert.ToDateTime(DOB.Text),
                    DeptID=Convert.ToInt32(DEP.Text)
                };
                dt.Clg_Depts.InsertOnSubmit(cp);
                dt.SubmitChanges();
                MessageBox.Show("Inserted successfully!!!");
            }
        }

        protected void address_TextChanged(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dt =new DataClasses1DataContext())
            {
                int id= Convert.ToInt32(DropDownList1.SelectedValue);
                Clg_Dept cp=dt.Clg_Depts.FirstOrDefault(x=>x.Rollno==id);
                cp.Stdname = name.Text;
                cp.Phoneno = Convert.ToInt64(phone.Text);
                cp.MailID = mail.Text;
                cp.Stdaddress = address.Text;
                cp.Bloodgrp = bgroup.Text;
                cp.DOB = Convert.ToDateTime(DOB.Text);
                cp.DeptID = Convert.ToInt32(DEP.Text);
                dt.SubmitChanges();
                MessageBox.Show("Updated successfully!!!");
            }
            
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            GridView1.DataSource = dt.Clg_Depts.ToList();
            GridView1.DataBind();
        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownList2.SelectedValue);
            DataClasses1DataContext dt = new DataClasses1DataContext();
            var res=dt.Clg_Depts.Where(x=>x.DeptID==id).ToList();
            GridView2.DataSource = res;
            GridView2.DataBind();
        }
    }
}