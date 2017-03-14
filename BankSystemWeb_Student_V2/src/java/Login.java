/*
 * To change this template, choose Tools | Templates
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

/**
 *
 * @author Denny Desktop
 */
@ManagedBean
@SessionScoped
public class Login implements Serializable{

    private String id;
    private String password;
    private OnlineAccount theLoginAccount;
    

    public String getId() {
        return id;
    }

    public String getPassword() {
        return password;
    }

    public OnlineAccount getTheLoginAccount() {
        return theLoginAccount;
    }
    

    public void setId(String id) {
        this.id = id;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    
    
    
    public String login()
    {
        try
        {
            Class.forName("com.mysql.jdbc.Driver");
            
        }
        catch (Exception e)
        {
            return ("interError");
        }
        
        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/jaint7309";
        Connection connection = null;  //a connection to the database
        Statement statement = null;    //execution of a statement
        ResultSet resultSet = null;   //set of results
        
        
        try
        {      
            //connect to the database with user name and password
            connection = DriverManager.getConnection(DATABASE_URL, 
                    "jaint7309", "1446325");   
            statement = connection.createStatement();
            
            resultSet = statement.executeQuery("Select * from onlineaccount "
                    + "where id = '" + 
                    id + "'" );
            if(resultSet.next())
            {
                //the id was found
                if(password.equals(resultSet.getString(3)))
                {
                    //login good,online account created
                    theLoginAccount = new OnlineAccount(id,resultSet.getString(2),password);
                    return "welcome";
                }
                else
                {
                    id = "";
                    password = "";
                    //incorrect password
                    return "loginNotOK";
                }
                
            }
            else
            {
                id = "";
                password = "";
                return "loginNotOK";
            }
            
             
        }
        catch (SQLException e)
        {
            e.printStackTrace();
            return ("internalError");
        }
        finally
        {
            try
            {
                resultSet.close();
                statement.close();
                connection.close();
                 
            }
            catch (Exception e)
            {
                e.printStackTrace();    
            }
        }
    }
        
         
        
} 
    

