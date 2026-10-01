package db01_02;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class DbTest {

	public static void main(String[] args) {
        // Connection URL for SQLite (creates Db01_02.db if it doesn't exist)
        String url = "jdbc:sqlite:Db01_02.db";

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
	}

}
