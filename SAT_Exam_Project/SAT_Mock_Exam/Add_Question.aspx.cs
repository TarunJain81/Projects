using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_Question : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] a = TextBox2.Text.Split('|');

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var context = new TestDataEntities())
        {
            Question q = new Question
            {
                QuizId = 10,
                Quest = TextBox1.Text,
                Answers = TextBox2.Text,
                Ans = TextBox3.Text,
                Level = Convert.ToInt32(TextBox4.Text)
             };

            context.Questions.Add(q);
            context.SaveChanges();
        }

      

    }
}