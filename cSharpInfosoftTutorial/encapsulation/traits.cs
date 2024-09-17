using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.encapsulation
{
    class characterTraits
    {
        // private (modifier) attribute - accessible within the same class
        // FIELDS
        private int strength, dexterity, intelligence;

        // PROPERTIES
        // allowing the private attrib. to be accessible outside from its class
        // you can make a property where it returns a concatenated value, but makes it a read-only
        public int Str
        {
            // read (removing set is making this property write-only)
            get { return strength; }
            // you apply condition/s inside to control the value
            // write (removing set is making this property read-only)
            set
            {
                strength = value;
                if (value > 85) Console.WriteLine("Eligible for Warrior Class!\n");
            }
        }
        public int Dex
        {
            get { return dexterity; }
            set
            {
                dexterity = value;
                if (value > 85) Console.WriteLine("Eligible for Ranger Class!\n");
            }
        }
        public int Intl
        {
            get { return intelligence; }
            set
            {
                intelligence = value;
                if (value > 85) Console.WriteLine("Eligible for Mage Class!\n");
            }
        }
        // short-hands method of getter and setter: public int STR { get; set; }, also known as automatic propery
        // can remove the set, but not get
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }

        public characterTraits(int strength, int dexterity, int intelligence, int charisma, int constitution, int wisdom)
        {
            // not necessary to use this. since those private attrib. have been encapsulated
            Str = strength;
            Dex = dexterity;
            Intl = intelligence;
            // uses this. since it has been an automated property
            this.Charisma = charisma;
            this.Constitution = constitution;
            this.Wisdom = wisdom;
        }
    }
}
