/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mypack;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.sql.*;
import javax.servlet.annotation.WebServlet;

/*
create database login;
use login;
CREATE TABLE user (
    Name varchar(255),
    Password varchar(255),
    Email varchar(255),
    Country varchar(255)
);
*/
/**
 *
 * @author Admin
 */
@WebServlet(name="RegisterServlet", urlPatterns="/RegisterServlet")
public class RegisterServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet RegisterServlet</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet RegisterServlet at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
        }
    }

    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //processRequest(request, response);
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        String id = request.getParameter("txtUid");
        String ps = request.getParameter("txtPass");
        String em = request.getParameter("txtEmail");
        String co = request.getParameter("txtCon");
        try{
            Class.forName("com.mysql.jdbc.Driver");
            int port = 3306;
            String username = "root";
            String password = "admin";
            // Avoid SSL connection
            String url_param = "useTimeZone=true&serverTimezone=UTC&autoReconnect=true&useSSL=false";
            String url = "jdbc:mysql://localhost:" + port + "/login?" + url_param;
            Connection con =DriverManager.getConnection(url, username, password);
            PreparedStatement pst = con.prepareStatement("insert into user values(?,?,?,?)");
            pst.setString(1,id);
            pst.setString(2,ps);
            pst.setString(3,em);
            pst.setString(4,co);
            int row = pst.executeUpdate();
            out.println("<h1> Araam se zara. The record "+row+ " inserted Succesfully</h1>");
        } catch(Exception e){
            out.println(e);
        }
    }
    

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }

}
