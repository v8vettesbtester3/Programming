package db01_01;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class DbTest {

	public static void main(String[] args) {
        // 'Db01_01.db' will be created in your project root folder
        String url = "jdbc:sqlite:Db01_01.db"; 

        // Establish the database connection
        try (Connection conn = DriverManager.getConnection(url)) {
            if (conn != null) {
                System.out.println("Successfully connected to SQLite!");
            }
        } catch (SQLException e) {
            System.err.println("Connection failed: " + e.getMessage());
        }
	}

}
