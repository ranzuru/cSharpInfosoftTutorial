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
        private List<Borrower> borrowers = new List<Borrower>();
        
        public static bool availableBooks = false;

        public void AddBook(Book book)
        {
            int key = library.Count;
            key++;
            library.Add(key, book);
            Console.WriteLine("Added Book");
            Console.WriteLine("============================");
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
        }

        public void ViewAvailableBooks()
        {
            Console.WriteLine("Available Book/s Information");
            Console.WriteLine("============================");
            foreach (var book in library.Values)
            {
                string status;
                if (book.IsBorrowed == false)
                {
                    availableBooks = true;
                    status = "Available";
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
            Console.WriteLine("Borrowed Book/s Information");
            Console.WriteLine("============================");
            foreach (var book in library.Values)
            {
                string status;
                if (book.IsBorrowed == true)
                {
                    availableBooks = true;
                    status = "Borrowed";
                    Console.WriteLine("Title : " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Status: " + status);
                    Console.WriteLine("---------\n");
                }
                
            }
            if (availableBooks) Console.WriteLine("No Borrowed Books.\n");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }

        public void BorrowBook(int BookId, string fullName, string email, string mobile)
        {
            if (library.ContainsKey(BookId))
            {
                if (library[BookId].IsBorrowed)
                {
                    throw new Exception("Book is currently borrowed.");
                }
                else
                {
                    library[BookId].IsBorrowed = true;

                    var borrower = new Borrower(fullName, email, mobile);
                    borrowers.Add(borrower);

                    Console.WriteLine("Borrowed Book");
                    Console.WriteLine("============================");
                    Console.WriteLine("Title : " + library[BookId].Title);
                    Console.WriteLine("Author: " + library[BookId].Author);
                }
            }
            else
            {
                throw new Exception("Book not found.");
            }
        }

        public void ReturnBook(int BookId)
        {
            if (library.ContainsKey(BookId))
            {
                if (!library[BookId].IsBorrowed)
                {
                    throw new Exception("Borrowed book not yet returned.");
                }
                else
                {
                    library[BookId].IsBorrowed = false;
                    Console.WriteLine("Returned Book");
                    Console.WriteLine("============================");
                    Console.WriteLine("Title : " + library[BookId].Title);
                    Console.WriteLine("Author: " + library[BookId].Author);
                }
            }
            else
            {
                throw new Exception("Book not found.");
            }
        }
    }
}
