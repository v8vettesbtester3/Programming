import sqlite3

# 1. Connect to the database
conn = None

try:
    conn = sqlite3.connect("ageHeight.db")
    # 2. Create a cursor object to execute commands
    cursor = conn.cursor()
    
    # 3. Create a table
    cursor.execute("""
        create table ageHeight (
            id integer primary key autoincrement,
            name text not null,
            height real not null,   -- centimeters
            birthYear integer not null, -- 4 digits
            birthMonth integer not null -- 1-12
            )
    """)

    name = 'Bob'
    while name != '':
        # 4. Update data (Using ? placeholders to prevent SQL injection)
        try:
            # Define your update data
            name = input('Enter name, <enter> to quit: ')
            if name == '':
                continue  # skip rest of cycle to end loop
            height = float(input('Enter height in cm: '))
            birthYear = int(input('Enter year of birth (4 digits): '))
            birthMonth = int(input('Enter month of birth (1-12): '))
            
            

            cursor.execute(
                "INSERT INTO ageHeight (name, height, birthYear, birthMonth) values (?, ?, ?, ?)", 
                ("'"+name+"'", height, birthYear, birthMonth)
            )

            # Commit your changes to save them to the database
            conn.commit()
        except sqlite3.IntegrityError:
            print("User already exists!")


    cmd = "1"
    while cmd != "0":
        # show menu
        print("""\n\nMENU
1: Show entire table, alphabetical order of names
2: Show names and ages (months), from younest to oldest
3: Show names and heights, from shortest to tallest
0: Quit input
""")
        cmd = input(">> ")
        if cmd == "0":
            continue    # end looping
        
        elif cmd == "1":
            # 5. Query data
            cursor.execute("select * from ageHeight order by name")
            rows = cursor.fetchall()   # Fetches all matching results
            
            print("\n--- User List ---")
            for row in rows:
                print(f"id: {row[0]} | name: {row[1]} | height: {row[2]} | birthYear: {row[3]} | birthMonth: {row[4]}")
                
        elif cmd == "2":
            # 5. Query data
            cursor.execute("""select name, sub.age
from
(select name, (
    (SELECT strftime('%m', 'now') AS CurrentMonth) 
    + ((SELECT strftime('%Y', 'now') AS CurrentYear) - birthYear)*12 
    - birthMonth)  
    as age, height from ageHeight) as sub order by sub.age""")
            rows = cursor.fetchall()   # Fetches all matching results
            
            print("\n--- User List ---")
            for row in rows:
                print(f"name: {row[0]} | age: {row[1]}")
            rows = cursor.fetchall()   # Fetches all matching results
                
        elif cmd == "3":
            cursor.execute("select name, height from ageHeight order by height")
            rows = cursor.fetchall()   # Fetches all matching results
            
            print("\n--- User List ---")
            for row in rows:
                print(f"name: {row[0]} | height: {row[1]}")

except sqlite3.Error as e:
    print(f"An error occurred: {e}")

finally:
    if conn:
        conn.close()
        print("Database connection closed.")
