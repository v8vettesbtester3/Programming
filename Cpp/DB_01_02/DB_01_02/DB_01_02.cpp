// DB_01_02.cpp : This shows an example of:
// 1. creating a table
// 2. inserting data into a table
// 3. reading a record from a database table
// 4. updating a record
//

#include <iostream>
#include "sqlite3.h"

using namespace std;

// Callback function to read/display query results
static int callback(void* NotUsed, int argc, char** argv, char** azColName) {
    for (int i = 0; i < argc; i++) {
        cout << azColName[i] << " = " << (argv[i] ? argv[i] : "NULL") << "\n";
    }
    cout << "\n";
    return 0;
}


int main()
{
    cout << "SQLite Runtime Version: " << sqlite3_libversion() << endl;

    sqlite3* db;
    char* errMessage = 0;

    // Open database (Creates 'users.db' if it doesn't exist)
    int rc = sqlite3_open("users.db", &db);
    if (rc) {
        cerr << "Can't open database: " << sqlite3_errmsg(db) << endl;
        return rc;
    }

    // 1. CREATE Table & Insert Record (Create)
    string sqlCreate = "CREATE TABLE IF NOT EXISTS USERS(" \
        "ID INTEGER PRIMARY KEY AUTOINCREMENT, " \
        "NAME TEXT NOT NULL, " \
        "EMAIL TEXT NOT NULL);";
    sqlite3_exec(db, sqlCreate.c_str(), 0, 0, &errMessage);

    string sqlInsert = "INSERT INTO USERS (NAME, EMAIL) VALUES ('Alice', 'alice@example.com');";
    sqlite3_exec(db, sqlInsert.c_str(), 0, 0, &errMessage);
    cout << "--- Record Inserted (Create) ---\n";

    // 2. READ Records (Read)
    cout << "--- Reading Records (Read) ---\n";
    string sqlRead = "SELECT * FROM USERS;";
    sqlite3_exec(db, sqlRead.c_str(), callback, 0, &errMessage);

    // 3. UPDATE Record (Update)
    string sqlUpdate = "UPDATE USERS SET EMAIL = 'alice.new@example.com' WHERE NAME = 'Alice';";
    sqlite3_exec(db, sqlUpdate.c_str(), 0, 0, &errMessage);
    cout << "--- Record Updated (Update) ---\n";

    // Read again to verify update
    sqlite3_exec(db, sqlRead.c_str(), callback, 0, &errMessage);

    // 4. DELETE Record (Delete)
    string sqlDelete = "DELETE FROM USERS WHERE NAME = 'Alice';";
    sqlite3_exec(db, sqlDelete.c_str(), 0, 0, &errMessage);
    cout << "--- Record Deleted (Delete) ---\n";

    // Close database connection
    sqlite3_close(db);
    return 0;

}
