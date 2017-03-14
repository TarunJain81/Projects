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
 * @author Javeed
 */
@ManagedBean
@RequestScoped
public class Register {

    String id, pwd;

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

        final String DATABASE_URL = "jdbc:mysql://mis-sql.uhcl.edu/mohammedj2388";

        Connection connection = null;
        Statement statement = null;
        ResultSet resultSet = null;

        try {
            connection = DriverManager.getConnection(DATABASE_URL, "mohammedj2388", "1398496");
            statement = connection.createStatement();

            if (id.length() < 3 || id.length() > 10) {
                return "ID length should be between 3 and 10 ";
            } else {
                for (int i = 0; i < id.length(); i++) {
                    if ((id.charAt(i) >= 65 && id.charAt(i) <= 90)
                            || (id.charAt(i) >= 97 && id.charAt(i) <= 122)) {
                        charFound = true;
                    } else if (id.charAt(i) >= 49 && id.charAt(i) <= 57) {
                        numFound = true;
                    }
                }
            }
            String uhcl = "@uhcl.edu";
            String finalID = id + uhcl;
            resultSet = statement.executeQuery("select * from emailaccount where username = '"
                    + finalID + "'");
            if (charFound && numFound) {
                if (!resultSet.next()) {

                    int i = statement.executeUpdate("insert into emailaccount values ('"
                            + finalID + "','" + pwd + "')");

                    return "AccountCreated";
                } else {
                    return "idAlreadyExists";
                }
            } else {
                return "alphanumeric";
            }

        } catch (SQLException e) {
            e.printStackTrace();
            return "internal error";
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
