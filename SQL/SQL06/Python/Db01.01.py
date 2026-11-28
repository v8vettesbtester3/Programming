"""
This program illustrates several basic SQL operations in Python:
1. Making a database connection.
2. Creating a table.
3. Inserting records into the table.
4. Querying records from the table.
5. Updating records in the table.
6. Deleting records from the table.

Author: J. M. Hinckley
"""
import sqlite3

# Connect to the database
conn = sqlite3.connect("DB01.01.db")

# Create a cursor object to execute commands.
cursor = conn.cursor()

# Create a table.
cursor.execute("""
    create table if not exists users (
    id integer primary key autoincrement,
    name text not null,
    email text unique
    )
    """)

# Insert data (using ? placeholders to prevent SQL injection)
try:
    cursor.execute(
        "insert into users (name, email) values (?, ?)",
        ("Alice","alice@example.com")
        )
    cursor.execute(
        "insert into users (name, email) values (?, ?)",
        ("Bob","bob@example.com")
        )
    cursor.execute(
        "insert into users (name, email) values (?, ?)",
        ("Charlene","charlene@example.com")
        )
    cursor.execute(
        "insert into users (name, email) values (?, ?)",
        ("Dilbert","dilbert@example.com")
        )

    # Commit the transaction to save the changes.
    conn.commit()

except sqlite3.IntegrityError:
    print("User already exists.")

# Query the data
cursor.execute("select * from users")
rows = cursor.fetchall()    # fetches all matching results

# Display the data
print("\n\n")
for row in rows:
    print(f"ID: %3d | Name: %10s | Email: %20s"%(row[0],row[1],row[2]))


# Update the data using ? placeholders
cursor.execute (
    "update users set name = ?, email = ? where id = ?",
    ("Arnold","arnold@example.com",1)
    )
cursor.execute (
    "update users set name = ?, email = ? where id = ?",
    ("Betty","betty@example.com",2)
    )
cursor.execute (
    "update users set name = ?, email = ? where id = ?",
    ("Clarence","clarence@example.com",3)
    )
cursor.execute (
    "update users set name = ?, email = ? where id = ?",
    ("Doris","doris@example.com",4)
    )
# Commit the transaction to save the changes.
conn.commit()


# Display the modified data
cursor.execute("select * from users")
rows = cursor.fetchall()    # fetches all matching results

print("\n\nModified data\n")
for row in rows:
    print(f"ID: %3d | Name: %10s | Email: %20s"%(row[0],row[1],row[2]))


# Delete a record
cursor.execute("delete from users where id = ?",(4,))
# Commit the transaction to save the changes.
conn.commit()



# Display the modified data
cursor.execute("select * from users")
rows = cursor.fetchall()    # fetches all matching results

print("\n\nLast record removed data\n")
for row in rows:
    print(f"ID: %3d | Name: %10s | Email: %20s"%(row[0],row[1],row[2]))

    

# Close the database connection
conn.close()

# Connect to the database
conn = sqlite3.connect("DB01.01.db")

# Create a cursor object to execute commands.
cursor = conn.cursor()



# Add another record
cursor.execute(
    "insert into users (name, email) values (?, ?)",
    ("Ethyl","ethyl@example.com")
    )
conn.commit()


# Display the new data
cursor.execute("select * from users")
rows = cursor.fetchall()    # fetches all matching results

print("\n\nNew record added\n")
for row in rows:
    print(f"ID: %3d | Name: %10s | Email: %20s"%(row[0],row[1],row[2]))



# Close the database connection
conn.close()

    
