import sqlite3

# 1. Connect to the database
with sqlite3.connect("DB01.01.db") as conn:
    # 2. Create a cursor object to execute commands
    cursor = conn.cursor()
    
    # 3. Create a table
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS users (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT NOT NULL,
            email TEXT UNIQUE
        )
    """)
    
    # 4. Update data (Using ? placeholders to prevent SQL injection)
    try:
        # Define your update data
        new_name = 'Albert'
        user_id = 1

        # Execute the UPDATE statement using '?' placeholders
        # The syntax is: UPDATE table_name SET column1 = ?, column2 = ? WHERE condition
        sql_query = "UPDATE users SET name = ? WHERE id = ?"
        cursor.execute(sql_query, (new_name, user_id))

        # Commit your changes to save them to the database
        conn.commit()
    except sqlite3.IntegrityError:
        print("User already exists!")

    # 5. Query data
    cursor.execute("SELECT * FROM users")
    rows = cursor.fetchall()   # Fetches all matching results
    
    print("\n--- User List ---")
    for row in rows:
        print(f"ID: {row[0]} | Name: {row[1]} | Email: {row[2]}")
