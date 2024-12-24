# Transcript Management System

This project is a desktop application developed in **C#** with **PostgreSQL** as the database backend. It was designed to help manage student transcripts efficiently and was created during my second year of university.

## Features

- **Student Management**:
  - Add, update, and delete student records.
  - Store personal information like name, ID, department, and enrollment year.

- **Course Management**:
  - Add, update, and delete courses.
  - Manage course details such as course code, name, credit hours, and grades.

- **Transcript Generation**:
  - Automatically calculate GPAs based on entered grades.
  - Generate and display detailed transcripts for individual students.

- **Database Integration**:
  - Secure storage of all student and course data in a **PostgreSQL** database.
  - Efficient data retrieval using SQL queries.

- **Search and Filter**:
  - Search for students or courses by ID, name, or other attributes.
  - Filter and sort records for easier navigation.

## Technologies Used

- **C#:** The application was built using Windows Forms for the user interface.
- **PostgreSQL:** Database management system for storing and retrieving application data.

## How It Works

1. **Login Screen**:
   - Secure login for administrators or users to access the system.

2. **Student and Course Management**:
   - Add student records and course details.
   - Assign courses to students and input grades.

3. **Transcript Generation**:
   - View a detailed transcript with all completed courses and corresponding grades.
   - Automatically calculate semester and cumulative GPAs.

4. **Database Operations**:
   - Use SQL commands to manage data efficiently.
   - Perform CRUD (Create, Read, Update, Delete) operations seamlessly.

## How to Run

1. Install **PostgreSQL** and set up the required database schema.
2. Configure the application with the database connection string in the `appsettings.json` or configuration file.
3. Open the project in your preferred C# IDE (e.g., Visual Studio).
4. Build and run the application.
5. Log in using the provided credentials or create a new user to start managing records.

## Future Improvements

- Add support for more detailed analytics, such as trends in GPA.
- Implement role-based access control for administrators and students.
- Develop a web-based version for broader accessibility.

## License

This project is free to use and modify for educational purposes. Contributions are welcome!
