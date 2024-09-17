using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.inheritance
{
    class basicStats : heroName
    {
        public int strength { get; set; }
        public int agility { get; set; }
        public int intelligence { get; set; }
        // overridden constructor
        public basicStats(string name, string otherName, int strength, int agility, int intelligence) : base(name, otherName)
        {
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
        }
        // this class and it inheriting class (agha and facet) can use the functions below
        public void displayHeroBasicStats()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("HERO NAME with BASIC STATISTICS");
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Other Name  : " + otherName);
            Console.WriteLine("Strength    : " + strength);
            Console.WriteLine("Agility     : " + agility);
            Console.WriteLine("Intelligence: " + intelligence + "\n");
            
        }
        // method overriding retains the functionility from the base class
        public void overridenHeroName()
        {
            base.overridenHeroName();
            Console.WriteLine("Strength    : " + strength);
            Console.WriteLine("Agility     : " + agility);
            Console.WriteLine("Intelligence: " + intelligence + "\n"); ;
        }
    }
}
