📚 MyLibrary – Desktop Application for Library Management
This is a C# WinForms desktop application for managing a small library's book inventory and borrower records, created as part of the Event-Driven Programming with C# course.

🎯 Features
🔐 Login System
Username and Password authentication against a Users table.

On success, opens the main window. On failure, displays an error message.

Default Credentials:

Username: admin

Password: admin123

📖 Books Management
View all books in a DataGridView: BookID, Title, Author, Year, Available Copies.

Add Book: Enter book details (validated for correctness).

Edit Book: Modify selected book's details.

Delete Book: Delete with confirmation prompt.

Filter (Bonus): Filter books by author or year range.

👥 Borrowers Management
View all borrowers in a DataGridView: BorrowerID, Name, Email, Phone.

Add/Edit/Delete Borrower: Manage borrower records with validation (email format, etc.).

📚 Issue and Return Books
Issue Book:

Select a borrower and a book.

Decrease the book’s AvailableCopies.

Insert a record into the IssuedBooks table.

Return Book:

Select an issued record.

Increase the book’s AvailableCopies.

Remove or mark the issued record as returned.

📊 Reports (Bonus)
Overdue Books: Generate a report for books overdue (DueDate < today).

🛠️ Technical Details
Technology	Description
Language	C#
Framework	.NET (WinForms)
Database	MySQL / SQL Server / SQLite
Data Access	ADO.NET (parameterized queries)
Exception Handling	Try-catch blocks with user-friendly error messages
Validation	Input validation for fields, email formats, and numeric ranges

📂 Project Structure
swift
Copy
Edit
/MyLibrary/
├── /docs/screenshots/
│   ├── login.png
│   ├── main.png
│   ├── books_management.png
│   ├── borrowers_management.png
│   ├── issue_book.png
│   └── return_book.png
├── MyLibrary.sln
├── Program.cs
├── MainForm.cs
├── LoginForm.cs
├── ...
├── Database/
│   └── create_library_db.sql
└── README.md
🚀 Setup Instructions
1️⃣ Clone the Repository
bash
Copy
Edit
git clone https://github.com/your-username/mylibrary.git
2️⃣ Set Up the Database
Use the SQL script provided at Database/create_library_db.sql to create and seed the database.

Configure the connection string in App.config or MainForm.cs to match your database setup.

3️⃣ Run the Application
Open MyLibrary.sln in Visual Studio.

Build and run the project.

Use the default credentials (admin / admin123) to log in.
