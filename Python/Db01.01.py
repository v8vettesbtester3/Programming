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
    
    # 4. Insert data (Using ? placeholders to prevent SQL injection)
    try:
        cursor.execute(
            "INSERT INTO users (name, email) VALUES (?, ?)", 
            ("Alice", "alice@example.com")
        )
        # Commit the transaction to save changes
        conn.commit() 
    except sqlite3.IntegrityError:
        print("User already exists!")

    # 5. Query data
    cursor.execute("SELECT * FROM users")
    rows = cursor.fetchall()   # Fetches all matching results
    
    print("\n--- User List ---")
    for row in rows:
        print(f"ID: {row[0]} | Name: {row[1]} | Email: {row[2]}")
