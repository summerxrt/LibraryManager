
# **Library Manager**

A **C# Console Application** for managing a library system. This project provides a simple and interactive way to manage books, demonstrating **Object-Oriented Programming (OOP)** principles and using modern C# features.

---

## **Features**
1. **Add Books**: Dynamically add books to the library.
2. **Remove Books**: Remove books from the library (if not borrowed).
3. **Search Books**: Check if a book exists in the library.
4. **Borrow Books**: Borrow books, with a limit of **3 books** per user.
5. **Return Books**: Return previously borrowed books.
6. **Display Books**: View all books in the library, including their borrowing status.

---

## **Technologies Used**
- **Programming Language**: C#
- **Framework**: .NET Core
- **Development Environment**: Visual Studio / Visual Studio Code

---

## **How to Run the Application**

### **1. Prerequisites**
- Install [.NET SDK](https://dotnet.microsoft.com/download) on your machine.
- A C# IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

### **2. Clone the Repository**
```bash
git clone https://github.com/yourusername/LibraryManager.git
cd LibraryManager
```

### **3. Run the Application**
- Open the project in your IDE.
- Build and run the project:
  ```bash
  dotnet run
  ```

---

## **Sample Usage**

```plaintext
Choose an action: add, remove, search, borrow, return, display, exit
> add
Enter the title of the book to add:
> C# Programming
Book 'C# Programming' added.

Choose an action: display
Available books:
- C# Programming

Choose an action: borrow
Enter the title of the book to borrow:
> C# Programming
Book 'C# Programming' borrowed.

Choose an action: return
Enter the title of the book to return:
> C# Programming
Book 'C# Programming' returned.
```

---

## **Code Overview**

### **Core Components**
1. **Book Class**:
   Encapsulates book details (`Title` and `IsBorrowed` properties).

2. **Dynamic List**:
   Uses a `List<Book>` to store books, allowing dynamic expansion.

3. **User Actions**:
   Implements a simple menu system to manage library operations.

4. **OOP Concepts**:
   Demonstrates encapsulation, dynamic collections, and clean method organization.

---

## **Future Enhancements**
- Persist book data in a file or database for reuse across sessions.
- Add user authentication for personalized borrowing limits.
- Enhance the UI with a GUI using WPF or WinForms.
- Enable advanced search features (e.g., by author or genre).

---

## **Contributing**
Contributions are welcome! If you'd like to contribute:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-branch-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add a meaningful commit message"
   ```
4. Push your branch and create a pull request.

---

## **License**
This project is licensed under the MIT License. See the `LICENSE` file for details.

