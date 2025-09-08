# FirstWinForm – C# WinForms Demo Project

## 📌 Overview
This is a Windows Forms (.NET) application built in **C#** demonstrating multiple features such as:
- CRUD operations with PostgreSQL
- File handling (XML, CSV, PDF)
- Login system with email notifications
- Data transfer between list boxes
- A simple calculator

The project is intended as a **learning/demo application** to showcase different functionalities in WinForms.

---

## 🚀 Features

### 1. CRUDdemo (Book Management)
- Manage books with **Create, Read, Update, Delete** operations.
- PostgreSQL database integration using **Npgsql**.
- Import/Export data in:
  - **XML**
  - **CSV**
  - **PDF** (via iText7 library)
- UI customization (change font & colors of DataGridView).

### 2. DataTransfer
- Transfer items between two list boxes.
- Supports multi-selection.
- Import/export list items from/to text files.
- Auto-convert text to **uppercase**.

### 3. CalcDemo
- A simple calculator with operations:
  - Addition
  - Subtraction
  - Multiplication
  - Division (with divide-by-zero handling).

### 4. LoginForm
- Login screen connected to PostgreSQL database (`t_signup` table).
- Email validation and error messages.
- Password visibility toggle.
- **Email notifications via Gmail SMTP:**
  - Successful login
  - Suspicious login attempts
  - Forgot password recovery

---

## 🛠️ Tech Stack
- **Language:** C# (.NET 6/7 WinForms)
- **Database:** PostgreSQL
- **Libraries:**
  - [Npgsql](https://www.npgsql.org/) – PostgreSQL driver
  - [iText7](https://itextpdf.com/) – PDF generation
- **UI:** Windows Forms

---

## ⚙️ Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/devenmitaliya/FirstWinForm.git
