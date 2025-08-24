# Payroll Console Application

A simple **Payroll Management Console Application** built in **C#**.  
This project demonstrates basic object-oriented programming concepts, file handling, and user interaction in a console environment.  

---

## 📌 Features
- Employee records (Name, Position, Hours Worked, Rate per Hour, Overtime, Allowances)
- Calculate employee salary (including overtime if applicable)
- Display employee payroll details in text files
- Save and load payroll data (saved data can be accesed through the file explorer)
- Simple, lightweight, and beginner-friendly

---

## 🛠️ Technologies Used
- **C#** (.NET)
- Console Application
- Object-Oriented Programming (OOP)

---

## 🚀 Getting Started

### Prerequisites
Make sure you have the following installed:
- [Visual Studio](https://visualstudio.microsoft.com/) (recommended) or any C# IDE
- [.NET SDK](https://dotnet.microsoft.com/download)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Andres2295/CSProject.git
Open the project in Visual Studio (or your preferred IDE).

Build and run the application.

---

## 💻 Usage

# *Note: Before starting the application make sure to create a text file named "staff.txt" with this data:

---
```
Yvone, Manager
Peter, Manager
John, Admin
Carol, Admin
```
---

Save the text file inside the buid folder where the .exe is found, it should look something like this:

> \CSProject\CSProject\bin\Debug\net8.0

---

### Launch the application.

### Set a period

> Set the year and month for the payroll period

### Calculate payroll

> It will ask for the hours worked by each employee and they will be calculated accordingly to their respective wages

### The program will exit

### To see the records go to the build folder and you will notice text files created with each staff member name with the record data saved in them

---

## 📂 Project Structure
CSProject/

│── Program.cs    # Entry point of the application

│── Staff.cs      # Employee class with properties and methods

│── Admin.cs      # Admin class with properties and methods, handles payroll calculations for Admins

|── Manager.cs    # Manager class with properties and methods, handles payroll calculations for Managers

|── FileReader.cs # Reads the staff.txt file to upload startup data for the app

|── PaySlip.cs    # Creates a pay slip for each staff member in the staff.txt file

|── summary.txt   # Contains the record of employees with less than 10 hours

|── staff.txt     # Contains the staff name and possition

│── README.md     # Project documentation

---

## 🤝 Contributing

Contributions are welcome! Feel free to fork this repository and submit a pull request with improvements.

---

## 📜 License

This project is licensed under the MIT License.
See the [LICENSE](https://github.com/Andres2295/CSProject_SimplePayroll/blob/master/LICENSE)
file for details.

---
