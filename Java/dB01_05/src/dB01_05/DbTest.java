package dB01_05;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class DbTest {

	public static void main(String[] args) {
        String url = "jdbc:sqlite:Db01_03.db";

        // SQL statement to update the email where the id matches
        String sql = "UPDATE users SET email = ? WHERE id = ?;";

        // New data and target record ID
        String newEmail = "new.alice@example.com";
        int targetUserId = 1;

        // Try-with-resources handles automatic closing of connection and statement
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            
            // Bind the new value and the target ID to the placeholders
            pstmt.setString(1, newEmail);
            pstmt.setInt(2, targetUserId);

            // Execute the update command
            int rowsAffected = pstmt.executeUpdate();
            
            if (rowsAffected > 0) {
                System.out.println("User record updated successfully!");
            } else {
                System.out.println("No user found with the specified ID.");
            }

        } catch (SQLException e) {
            System.err.println("Database error: " + e.getMessage());
        }
	}

}
