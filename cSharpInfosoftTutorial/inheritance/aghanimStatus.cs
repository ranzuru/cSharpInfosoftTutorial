using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.inheritance
{
    class aghanimStatus : basicStats
    {
        public bool shard { get; set; }
        public bool scepter { get; set; }
        public string shardStatus, scepterStatus;
        // overridden constructor
        public aghanimStatus(string name, string otherName, int strength, int agility, int intelligence, bool shard, bool scepter) : base(name, otherName, strength, agility, intelligence)
        {
            this.shard = shard;
            this.scepter = scepter;

            if (shard == true) shardStatus = "Activated";
            else shardStatus = "Inactivated";
            if (scepter == true) scepterStatus = "Activated";
            else shardStatus = "Inactivated";
        }
        public void displayHeroAghanimStatus()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("HERO NAME with BASIC STATISTICS and AGHANIM STATUS");
            Console.WriteLine("Name           : " + name);
            Console.WriteLine("Other Name     : " + otherName);
            Console.WriteLine("Strength       : " + strength);
            Console.WriteLine("Agility        : " + agility);
            Console.WriteLine("Intelligence   : " + intelligence);
            Console.WriteLine("Aghanim Shard  : " + shardStatus);
            Console.WriteLine("Aghanim Scepter: " + scepterStatus + "\n");
            
        }
    }
}
