using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.inheritance
{
    class facetOption : basicStats
    {
        public bool isFacet1 { get; set; }
        public string facet;
        // overridden constructor
        public facetOption(string name, string otherName, int strength, int agility, int intelligence, bool isFacet1) : base(name, otherName, strength, agility, intelligence)
        {
            this.isFacet1 = isFacet1;

            if (isFacet1 == true) facet = "[1] Shredder";
            else facet = "[2] Twisted Chakram";
        }
        public void displayHeroFacet()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("HERO NAME with BASIC STATISTICS and FACET ABILITY");
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Other Name  : " + otherName);
            Console.WriteLine("Strength    : " + strength);
            Console.WriteLine("Agility     : " + agility);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Facet       : " + facet + "\n");

        }
    }
}
