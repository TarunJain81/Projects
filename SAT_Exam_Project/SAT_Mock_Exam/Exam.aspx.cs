using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exam : System.Web.UI.Page
{
    static double TotalScore = 0;

    private List<int> QuizIds
    {
        get
        {
            var quizIds = Session["QuizIds"] as List<int>;
            if (quizIds == null)
            {
                Session["QuizIds"] = quizIds = new List<int>();
            }
            return quizIds;
        }
    }
    private int Level
    {
        get
        {
            return Session["Level"] == null ? 0 : (int) Session["Level"];
        }

        set
        {
            Session["Level"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            using(var context = new TestDataEntities())
            {
                var question = (from q in context.Questions
                                where q.Level == 0
                                select q).FirstOrDefault();
                if (question != null)
                {
                    Label1.Text = question.Quest;
                    QuizIdField.Value = question.QuizId.ToString();
                    string[] options = question.Answers.Split('|');

                    foreach (string option in options)
                    {
                        ListItem i = new ListItem(option);
                        RadioButtonList1.Items.Add(i);
                    }
                }

            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        RadioButtonList1.ClearSelection();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        switch (CheckAnswer())
        {
            case AnswerStatus.Correct:
                Level = Level + 1;
                break;
            case AnswerStatus.Wrong:
                if (Level > 0) Level = Level - 1;
                break;
        }
        QuizIds.Add(int.Parse(QuizIdField.Value));
        RadioButtonList1.Items.Clear();
        using (var context = new TestDataEntities())
        {
            var question = (from q in context.Questions
                            where ! QuizIds.Contains(q.QuizId) // QuizIds = {1} ==> 'QuizId NOT IN (1)'
                                 && q.Level == Level
                            select q).FirstOrDefault();


            if (question != null)
            {
                Label1.Text = question.Quest;

                string[] options = question.Answers.Split('|');

                foreach (string option in options)
                {
                    ListItem i = new ListItem(option);
                    RadioButtonList1.Items.Add(i);
                }
            }

        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Result.aspx");
    }

    private AnswerStatus CheckAnswer()
    {
        var yourAnswer = RadioButtonList1.SelectedValue;

        using (var context = new TestDataEntities())
        {
            var question = (from q in context.Questions
                            where q.QuizId == 1
                            select q).FirstOrDefault();
            if (yourAnswer==null)
            {
                return AnswerStatus.Blank;
            }
            return question.Ans == yourAnswer ? AnswerStatus.Correct : AnswerStatus.Wrong;
        }
    }

    private enum AnswerStatus
    {
        Blank,
        Correct,
        Wrong
    }
}