package db01_01;
/**
 * This program illustrates several basic SQL operations in Python:
1. Making a database connection.
2. Creating a table.
3. Inserting records into the table.
4. Querying records from the table.
5. Updating records in the table.
6. Deleting records from the table.

@author: J. M. Hinckley

 */

import java.sql.Connection;			// required for making a database connection
import java.sql.DriverManager;		// required for making a database connection
import java.sql.SQLException;
import java.sql.Statement;			// required for creating a table
import java.sql.PreparedStatement;	// required for inserting data
import java.sql.ResultSet;			// required to query the table

public class DbTest {

	public static void main(String[] args) {
		
		//=====================================================================
		// Connect to the database
		// 'Db01_01.db' will be created in the project root folder.
		// And, create a table.
		String url = "jdbc:sqlite:Db01_01.db";
		String sql = """
				create table if not exists users (
				id integer primary key autoincrement,
				name text not null,
				email text unique
				);
				""";
		try (Connection conn = DriverManager.getConnection(url);
				Statement stmt = conn.createStatement()) {
			if (conn != null) {
				System.out.println("Successfully connected to SQLite.");
				
				// Execute the SQL command
				stmt.executeUpdate(sql);
				System.out.println("Table 'users' created successfully.");
			}
		} catch (SQLException e) {
			System.err.println("Connection failed: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Insert data, using placeholders to avoid SQL injection.
		sql = "insert into users (name, email) values (?, ?);";
		
		String[] userName = {"Alice","Bob","Charlene","Dilbert"};
		String[] userEmail = {"alice@example.com","bob@example.com",
				"charlene@example.com","dilbert@example.com"};
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql)) {

			for (int i = 0; i < userName.length; i++) {
				// Bind values to the '?' place holders based on their 1-indexed position
				pstmt.setString(1, userName[i]);
				pstmt.setString(2, userEmail[i]);

				// Execute the insert command
				int rowsAffected = pstmt.executeUpdate();
				if (rowsAffected > 0) {
					System.out.println("A new user was inserted successfully.");
				}
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Query the data
		sql = "select * from users;";
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql);
			 ResultSet rs = pstmt.executeQuery()) {
			// Loop through each row in the results
			while (rs.next()) {
				// Extract column values by specifying the column name
				int id = rs.getInt("id");
				String name = rs.getString("name");
				String email = rs.getString("email");
				System.out.printf("ID: %3d | Name: %10s | Email: %20s\n", id, name, email);
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Update the data
		sql = "update users set name = ?, email = ? where id = ?";
		
		String[] newuserName = {"Arnold","Betty","Clarence","Doris"};
		String[] newuserEmail = {"arnold@example.com","betty@example.com",
				"clarence@example.com","doris@example.com"};
		int[]idx = {1,2,3,4};
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql)) {

			for (int i = 0; i < newuserName.length; i++) {
				// Bind values to the '?' place holders based on their 1-indexed position
				pstmt.setString(1, newuserName[i]);
				pstmt.setString(2, newuserEmail[i]);
				pstmt.setInt(3, idx[i]);

				// Execute the insert command
				int rowsAffected = pstmt.executeUpdate();
				if (rowsAffected > 0) {
					System.out.println("A user record was updated successfully.");
				} else {
					System.out.println("No user foud iwth the specified ID.");
				}
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Display the modified data
		sql = "select * from users;";
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql);
			 ResultSet rs = pstmt.executeQuery()) {
			// Loop through each row in the results
			while (rs.next()) {
				// Extract column values by specifying the column name
				int id = rs.getInt("id");
				String name = rs.getString("name");
				String email = rs.getString("email");
				System.out.printf("ID: %3d | Name: %10s | Email: %20s\n", id, name, email);
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Delete a record.
		sql = "delete from users where id = ?";
		
		try (Connection conn = DriverManager.getConnection(url); 
				 PreparedStatement pstmt = conn.prepareStatement(sql)) {
			pstmt.setInt(1, 4);
			
			// Execute the delete command
			int rowsAffected = pstmt.executeUpdate();
			
			if (rowsAffected > 0) {
				System.out.println("A record has been deleted");
			}
			}catch (SQLException e) {
				System.err.println("Database error: "+e.getMessage());
			}
		
		
		
		
		//=====================================================================
		// Display the modified data
		
		sql = "select * from users;";
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql);
			 ResultSet rs = pstmt.executeQuery()) {
			// Loop through each row in the results
			while (rs.next()) {
				// Extract column values by specifying the column name
				int id = rs.getInt("id");
				String name = rs.getString("name");
				String email = rs.getString("email");
				System.out.printf("ID: %3d | Name: %10s | Email: %20s\n", id, name, email);
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
		//=====================================================================
		// Add another record.
		
		// Insert data, using placeholders to avoid SQL injection.
		sql = "insert into users (name, email) values (?, ?);";
		
		userName[0] = "Ethyl";
		userEmail[0] = "ethyl@example.com";
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql)) {

			// Bind values to the '?' place holders based on their 1-indexed position
			pstmt.setString(1, userName[0]);
			pstmt.setString(2, userEmail[0]);

			// Execute the insert command
			int rowsAffected = pstmt.executeUpdate();
			if (rowsAffected > 0) {
				System.out.println("A new user was inserted successfully.");
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		//=====================================================================
		// Display the modified data
		
		sql = "select * from users;";
		
		try (Connection conn = DriverManager.getConnection(url); 
			 PreparedStatement pstmt = conn.prepareStatement(sql);
			 ResultSet rs = pstmt.executeQuery()) {
			// Loop through each row in the results
			while (rs.next()) {
				// Extract column values by specifying the column name
				int id = rs.getInt("id");
				String name = rs.getString("name");
				String email = rs.getString("email");
				System.out.printf("ID: %3d | Name: %10s | Email: %20s\n", id, name, email);
			}
		}catch (SQLException e) {
			System.err.println("Database error: "+e.getMessage());
		}
		
		
		
		
	}

}
