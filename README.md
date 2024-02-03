UserHub
Description
UserHub is a user management system designed for efficient user registration and data management. This project is built using .NET Forms and SQL Server.

Features
User Registration: Allows users to register with their name, email, and date of registration.
Database Management: Utilizes SQL Server for robust data storage.
Intuitive Interface: Provides a user-friendly interface built with .NET Forms for seamless user interaction.
Getting Started
Prerequisites:

.NET Framework installed (version X.X.X or later).
SQL Server installed and configured.
Clone the Repository:

bash
Copy code
git clone https://github.com/juliocs50/UserHub.git
Database Setup:

Open SQL Server Management Studio.
Execute the following SQL commands to set up the database:
sql
Copy code
-- Create the Database
CREATE DATABASE UserHub;

-- Use the Database
USE UserHub;

-- Create the Contacts Table
CREATE TABLE Contacts (
   ID INT PRIMARY KEY IDENTITY(1,1),
   Nome NVARCHAR(100),
   Email NVARCHAR(100),
   DataCadastro DATETIME
);
Build and Run:

Open the solution in Visual Studio.
Build and run the project.
Usage
User Registration:

Access the application and register users with their name, email, and date of registration.
Database Interaction:

The system uses the SQL Server database to store and manage user data.
UserHub Features:

Explore the user-friendly interface built with .NET Forms for efficient user management.
Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or create a pull request.

License
This project is licensed under the MIT License.
