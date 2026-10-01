package dB01_04;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class DbTest {

	public static void main(String[] args) {
        String url = "jdbc:sqlite:Db01_03.db";
        
        // SQL query to select specific columns
        String sql = "SELECT id, name, email FROM users;";

        // Try-with-resources automatically closes the Connection, PreparedStatement, and ResultSet
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement pstmt = conn.prepareStatement(sql);
             ResultSet rs = pstmt.executeQuery()) {
            
            System.out.println("ID \t Name \t\t Email");
            System.out.println("----------------------------------------");

            // Loop through each row in the results
            while (rs.next()) {
                // Extract column values by specifying the column name or index
                int id = rs.getInt("id");
                String name = rs.getString("name");
                String email = rs.getString("email");

                System.out.println(id + " \t " + name + " \t " + email);
            }

        } catch (SQLException e) {
            System.err.println("Database error: " + e.getMessage());
        }
	}

}
