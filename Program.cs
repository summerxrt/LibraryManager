using System;
using System.Collections.Generic;

class LibraryManager
{
    class Book
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title)
        {
            Title = title;
            IsBorrowed = false;
        }
    }

    static List<Book> books = new List<Book>();
    static int borrowedCount = 0;
    const int maxBorrowedBooks = 3;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an action: add, remove, search, borrow, return, display, exit");
            string? action = Console.ReadLine()?.ToLower();

            switch (action)
            {
                case "add":
                    AddBook();
                    break;
                case "remove":
                    RemoveBook();
                    break;
                case "search":
                    SearchBook();
                    break;
                case "borrow":
                    if (borrowedCount < maxBorrowedBooks)
                    {
                        BorrowBook();
                    }
                    else
                    {
                        Console.WriteLine("You have reached the borrowing limit of 3 books.");
                    }
                    break;
                case "return":
                    ReturnBook();
                    break;
                case "display":
                    DisplayBooks();
                    break;
                case "exit":
                    Console.WriteLine("Exiting the Library Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'borrow', 'return', 'display', or 'exit'.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("Enter the title of the book to add:");
        string? newBookTitle = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newBookTitle))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        books.Add(new Book(newBookTitle));
        Console.WriteLine($"Book '{newBookTitle}' added to the library.");
    }

    static void RemoveBook()
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string? removeBookTitle = Console.ReadLine();

        var book = books.Find(b => b.Title.Equals(removeBookTitle, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found in the library.");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine($"Book '{removeBookTitle}' is currently borrowed and cannot be removed.");
            return;
        }

        books.Remove(book);
        Console.WriteLine($"Book '{removeBookTitle}' removed from the library.");
    }

    static void SearchBook()
    {
        Console.WriteLine("Enter the title of the book to search:");
        string? searchBookTitle = Console.ReadLine();

        var book = books.Find(b => b.Title.Equals(searchBookTitle, StringComparison.OrdinalIgnoreCase));

        if (book != null)
        {
            Console.WriteLine($"Book '{searchBookTitle}' is available in the library.");
        }
        else
        {
            Console.WriteLine($"Book '{searchBookTitle}' is not in the library.");
        }
    }

    static void BorrowBook()
    {
        Console.WriteLine("Enter the title of the book to borrow:");
        string? borrowBookTitle = Console.ReadLine();

        var book = books.Find(b => b.Title.Equals(borrowBookTitle, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found in the library.");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine($"Book '{borrowBookTitle}' is already borrowed.");
            return;
        }

        book.IsBorrowed = true;
        borrowedCount++;
        Console.WriteLine($"Book '{borrowBookTitle}' borrowed successfully.");
    }

    static void ReturnBook()
    {
        Console.WriteLine("Enter the title of the book to return:");
        string? returnBookTitle = Console.ReadLine();

        var book = books.Find(b => b.Title.Equals(returnBookTitle, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found in the library.");
            return;
        }

        if (!book.IsBorrowed)
        {
            Console.WriteLine($"Book '{returnBookTitle}' is not currently borrowed.");
            return;
        }

        book.IsBorrowed = false;
        borrowedCount--;
        Console.WriteLine($"Book '{returnBookTitle}' returned successfully.");
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine($"- {book.Title} {(book.IsBorrowed ? "(Borrowed)" : "")}");
        }
    }
}
