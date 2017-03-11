/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import javax.faces.bean.ManagedBean;
import java.io.Serializable;
import javax.faces.bean.ManagedProperty;
import javax.faces.bean.RequestScoped;
import javax.faces.bean.ViewScoped;
import javax.faces.bean.SessionScoped;
import java.sql.*;
import javax.faces.context.FacesContext;
import java.util.ArrayList;
import javax.faces.context.ExternalContext;
/**
 *
 * @author sudha
 */
@ManagedBean
@RequestScoped
public class Sentmail 
{
    public void notification(String j)
    {
       ArrayList<Application> emailids = new ArrayList<Application>();
       FacesContext context = FacesContext.getCurrentInstance();
       String jId = (context.getExternalContext()
                .getRequestParameterMap().get("jid")); 
       
        try {
            Class.forName("com.mysql.jdbc.Driver");

        } catch (Exception e) {
            e.printStackTrace();

        }
        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/vadiyalas9388";
        Connection connection = null;
        Statement statement = null;
        Statement statement1 = null;
        ResultSet resultSet = null;
        
        try {
            connection = DriverManager.getConnection(DATABASE_URL,"vadiyalas9388","1378113");
            statement = connection.createStatement();
            statement1 = connection.createStatement();
            resultSet = statement.executeQuery("select emailid,status,applicantid from application where jobid='" + j + "'");
            while(resultSet.next())
            {
              Application a = new Application();
              a.setEmailid(resultSet.getString(1));
              a.setStatus(resultSet.getString(2));
              a.setApplicantid(resultSet.getString(3));
              a.setJobid(jId);
            }
            
            for(int i=0;i<emailids.size();i++)
            {
                String appid = emailids.get(i).getApplicantid();
                String emailid = emailids.get(i).getEmailid();
                String jid = emailids.get(i).getJobid();
                String message = "From noreply@uhcl.edu :" +"Your Application has been "+emailids.get(i).getStatus();
                int r = statement1.executeUpdate("insert into mail values"
                        + "('"+ appid +"' , '"+ emailid +"' , '"+ jid +"' , '"+ message +"')");
            }
        }
        catch(SQLException e)
        {
            e.printStackTrace();
            
        }
        finally{
            
            try{
                connection.close();
                statement.close();
                resultSet.close();
            }
            catch(SQLException e)
            {
                e.printStackTrace();
            }
            
        }
    }
}
