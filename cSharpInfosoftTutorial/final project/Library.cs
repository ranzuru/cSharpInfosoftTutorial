using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace cSharpInfosoftTutorial.final_project
{
    class Library
    {
        private Dictionary<int, Book> library = new Dictionary<int, Book>();
        private int nextId = 1;
        public void AddBook(Book book)
        {
            book.Id = nextId;
            library.Add(book.Id, book);
            Console.WriteLine("\nAdded Book");
            Console.WriteLine("============================");
            Console.WriteLine("ID    : " + book.Id);
            Console.WriteLine("Title : " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            nextId++;
        }

        public void ViewAvailableBooks()
        {
            Console.WriteLine("\nAvailable Book/s Information");
            Console.WriteLine("============================");
            bool availableBooks = false;
            foreach (var book in library.Values)
            {
                string status;
                if (book.IsBorrowed == false)
                {
                    availableBooks = true;
                    status = "Available";
                    Console.WriteLine("ID    : " + book.Id);
                    Console.WriteLine("Title : " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Status: " + status);
                    Console.WriteLine("---------\n");
                } 
            }
            if (!availableBooks) Console.WriteLine("No Available Books.\n");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }
        public void ViewBorrowedBooks()
        {
            Console.WriteLine("\nBorrowed Book/s Information");
            Console.WriteLine("============================");
            bool borrowedBooks = true;
            foreach (var book in library.Values)
            {
                string status;
                if (book.IsBorrowed == true)
                {
                    borrowedBooks = false;
                    status = "Borrowed";
                    Console.WriteLine("ID    : " + book.Id);
                    Console.WriteLine("Title : " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Status: " + status);
                    Console.WriteLine("---------\n");
                }
                
            }
            if (borrowedBooks) Console.WriteLine("No Borrowed Books.\n");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }

        public void BorrowBook(int BookId)
        {
            if (library.ContainsKey(BookId))
            {
                if (library[BookId].IsBorrowed)
                {
                    Console.WriteLine("\n" + "Book is currently borrowed." + "\n");
                }
                else
                {
                    library[BookId].IsBorrowed = true;

                    Console.WriteLine("\nBorrowed Book");
                    Console.WriteLine("============================");
                    Console.WriteLine("ID    : " + library[BookId].Id);
                    Console.WriteLine("Title : " + library[BookId].Title);
                    Console.WriteLine("Author: " + library[BookId].Author + "\n");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ReturnBook(int BookId)
        {
            if (library.ContainsKey(BookId))
            {
                if (!library[BookId].IsBorrowed)
                {
                    Console.WriteLine("\n" + "Book is not borrowed." + "\n");
                }
                else
                {
                    library[BookId].IsBorrowed = false;
                    Console.WriteLine("\nReturned Book");
                    Console.WriteLine("============================");
                    Console.WriteLine("ID    : " + library[BookId].Id);
                    Console.WriteLine("Title : " + library[BookId].Title);
                    Console.WriteLine("Author: " + library[BookId].Author + "\n");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
