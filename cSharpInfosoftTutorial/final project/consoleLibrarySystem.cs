using cSharpInfosoftTutorial.collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.final_project
{
    class consoleLibrarySystem
    {
        public static void Main()
        {
            Library library = new Library();
            library.AddBook(new Book("Art of War", "Sun Tzu"));
            library.AddBook(new Book("laws of Human Nature", "Robert Greene"));
            library.AddBook(new Book("Thus Spoke Zarathustra", "Friedrich Wilhelm Nietzsche"));
            library.AddBook(new Book("The Brothers Karamazov", "Fyodor Mikhailovich Dostoevsky"));
            library.AddBook(new Book("The Nameless Monster", "Emil Sherbet"));
            
            Console.WriteLine("\n");
            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine("Console Library System");
                Console.WriteLine("========================================");
                Console.WriteLine("[1] View Available Book/s");
                Console.WriteLine("[2] View Borrowed Book/s");
                Console.WriteLine("[3] Add New Book");
                Console.WriteLine("[4] Return");
                Console.WriteLine("[5] Borrow");
                Console.WriteLine("[0] Exit");
                
                Console.Write("\nOption: ");
                int option;

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            library.ViewAvailableBooks();
                            break;
                        case 2:
                            library.ViewBorrowedBooks();
                            break;
                        case 3:
                            ProcessBooks.AddNewBook(library);
                            break;
                        case 4:
                            ProcessBooks.ReturnBook(library);
                            break;
                        case 5:
                            ProcessBooks.BorrowBook(library);
                            break;
                        case 0:
                            loop = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid option selected! Use the given option. Please try again.");
                            break;
                    }
                } 
                else
                {
                    Console.WriteLine("\nInvalid option input! Use the indicated numeric character. Please try again.\n");
                }
            }
        }
    }
}
