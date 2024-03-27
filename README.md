# Exams API
The ExamsApp API is a RESTful API that is designed to effortlessly streamline exam creation and taking.<br>
the API provides users of type Teacher with the tools to create, edit, update, and delete exams, as well as getting statistics of each exam.<br>
They have a dashboard where they can manage user details, see the course they teach in, the students enrolled, and well as manage their exams.<br>
Students are able to manage user and course details, see upcoming exams, tale exams, and get results instantly, including failed questions with correct answers!<br>
Admin can manage users and courses, with the tools to create, edit, update, and delete users and courses.<br>
all CRUD operations are done against a SQL Server database.<br>
the frontend application can be found at <a>https://github.com/LeahMerzel/Exams-App-Client-Side/tree/master</a>.

## Table of Contents

[Installation](#installation) <br>
[usage](#usage) <br>
[Features](#features) <br>
[Code Features](#code-features) <br>
[Troubleshooting](#troubleshooting)

## Installation

To install the ExamsApp API, follow these steps:

- Clone the repository to your local machine using the following command:

```bash
[git clone https://github.com/LeahMerzel/Exams-App-C-.Net-Server.git](https://github.com/LeahMerzel/Exams-App-C-.Net-Server.git)
```
- Open the solution file Exams App C# .Net Server.sln in Visual Studio.
- Build the solution to restore NuGet packages and compile the project.
- Create a new Microsoft SQL Server database to store the application data.
- Open the file appsettings.json located in the ExamsApp project folder and modify the following connection string with your own Microsoft SQL Server database connection string:
```bash
"ConnectionStrings": {
  "project": "Server=<your-server-name>;Database=<your-database-name>;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
- Open the Package Manager Console in Visual Studio, and run the following command to create the database schema:
```bash
Update-Database
```
- Run the project in Visual Studio, The API server should now be running on your local machine & you should see Swagger Api Documentation.

## Usage

Full Api Documentation in Swagger: 

To use the API, you can send HTTP requests to the API's endpoints using a tool such as Postman or swagger.

## Features

- User begins in the app’s home page, where he chooses which type of user he is: Teacher, Student, or Admin.
- next he chooses between login and register for a new user.
- then he lands on a dashboard providing data and tools appropriate to user type.
- All dashboard provide user details and option to edit them and logout.
- Admin dashboard includes: viewing courses + ability to edit and delete, viewing users + ability to edit and delete.
- Teacher dashboard includes enrolling in a course to teach in, course details, viewing teacher’s exams + edit and delete, creating new exams, seeing statistics on exams, viewing all students.
- Student dashboard includes enrolling in a course, course details, viewing upcoming exams + option to take exam, viewing all student’s taken exams + failed questions with correct answers.


## Code Features:

- The program includes 1 project, divided into 3 folders: Data, Core, and API.
- Database is created with Entity Framework Code First.
- Data is seeded on installation.
- Queries are written in LINQ.
- Usage of Repository Pattern & implementation of dependency injection.
- Usage of a Generic Repository and Controller, used by all Repositories/ Controllers.

## Troubleshooting
If you encounter any issues when using the ExamsApp API, please refer to the project's GitHub Issues page to see if a solution has already been proposed. If not, you can open a new issue to report the problem.



