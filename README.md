# Examnieon

## Overview
Examnieon is an exam management system designed for lecturers and students to create, manage, and analyze exams easily. 

The project is developed using **C# Windows Forms**, with **Excel files** as the database for storing users and exams.

## Features
- User authentication (Login/Sign-Up) using Excel as the backend.
- Lecturer functionalities:
  - Create and manage exams.
  - View student performance analysis.
- Student functionalities:
  - Select and take exams based on subject and difficulty.
- Clear and intuitive UI design with easy navigation.

## Installation
1. Clone the repository:  
   ```bash
   git clone https://github.com/your-username/examnieon.git
2. Open the project in Visual Studio 2022.

3. Ensure OfficeOpenXml NuGet package is installed:

Install-Package EPPlus


Build and run the project.

## Usage: 

Open LoginForm.cs to log in or create a new account.

Use the main interface to access functionalities:

## Overview

Create Exam

Open Student Analysis

Exams and users are stored in DATABASE.xlsx and USERS.xlsx.

## Project Structure

LoginForm.cs – handles user authentication.

MainForm.cs – main interface for navigation and functionalities.

CreateExamForm.cs – form to create exams and view exam questions.

DATABASE.xlsx – stores exam data.

USERS.xlsx – stores user data.

Contributing

Fork the repository.

Create a new branch (git checkout -b feature/YourFeature).

Make your changes and commit (git commit -m "Add some feature").

Push to the branch (git push origin feature/YourFeature).

Open a Pull Request.
