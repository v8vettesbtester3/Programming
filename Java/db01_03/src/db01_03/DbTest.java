package db01_03;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.PreparedStatement;


public class DbTest {

	public static void main(String[] args) {
        // Connection URL for SQLite (creates Db01_03.db if it doesn't exist)
        String url = "jdbc:sqlite:Db01_03.db";

        // SQL statement to create a new table
        String sql = """
            CREATE TABLE IF NOT EXISTS users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                email TEXT UNIQUE,
                created_at DATETIME DEFAULT CURRENT_TIMESTAMP
            );
            """;

        // Use try-with-resources to automatically close connections and statements
        try (Connection conn = DriverManager.getConnection(url);
             Statement stmt = conn.createStatement()) {
            
            // Execute the SQL command
            stmt.executeUpdate(sql);
            System.out.println("Table 'users' created successfully!");

        } catch (SQLException e) {
            System.err.println("Database error: " + e.getMessage());
        }
        
        
        
        // SQL statement with '?' placeholders for parameterized inputs
        sql = "INSERT INTO users (name, email) VALUES (?, ?);";

        // Dummy data to insert
        String userName = "Alice Smith";
        String userEmail = "alice@example.com";

        // Try-with-resources handles automatic closing of connection and statement
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            
            // Bind values to the '?' placeholders based on their 1-indexed position
            pstmt.setString(1, userName);
            pstmt.setString(2, userEmail);

            // Execute the insert command
            int rowsAffected = pstmt.executeUpdate();
            
            if (rowsAffected > 0) {
                System.out.println("A new user was inserted successfully!");
            }

        } catch (SQLException e) {
            System.err.println("Database error: " + e.getMessage());
        }

	}

}
