using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class switchClass
    {
        public static void Main()
        {
            Console.Write("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            string monthName;

            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "";
                    Console.WriteLine("\nInvalid Month Input");
                    if (day > 31) Console.WriteLine("Invalid Day Input");
                    break;
            }

            if (month == 2)
            {
                if (day > 29) Console.WriteLine("\nThe month of " + monthName + "[" + month + "] has only 29 days");
                else Console.WriteLine("\n" + monthName + " " + day + ", " + year);
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30) Console.WriteLine("\nThe month of " + monthName + "[" + month + "] has only 30 days");
                else Console.WriteLine("\n" + monthName + " " + day + ", " + year);                  
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 31) Console.WriteLine("\nThe month of " + monthName + "[" + month + "] has only 31 days");
                else Console.WriteLine("\n" + monthName + " " + day + ", " + year);
            }
        }
    }
}
