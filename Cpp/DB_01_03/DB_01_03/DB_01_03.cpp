// DB_01_03.cpp : This shows an example of:
// 1. creating a table
// 2. inserting data into a table
// 3. reading a record from a table
// 4. updating a record
//

#include <iostream>
#include "sqlite3.h"

using namespace std;

int main()
{
    sqlite3* db;
    char* errMessage = 0;
    sqlite3_stmt* stmt;
    int rc;
    string sqlCommand;


    // ====================================
    // CREATE TABLE
    
    // Open database (Creates 'users.db' if it doesn't exist)
    rc = sqlite3_open("users.db", &db);
    if (rc != SQLITE_OK) {
        cerr << "Can't open database: " << sqlite3_errmsg(db) << endl;
        sqlite3_close(db);
        return rc;
    }

    // 1. CREATE Table
    sqlCommand = "CREATE TABLE IF NOT EXISTS USERS(" \
        "ID INTEGER PRIMARY KEY AUTOINCREMENT, " \
        "NAME TEXT NOT NULL, " \
        "EMAIL TEXT NOT NULL);";

    // Compile the SQL text into a byte-code program (prepared statement) stored in stmt.
    rc = sqlite3_prepare_v2(db, sqlCommand.c_str(), -1, &stmt, NULL);
    if (rc != SQLITE_OK) {
        cerr << "Failed to prepare statement: " << sqlite3_errmsg(db) << endl;
        sqlite3_close(db);
        return 1;
    }

    // : Evaluate the statement. Return SQLITE_ROW when a row of data is ready, or SQLITE_DONE when finished.
    rc = sqlite3_step(stmt);
    if (rc != SQLITE_DONE) {
        cerr << "Execution failed: " << sqlite3_errmsg(db) << endl;
    }

    // : Destroy the prepared statement to free memory and prevent leaks.
    sqlite3_finalize(stmt);



    //=================================
    // INSERT
    sqlCommand = "INSERT INTO USERS (NAME, EMAIL) VALUES " \
        "('Alice', 'alice@gmail.com')," \
        "('Bob', 'bob@gmail.com')," \
        "('Cindy', 'cindy@gmail.com')" \
        ";";

    // Compile the SQL text into a byte-code program (prepared statement) stored in stmt.
    rc = sqlite3_prepare_v2(db, sqlCommand.c_str(), -1, &stmt, NULL);
    if (rc != SQLITE_OK) {
        cerr << "Failed to prepare statement: " << sqlite3_errmsg(db) << endl;
        sqlite3_close(db);
        return 1;
    }

    // Evaluate the statement. Return SQLITE_ROW when a row of data is ready, or SQLITE_DONE when finished.
    rc = sqlite3_step(stmt);
    if (rc != SQLITE_DONE) {
        cerr << "Execution failed: " << sqlite3_errmsg(db) << endl;
    }

    // Destroy the prepared statement to free memory and prevent leaks.
    sqlite3_finalize(stmt);


    // ==================================
    // Read a record
    sqlCommand = "SELECT * from users;";

    // Compile the SQL text into a byte-code program (prepared statement) stored in stmt.
    rc = sqlite3_prepare_v2(db, sqlCommand.c_str(), -1, &stmt, NULL);
    if (rc != SQLITE_OK) {
        cerr << "Failed to prepare statement: " << sqlite3_errmsg(db) << endl;
        sqlite3_close(db);
        return 1;
    }

    // Evaluate the statement. Return SQLITE_ROW when a row of data is ready, or SQLITE_DONE when finished.
    while ((rc = sqlite3_step(stmt)) == SQLITE_ROW) {
        int id = sqlite3_column_int(stmt, 0);
        const unsigned char* name = sqlite3_column_text(stmt, 1);
        const unsigned char* email = sqlite3_column_text(stmt, 2);
        cout << "ID: " << id << endl;
        cout << "Name: " << name << endl;
        cout << "Email: " << email << endl;
        cout << "--------------------------" << endl;
    }


    if (rc != SQLITE_DONE) {
        cerr << "Execution failed: " << sqlite3_errmsg(db) << endl;
    }

    // Destroy the prepared statement to free memory and prevent leaks.
    sqlite3_finalize(stmt);
    


    //=========================================
    // Update a record
    sqlCommand = "UPDATE users set name = 'Albert' where name = 'Alice';";

    // Compile the SQL text into a byte-code program (prepared statement) stored in stmt.
    rc = sqlite3_prepare_v2(db, sqlCommand.c_str(), -1, &stmt, NULL);
    if (rc != SQLITE_OK) {
        cerr << "Failed to prepare statement: " << sqlite3_errmsg(db) << endl;
        sqlite3_close(db);
        return 1;
    }

    // Evaluate the statement. Return SQLITE_ROW when a row of data is ready, or SQLITE_DONE when finished.
    rc = sqlite3_step(stmt);
    if (rc != SQLITE_DONE) {
        cerr << "Execution failed: " << sqlite3_errmsg(db) << endl;
    }

    // Destroy the prepared statement to free memory and prevent leaks.
    sqlite3_finalize(stmt);




    // close the database
    sqlite3_close(db);


    return 0;
}
