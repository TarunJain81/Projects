/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import java.sql.*;
import java.io.Serializable;
import java.util.ArrayList;
import javax.faces.bean.SessionScoped;
import javax.faces.context.FacesContext;
/**
 *
 * @author Rekha Jain
 */
@ManagedBean
@SessionScoped
public class Login implements Serializable{

    private String id;
    private String pwd;
    private String toEmailId;

    public ArrayList<email> getSentmails() {
        return sentmails;
    }

    public void setSentmails(ArrayList<email> sentmails) {
        this.sentmails = sentmails;
    }
    private String subject;
    private String content;
 //   private String Id;
    private int mailNumber;
    private String rContent;
public ArrayList<email> sentmails = new ArrayList<email>();

    public String getrContent() {
        return rContent;
    }

    public void setrContent(String rContent) {
        this.rContent = rContent;
    }

    public int getMailNumber() {
        return mailNumber;
    }

    public void setMailNumber(int mailNumber) {
        this.mailNumber = mailNumber;
    }

    public String getrSubject() {
        return rSubject;
    }

    public void setrSubject(String rSubject) {
        this.rSubject = rSubject;
    }

    public String getrToEmail() {
        return rToEmail;
    }

    public void setrToEmail(String rToEmail) {
        this.rToEmail = rToEmail;
    }

    public String getOldContent() {
        return oldContent;
    }

    public void setOldContent(String oldContent) {
        this.oldContent = oldContent;
    }
    private String rSubject;
    private String rToEmail;
    private String oldContent;
    

    public String getToEmailId() {
        return toEmailId;
    }

    public void setToEmailId(String toEmailId) {
        this.toEmailId = toEmailId;
    }

    public String getSubject() {
        return subject;
    }

    public void setSubject(String subject) {
        this.subject = subject;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }
    

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }
    
     public ArrayList<email> emails = new ArrayList<email>();

    public ArrayList<email> getEmails() {
        return emails;
    }

    public void setEmails(ArrayList<email> emails) {
        this.emails = emails;
    }
    /**
     * Creates a new instance of Login
     */
    public String loginAccount() {

        //sent();
        String fromEmail, toEmail, subject, content, status, type;
        String dateTime;
        int emailNo = 0;

        try {
            Class.forName("com.mysql.jdbc.Driver");

        } catch (Exception e) {
            e.printStackTrace();
        }

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/jaint7309";

        Connection connection = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;
        Statement statement = null;

        try {
            connection = DriverManager.getConnection(DATABASE_URL, "jaint7309", "1446325");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from emailaccount where id = '" + id + "';");

            if (!resultSet.next()) {
                return "userIDnotFound";
            } else if (pwd.equals(resultSet.getString(2))) {

                resultSet1 = statement.executeQuery("SELECT * FROM email WHERE toid = '" + id + "' ORDER BY ID desc");
                emails.clear();
                while (resultSet1.next()) {
                    fromEmail = resultSet1.getString(4);
                    toEmail = resultSet1.getString(5);
                    subject = resultSet1.getString(2);
                    content = resultSet1.getString(3);
                    dateTime = resultSet1.getString(6);
                    status = resultSet1.getString(8);
                    emailNo = resultSet1.getInt(1);
                    type = resultSet1.getString(7);

                    email newEmail = new email(fromEmail, toEmail, subject, dateTime, content, status, emailNo, type);
                    emails.add(newEmail);
                }
                return "loginView";

            } else {
                emails.clear();
                id = "";
                pwd = "";
                return "loginnotok";
                //return "Password does not match with user ID";
            }
        } catch (SQLException e) {
            e.printStackTrace();
            return "internalerror";
        } finally {
            try {
                connection.close();
                statement.close();
                resultSet.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

    }

     public String composeMail() {
        int emailNo = 0;
        String dateTime = "", status = "R";

        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (Exception e) {
            e.printStackTrace();
        }
        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/jaint7309";

        try {

            connection = DriverManager.getConnection(DATABASE_URL, "jaint7309", "1446325");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from emailaccount where id = '" + toEmailId + "'");
          
             
            // return(content);
            if (resultSet.next()) {

                resultSet = statement.executeQuery("select ID from email order by ID desc");
                if (resultSet.next()) {
                    int emailnumber = resultSet.getInt(1);
                    int nextemailnumber = 0;
                    nextemailnumber = emailnumber + 1;
                    DateAndTime dt = new DateAndTime();
                    dateTime = dt.DateAndTime();
                    int i = statement.executeUpdate("insert into email values('" + nextemailnumber + "','" + subject + "','" + content + "','" + id + "','" + toEmailId + "','" + dateTime + "','" + "S" + "','" + "(New)" + "','" + 100000 + "');");

                }
                return "composeConfirmation";

            } else {
                return "toIdNotFound";
            }
        } catch (SQLException e) {
            e.printStackTrace();
            return "internalerror";
        } finally {
            try {
                connection.close();
                statement.close();
                resultSet.close();

            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
      public String signOut() {

        FacesContext.getCurrentInstance().getExternalContext().invalidateSession();


        return "index.xhtml";

    }
public String reply(int id, String senderid, String subject, String content) {

        mailNumber = id;
        rSubject = subject;
        rToEmail = senderid;
        oldContent = content;

        return ("reply.xhtml");

    }

    public String replyfinal() {
        
        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (Exception e) {
            e.printStackTrace();
        }
        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/jaint7309";

        try {

            connection = DriverManager.getConnection(DATABASE_URL, "jaint7309", "1446325");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from email order by ID desc");

            if (resultSet.next()) {

                int emailnumber = resultSet.getInt(1);
                int nextemailnumber = 0;
                nextemailnumber = emailnumber + 1;
                DateAndTime dt = new DateAndTime();
                String dateTime = dt.DateAndTime();
                String Re = "";
                if (rSubject.startsWith("Re")) {
                    Re = rSubject;
                } else {
                    Re = "Re:" + rSubject;

                }
      int i = statement.executeUpdate("insert into email values('" + nextemailnumber + "','" + Re + "','" + rContent + "','" + id + "','" + rToEmail + "','" + dateTime + "','R','New'" + ")");

            email sentEmail = new email(nextemailnumber,id,rToEmail,Re,dateTime,rContent,"new","R");
                sentmails.add(sentEmail);
                return "mailsent";

            } else {
                // return " To Email ID does not exists";
                return "internalerror";
            }
        } catch (SQLException e) {
            e.printStackTrace();
            return "internalerror";
        } finally {
            try {
                connection.close();
                statement.close();
                resultSet.close();

            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

}


