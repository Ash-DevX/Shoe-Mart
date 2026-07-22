# Shoe Mart Management System

A desktop-based **Shoe Mart Management System** developed using **C# Windows Forms (.NET Framework)** and **Microsoft SQL Server**. This application provides an efficient way to manage users, product information, and database records through a clean and user-friendly interface.

---

# Project Overview

The **Shoe Mart Management System** is designed to simplify user and product management for a shoe store. It allows administrators to securely manage users, maintain records, and view stored information using SQL Server with stored procedures.

### Project Architecture

- Frontend – Windows Forms (C#)
- Business Logic – C#
- Backend Database – Microsoft SQL Server
- Data Access – ADO.NET
- Database Operations – Stored Procedures

---

# Technologies Used

| Technology | Description |
|------------|-------------|
| Language | C# |
| Framework | .NET Framework 4.8.1 |
| IDE | Microsoft Visual Studio |
| Database | Microsoft SQL Server |
| UI | Windows Forms |
| Data Access | ADO.NET |
| SQL | Stored Procedures |
| Version Control | Git & GitHub |

---

# Features

## User Management

- Add New User
- View User Details
- Search User
- Update User Information
- Delete User

---

## Product Management

- Add Shoe Products
- Update Product Details
- Delete Products
- Search Products
- View Product List

---

## Dashboard

- Home Page
- Navigation Between Forms
- User-Friendly Interface
- Responsive Layout

---

## Database Management

- SQL Server Integration
- Stored Procedure Execution
- Data Validation
- Secure Database Connectivity

---

# Project Structure

```
Shoe Mart/
│
├── Forms/
│   ├── Login
│   ├── Home
│   ├── NewUserPage
│   ├── ViewPage
│   ├── Product
│
├── Database/
│   ├── ShoeMart.sql
│   ├── Tables
│   ├── Stored Procedures
│
├── Resources/
│
├── App.config
│
└── README.md
```

---

# Database

### Database Name

```
Shoemart
```

### Main Tables

- user_tbl
- product_tbl
- category_tbl

### Stored Procedures

- sp_Login
- sp_Add
- sp_Update
- sp_Delete
- sp_View
- sp_Search
- sp_Product

---

# Frontend

The application is built using **Windows Forms** with a clean and modern desktop interface.

### Frontend Features

- Login Screen
- Add User Page
- View User Page
- Product Management Forms
- DataGridView
- TextBox Validation
- Navigation Buttons
- Minimize, Maximize & Exit Controls

---

# Backend Logic

The application logic is implemented using **C#**.

### Main Functionalities

- User Authentication
- CRUD Operations
- SQL Server Connectivity
- Stored Procedure Execution
- Exception Handling
- Data Validation
- Form Navigation
- Record Management

---

# Microsoft SQL Server

Microsoft SQL Server is used to securely store all application data.

### Database Operations

- INSERT
- UPDATE
- DELETE
- SELECT
- SEARCH
- VIEW

All database operations are executed using **Stored Procedures**.

---

# Application Workflow

```
Login
   │
   ▼
Dashboard
   │
   ├──────────────┐
   ▼              ▼
User          Products
   │              │
   ▼              ▼
Add/Edit      Add/Edit
   │              │
   ▼              ▼
View Data   Manage Products
   │
   ▼
SQL Server Database
```

---

# Screens Included

- Login Page
- Home Dashboard
- Add User
- View Users
- Product Management
- Search Records

---

# Requirements

- Windows 10 / 11
- Visual Studio 2022
- .NET Framework 4.8.1
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

---

# Installation

## Clone Repository

```bash
git clone https://github.com/your-username/Shoe-Mart.git
```

### Open the Project

1. Open **Shoe Mart.sln** in Visual Studio.
2. Restore required packages.
3. Open SQL Server Management Studio.
4. Create the database:

```sql
CREATE DATABASE Shoemart;
```

5. Execute all SQL scripts for tables and stored procedures.
6. Update the connection string inside **App.config**.

Example:

```xml
<connectionStrings>
    <add name="ShoemartConnection"
         connectionString="Data Source=YOUR_SERVER;
         Initial Catalog=Shoemart;
         Integrated Security=True;
         TrustServerCertificate=True"/>
</connectionStrings>
```

7. Build and run the application.

---

# Future Improvements

- Customer Management
- Billing System
- Sales Dashboard
- Inventory Management
- Barcode Scanner
- Stock Management
- Sales Reports
- PDF Invoice Generation
- Email Notifications
- Role-Based Authentication

---

# Learning Outcomes

This project demonstrates practical knowledge of:

- C# Programming
- Object-Oriented Programming (OOP)
- Windows Forms Development
- Microsoft SQL Server
- ADO.NET
- CRUD Operations
- Stored Procedures
- Exception Handling
- Database Connectivity
- Git & GitHub

---

LikedIn:
(https://www.linkedin.com/in/ashwin-e-a7699b308/)
