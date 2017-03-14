/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import java.util.ArrayList;
import javax.faces.context.FacesContext;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Javeed
 */
@ManagedBean
@SessionScoped
public class Login implements Serializable {

    public String id, pwd;
    public String toEmailId, content, subject, fromEmail;
    public int MailNumber;
    public String rsubject, rfromEmail;
    public String rcontent, prcontent;
    public int readID;
    String rddfromEmail;
    String rdtoEmail;
    String rdsubject;
    String rdcontent;
    String rddateTime;
    String rdstatus;
    int rdemailNo;
    String rdtype;
    public int LastEmail;

    public int getLastEmail() {
        return LastEmail;
    }

    public void setLastEmail(int LastEmail) {
        this.LastEmail = LastEmail;
    }

    public String getRddfromEmail() {
        return rddfromEmail;
    }

    public void setRddfromEmail(String rddfromEmail) {
        this.rddfromEmail = rddfromEmail;
    }

    public String getRdtoEmail() {
        return rdtoEmail;
    }

    public void setRdtoEmail(String rdtoEmail) {
        this.rdtoEmail = rdtoEmail;
    }

    public String getRdsubject() {
        return rdsubject;
    }

    public void setRdsubject(String rdsubject) {
        this.rdsubject = rdsubject;
    }

    public String getRdcontent() {
        return rdcontent;
    }

    public void setRdcontent(String rdcontent) {
        this.rdcontent = rdcontent;
    }

    public String getRddateTime() {
        return rddateTime;
    }

    public void setRddateTime(String rddateTime) {
        this.rddateTime = rddateTime;
    }

    public String getRdstatus() {
        return rdstatus;
    }

    public void setRdstatus(String rdstatus) {
        this.rdstatus = rdstatus;
    }

    public int getRdemailNo() {
        return rdemailNo;
    }

    public void setRdemailNo(int rdemailNo) {
        this.rdemailNo = rdemailNo;
    }

    public String getRdtype() {
        return rdtype;
    }

    public void setRdtype(String rdtype) {
        this.rdtype = rdtype;
    }

    public int getReadID() {
        return readID;
    }

    public void setReadID(int readID) {
        this.readID = readID;
    }

    public String getPrcontent() {
        return prcontent;
    }

    public void setPrcontent(String prcontent) {
        this.prcontent = prcontent;
    }

    public ArrayList<email> sentmails = new ArrayList<email>();
    public ArrayList<String> readmail = new ArrayList<String>();

    public ArrayList<String> getReadmail() {
        return readmail;
    }

    public void setReadmail(ArrayList<String> readmail) {
        this.readmail = readmail;
    }

    public ArrayList<email> getSentmails() {
        return sentmails;
    }

    public void setSentmails(ArrayList<email> sentmails) {
        this.sentmails = sentmails;
    }

    public String getRsubject() {
        return rsubject;
    }

    public void setRsubject(String rsubject) {
        this.rsubject = rsubject;
    }

    public String getRfromEmail() {
        return rfromEmail;
    }

    public void setRfromEmail(String rfromEmail) {
        this.rfromEmail = rfromEmail;
    }

    public int getMailNumber() {
        return MailNumber;
    }

    public void setMailNumber(int MailNumber) {
        this.MailNumber = MailNumber;
    }

    public String getToEmailId() {
        return toEmailId;
    }

