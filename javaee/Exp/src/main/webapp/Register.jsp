<%-- 
    Document   : Register
    Created on : 16 Sep, 2020, 7:14:15 AM
    Author     : smush
--%>
<%@page import="java.sql.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<!--  
create database data;
use data;
create table employee(eno varchar(10), ename varchar(20), eage varchar(2), edesign varchar(20), esal varchar(20));
insert into employee values("5057", NULL, NULL, NULL, NULL);
select * from employee

# you should have =>

+------+-------+------+---------+------+
| eno  | ename | eage | edesign | esal |
+------+-------+------+---------+------+
| 5057 | NULL  | NULL | NULL    | NULL |
+------+-------+------+---------+------+

# after running this project to update the data, table would have the above row updated like below =>

select * from employee;

+------+-----------+------+---------+-------+
| eno  | ename     | eage | edesign | esal  |
+------+-----------+------+---------+-------+
| 5057 | Mushaheed | 20   | Mumbai  | 20000 |
+------+-----------+------+---------+-------+

-->
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Employee</title>
    </head>
    <body>
        <h1>Employee Details</h1>
          <%
        String id=request.getParameter("eno");
        String name = request.getParameter("ename");
        String age = request.getParameter("eage");
        String design = request.getParameter("edesign");
        String salary = request.getParameter("esal");
      
     try{
        Class.forName("com.mysql.jdbc.Driver");
        // Your mysql config
        int port = 3306;
        String username = "root";
        String password = "admin";
        String databaseName = "data";
        // Avoid SSL connection
        String url_param = "useTimeZone=true&serverTimezone=UTC&autoReconnect=true&useSSL=false";
        String url = "jdbc:mysql://localhost:" + port + "/" + databaseName + "?" + url_param;
        Connection con =DriverManager.getConnection(url, username, password);
        PreparedStatement stmt = con.prepareStatement("update employee set ename = ?, eage = ?, edesign = ?, esal= ? where eno = ?");
        stmt.setString(1, name); stmt.setString(2 , age);
        stmt.setString(3, design); stmt.setString(4, salary); stmt.setString(5, id);
        int row = stmt.executeUpdate();
        if(row==1) { out.println("Update Successful"); }
        else {
        out.println("Update FAIL !!!!");
        %>
        <jsp:include page="index.html" ></jsp:include>
        <%
        }
        }catch(Exception e){out.println(e);}
        %>
    </body>
</html>
