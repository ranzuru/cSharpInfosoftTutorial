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
        public static void AddNewBook(Library library)
        {
            try
            {
                Console.Write("\nBook: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                library.AddBook(new Book(title, author));
                Console.WriteLine("Book added successfully.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ReturnBook(Library library)
        {
            try
            {
                Console.Write("\nBook ID: ");
                id = int.Parse(Console.ReadLine());
                library.ReturnBook(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }

        public static void BorrowBook(Library library)
        {
            try
            {
                Console.Write("\nBook ID: ");
                id = int.Parse(Console.ReadLine());
                library.BorrowBook(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
    }
}
