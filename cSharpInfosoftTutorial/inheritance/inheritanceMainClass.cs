using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.inheritance;

class inheritanceMainClass
{
    public static void Main()
    {
        // base class (1st heirarchy)
        /* when base class makes a constructor, all derived or inheriting class will also require that results into
         * constructor overriding */
        heroName hero1 = new heroName("Storm Spirit", "Raijin Thunderkeg");
        hero1.displayHeroNameData();
        //hero1.overridenHeroName();

        // derived class (2nd heirarchy)
        basicStats hero2 = new basicStats("Alchemist", "Razzil Darkbrew", 5, 3, 2);
        //hero2.displayHeroNameData();
        //hero2.displayHeroBasicStats();
        hero2.overridenHeroName();

        // derived classes (3rd heirarchy)
        aghanimStatus hero3 = new aghanimStatus("Gyrocopter", "Aurel Vlaicu", 2, 5, 3, false, true);
        //hero3.displayHeroNameData();
        //hero3.displayHeroBasicStats();
        hero3.displayHeroAghanimStatus();

        facetOption hero4 = new facetOption("Timbersaw", "Rizzrack, Goblin Shredder", 4, 3, 3, false);
        //hero4.displayHeroNameData();
        //hero4.displayHeroBasicStats();
        hero4.displayHeroFacet();
    }
}

class heroName
{
    public string name { get; set; }
    public string otherName { get; set; }

    public heroName(string name, string otherName)
    {
        this.name = name;
        this.otherName = otherName;
    }
    // all inheriting class can use the functions below
    public void displayHeroNameData()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("HERO NAME ");
        Console.WriteLine("Name      : " + name);
        Console.WriteLine("Other Name: " + otherName + "\n");

    }

    public void overridenHeroName()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("HERO NAME ");
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Other Name  : " + otherName);
    }
}
