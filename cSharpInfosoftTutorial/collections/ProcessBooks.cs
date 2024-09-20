using cSharpInfosoftTutorial.final_project;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.collections
{
    class ProcessBooks
    {
        private static Library library = new Library();
        private static int id;
        public static void AddNewBook()
        {
            
            Console.Write("Book: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            library.AddBook(new Book(title, author));
            Console.WriteLine("Book added successfully.");
        }

        public static void ReturnBook()
        {
            Console.Write("Book ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Borrower Full Name: ");
            string fullName = Console.ReadLine();
            Console.Write("Borrower Email: ");
            string email = Console.ReadLine();
            Console.Write("Borrower Mobile: ");
            string mobile = Console.ReadLine();

            library.BorrowBook(id, fullName, email, mobile);
        }

        public static void BorrowBook()
        {
            Console.Write("Book ID: ");
            id = int.Parse(Console.ReadLine());
            library.ReturnBook(id);
        }
    }
}
