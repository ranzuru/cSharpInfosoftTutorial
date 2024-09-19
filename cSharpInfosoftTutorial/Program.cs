using cSharpInfosoftTutorial;
using cSharpInfosoftTutorial.loops;
using cSharpInfosoftTutorial.oopBasics;
using cSharpInfosoftTutorial.inheritance;
using cSharpInfosoftTutorial.encapsulation;
using cSharpInfosoftTutorial.polymorphism;
using cSharpInfosoftTutorial.abstraction;
using cSharpInfosoftTutorial.collections;
using cSharpInfosoftTutorial.events_and_delegates;
using cSharpInfosoftTutorial.async_await_task;

class Program
{
    public static void Main()
    {
        bool loop = true;
        while (loop)
        {
            
            Console.WriteLine("C# PROGRAMMING LESSON OUTPUT");
            Console.WriteLine("==========================================================");
            Console.WriteLine("[1] Introduction to C#");
            Console.WriteLine("[2] Variables and Data Types");
            Console.WriteLine("[3] Basic Input and Output");
            Console.WriteLine("[4] Operators and Expressions");
            Console.WriteLine("[5] Conditional Statements");
            Console.WriteLine("[6] Switch Statements");
            Console.WriteLine("[7.1] Loops - For Loop");
            Console.WriteLine("[7.2] Loops - While Loop");
            Console.WriteLine("[8] Arrays (Collections)");
            Console.WriteLine("[9] Functions");
            Console.WriteLine("[10.1] Object-Oriented Programming (OOP) - Classes & Objects, and Cnstructors");
            Console.WriteLine("[10.2] Object-Oriented Programming (OOP) - Object Methods");
            Console.WriteLine("[11] Inheritance");
            Console.WriteLine("[12] Encapsulation");
            Console.WriteLine("[13] Polymorphism");
            Console.WriteLine("[14] Abstraction");
            Console.WriteLine("[15] Exception Handling");
            Console.WriteLine("[16.1] Collections - List");
            Console.WriteLine("[16.2] Collections - Dictionary");
            Console.WriteLine("[17.1] Delegates and Events - Delegates");
            Console.WriteLine("[17.2] Delegates and Events - Delegates and Events");
            Console.WriteLine("[18] Asynchronous Programming");
            Console.WriteLine("[19] Working with Strings");
            Console.WriteLine("[0] Exit");
            Console.Write("\nSelect a Lesson: ");
            
            double selection;
            
            if (double.TryParse(Console.ReadLine(), out selection))
            {
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        
                        introductionClass.Main();
                        break;
                    case 2:
                        variabesDatatypesClass.Main();
                        break;
                    case 3:
                        basicInputOutputClass.Main();
                        break;
                    case 4:
                        operatorsExpressionsClass.Main();
                        break;
                    case 5:
                        conditionalStatementClass.Main();
                        break;
                    case 6:
                        switchClass.Main();
                        break;

                    // LOOPS ====================
                    case 7.1:
                        forLoopClass.Main();
                        break;
                    case 7.2:
                        whileLoopClass.Main();
                        break;

                    case 9:
                        functionClass.Main();
                        break;

                    // OOP BASICS ===============
                    case 10.1:
                        oopBasics1and2Class.Main();
                        break;
                    case 10.2:
                        oopBasics3Class.Main();
                        break;

                    // OOP =======================
                    case 11:
                        inheritanceMainClass.Main();
                        break;
                    case 12:
                        encapsulationMainClass.Main();
                        break;
                    case 13:
                        polymorphismMainClass.Main();
                        break;
                    case 14:
                        abstractionMainClass.Main();
                        break;

                    case 15:
                        exceptionHandlingClass.Main();
                        break;

                    // COLLECTIONS ===============
                    case 8:
                        arraysClass.Main();
                        break;
                    case 16.1:
                        listClass.Main();
                        break;
                    case 16.2:
                        dictionaryClass.Main();
                        break;

                    // EVENTS AND DELEGATES
                    case 17.1:
                        delegatesClass.Main();
                        break;
                    case 17.2:
                        eventAndDelegateClass.Main();
                        break;

                    case 18:
                        asyncAwaitTaskClass.Main();
                        break;
                    case 19:
                        workingWithStringClass.Main();
                        break;

                    case 0:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid lesson section.");
                        break;
                }
            }
            else Console.WriteLine("\nInvalid input. Please enter a valid number.\n");

            if (selection != 0)
            {
                Console.WriteLine("\n\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