    public void setToEmailId(String toEmailId) {
        this.toEmailId = toEmailId;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getSubject() {
        return subject;
    }

    public void setSubject(String subject) {
        this.subject = subject;
    }

    public String getFromEmail() {
        return fromEmail;
    }

    public void setFromEmail(String fromEmail) {
        this.fromEmail = fromEmail;
    }

    public ArrayList<email> emails = new ArrayList<email>();

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

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        Connection connection = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;
        Statement statement = null;

        try {
            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from emailaccount where username = '" + id + "'");

            if (!resultSet.next()) {
                return "userIDnotFound";
            } else if (pwd.equals(resultSet.getString(2))) {

                resultSet1 = statement.executeQuery("SELECT * FROM email WHERE toID = '" + id + "' ORDER BY ID desc");
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
            return "Internal Error ";
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

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        try {

            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from emailaccount where username = '" + toEmailId + "'");

            // return(content);
            if (resultSet.next()) {

                resultSet = statement.executeQuery("select ID from email order by ID desc");
                if (resultSet.next()) {
                    int emailnumber = resultSet.getInt(1);
                    int nextemailnumber = 0;
                    nextemailnumber = emailnumber + 1;
                    DateAndTime dt = new DateAndTime();
                    dateTime = dt.DateAndTime();
                    int i = statement.executeUpdate("insert into email values('" + nextemailnumber + "','" + subject + "','" + content + "','" + id + "','" + toEmailId + "','" + dateTime + "','" + "S" + "','" + "(New)" + "','" + 100000 + "')");

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

    public String reply(int id, String senderid, String subject, String content) {

        MailNumber = id;
        rsubject = subject;
        rfromEmail = senderid;
        prcontent = content;

        return ("reply.xhtml");

    }

    public String replyfinal() {
        //sent();
        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (Exception e) {
            e.printStackTrace();
        }
        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        try {

            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from email order by ID desc");

            if (resultSet.next()) {

                int emailnumber = resultSet.getInt(1);
                int nextemailnumber = 0;
                nextemailnumber = emailnumber + 1;
                DateAndTime dt = new DateAndTime();
                String dateTime = dt.DateAndTime();
                int LEReply = resultSet.getInt(9);
                //add the Re to reply mails
                String Re = "";
                if (rsubject.startsWith("Re")) {
                    Re = rsubject;
                } else {
                    Re = "Re:" + rsubject;

                }
                if (LEReply == 100000) {
                    int i = statement.executeUpdate("insert into email values('" + nextemailnumber + "','" + Re + "','" + rcontent + "','" + id + "','" + rfromEmail + "','" + dateTime + "','" + "R" + "','" + "New" + "','" + MailNumber + "')");

                } else {
                    int i = statement.executeUpdate("insert into email values('" + nextemailnumber + "','" + Re + "','" + rcontent + "','" + id + "','" + rfromEmail + "','" + dateTime + "','" + "R" + "','" + "New" + "','" + LEReply + "')");

                }

                String RR = "R";
                String NEWR = "New";
                //  email sentEmail = new email(fromEmail, toEmail, subject, dateTime, content, status, emailNo, type);
                // sentmails.add(sentEmail);
                email sentEmail = new email(rfromEmail, id, Re, dateTime, rcontent, NEWR, nextemailnumber, NEWR);
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

    public String sent() {

        String fromEmail, toEmail, subject, content, status, type;
        String dateTime;
        int emailNo = 0;

        try {
            Class.forName("com.mysql.jdbc.Driver");

        } catch (Exception e) {
            e.printStackTrace();
        }

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        Connection connection = null;
        ResultSet resultSet = null;
        Statement statement = null;

        try {
            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();
            String s = "s";
            resultSet = statement.executeQuery("Select * from email where fromId = '" + id + "' order by ID desc");

            sentmails.clear();

            while (resultSet.next()) {
                fromEmail = resultSet.getString(4);
                toEmail = resultSet.getString(5);
                subject = resultSet.getString(2);
                content = resultSet.getString(3);
                dateTime = resultSet.getString(6);
                status = resultSet.getString(8);
                emailNo = resultSet.getInt(1);
                type = resultSet.getString(7);

                email sentEmail = new email(fromEmail, toEmail, subject, dateTime, content, status, emailNo, type);
                sentmails.add(sentEmail);

            }

            return "sentfolder";

        } catch (SQLException e) {
            e.printStackTrace();
            return "Internal Error";
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

    public String read(int Sno) {

        readID = Sno;

        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (Exception e) {
            e.printStackTrace();
        }
        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;
        ResultSet resultSet1 = null;

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        try {

            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select * from email where ID = '" + readID + "'");

            if (resultSet.next()) {

                rddfromEmail = resultSet.getString(4);
                rdtoEmail = resultSet.getString(5);
                rdsubject = resultSet.getString(2);
                rdcontent = resultSet.getString(3);
                rddateTime = resultSet.getString(6);
                rdstatus = resultSet.getString(8);
                rdemailNo = resultSet.getInt(1);
                rdtype = resultSet.getString(7);
                int LERead = resultSet.getInt(9);

                //LastEmail = resultSet.getInt(9);
                int x = 1;
                resultSet1 = statement.executeQuery("select content,ID from email where LE = '" + LERead + "' or ID = '" + LERead + "'    order by date desc");
                readmail.clear();
                while (resultSet1.next()) {
                    if (resultSet1.getInt(2) <= readID ) {

                        readmail.add(resultSet1.getString(1));

                    }
                }

                String readstatus = "";

                int r = statement.executeUpdate("update email set status= '" + readstatus + "' where ID = '" + readID + "'");
                return "viewmail";

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

    public String signOut() {

        FacesContext.getCurrentInstance().getExternalContext().invalidateSession();
//        HttpServletResponse hsr = (HttpServletResponse) FacesContext.getCurrentInstance().getExternalContext().getResponse();
//        hsr.setHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
//        hsr.setHeader("Pragma", "no-cache"); // HTTP 1.0.
//        hsr.setDateHeader("Expires", 0); // Proxies.
//        //FacesContext.getCurrentInstance().getExternalContext().redirect("index.xhtml");   

        return "index.xhtml";

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

    public ArrayList<email> getEmails() {
        return emails;
    }

    public void setEmails(ArrayList<email> emails) {
        this.emails = emails;
    }

    public String getRcontent() {
        return rcontent;
    }

    public void setRcontent(String rcontent) {
        this.rcontent = rcontent;
    }

}
