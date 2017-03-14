/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.sql.*;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;

/**
 *
 * @author jaint7309
 */
@ManagedBean
@RequestScoped
public class Register {

    String id, pwd,name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
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

    public String createAccount() {

        boolean charFound = false, numFound = false;
        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (Exception e) {
            e.printStackTrace();
        }

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/jaint7309";

        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;

        try {
            connection = DriverManager.getConnection(DATABASE_URL, "jaint7309", "1446325");
            statement = connection.createStatement();

            if (id.length() < 3 || id.length() > 10) {
                return "ID length should be between 3 and 10 ";
            } else {
                for (int i = 0; i < id.length(); i++) {
                    if ((id.charAt(i) >= 65 && id.charAt(i) <= 90)|| (id.charAt(i) >= 97 && id.charAt(i) <= 122)) {
                        charFound = true;
                    } else if (id.charAt(i) >= 49 && id.charAt(i) <= 57) {
                        numFound = true;
                    }
                }
            }
            String uhcl = "@uhcl.edu";
            String finalID = id + uhcl;
            resultSet = statement.executeQuery("select * from emailaccount where id= '"
                    + finalID + "'");
            if (charFound && numFound) {
                if (!resultSet.next()) {

                    int i = statement.executeUpdate("insert into emailaccount values ('"
                            + finalID + "','" + pwd + "','" + name +"');");

                    return "AccountCreated";
                } else {
                    return "idAlreadyExists";
                }
            } else {
                return "alphanumeric";
            }

        } catch (SQLException e) {
            e.printStackTrace();
            return "internalerror";
        } finally {
            try {
                connection.close();
                resultSet.close();
                statement.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

    }

}
