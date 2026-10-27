from pathlib import Path

# Get system landmarks
current_dir = Path.cwd()  # Current working directory
print("Current working directory:",current_dir)
home_dir = Path.home()    # User's home directory
print("Home directory:",home_dir)

# Explicit path creation
custom_path = Path("E:\\Technology\\Programming\\Python\\Examples_pathlib")
print("Custom path example:",custom_path)

# Joining paths
# pathlib overloads the division (/) operator,
# allowing you to chain paths naturally
# without calling a function like os.path.join()
base_dir = Path.home()
text_file = base_dir / "Documents" / "readme.txt"
print("Path for a text file:",text_file)



# Quick content reading and writing
target = Path("note.txt")

# Write text directly
target.write_text("Hello from Pathlib!")

# Read text directly
content = target.read_text()
print(content)  # "Hello from Pathlib!"


# Checking a Filesystem State
path = Path("data/records.csv")

if path.exists():
    if path.is_file():
        print("It's a file!")
    elif path.is_dir():
        print("It's a folder!")



# Directory Iteration and Pattern Matching (glob)
folder = Path("my_project")

# List immediate contents
for item in folder.iterdir():
    print(item.name)

# Find all python files in this folder and ALL sub-folders recursively
for py_file in folder.rglob("*.py"):
    print(py_file)



