using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       string sname = TextBox1.Text;

        using(var context= new TestDataEntities())
        {
            var user = (from u in context.Scores
                       where u.Name == sname
                       select u.Name).FirstOrDefault();

            if(user!=null)
            {
                Session["Username"] = Label1.Text;
                Response.Redirect("Exam.aspx");
            }
            else
            {
                Score s = new Score
                {
                    Name = sname,
                    Marks = 0,
                   
                };
                context.Scores.Add(s);
                context.SaveChanges();
                Session["Username"] = Label1.Text;
                Response.Redirect("Exam.aspx");
            }

        }
       
    }
}