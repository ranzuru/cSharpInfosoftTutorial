using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.collections
{
    class arraysClass
    {
        public static void Main()
        {
            // {value}, value can be a collection
            // fixed size collection (for list reference)
            string[] movie = {"Inception", 
                              "Reservoir Dogs", 
                              "The Departed",
                              "The Usual Suspects",
                              "Seven"};
            string[] director = { "Christopher Nolan", 
                                  "Quentin Tarantino", 
                                  "Martin Scorsese",
                                  "Bryan Singer",
                                  "David Fincher"};
            string[] plot = { 
                "Dom Cobb (Leonardo DiCaprio) is a thief with the rare ability to enter people's dreams and steal their secrets from their subconscious. His skill has made him a hot commodity in the world of corporate espionage but has also cost him everything he loves. Cobb gets a chance at redemption when he is offered a seemingly impossible task: Plant an idea in someone's mind. If he succeeds, it will be the perfect crime, but a dangerous enemy anticipates Cobb's every move.",
                "Six criminals with pseudonyms, and each strangers to one another, are hired to carry out a robbery. The heist is ambushed by police and the gang are forced to shoot their way out. At their warehouse rendezvous, the survivors, realising that they were set up, try to find the traitor in their midst.",
                "South Boston cop Billy Costigan (Leonardo DiCaprio) goes under cover to infiltrate the organization of gangland chief Frank Costello (Jack Nicholson). As Billy gains the mobster's trust, a career criminal named Colin Sullivan (Matt Damon) infiltrates the police department and reports on its activities to his syndicate bosses. When both organizations learn they have a mole in their midst, Billy and Colin must figure out each other's identities to save their own lives.",
                "\"The greatest trick the devil ever pulled was convincing the world he didn't exist,\" says con man Kint (Kevin Spacey), drawing a comparison to the most enigmatic criminal of all time, Keyser Soze. Kint attempts to convince the feds that the mythic crime lord not only exists, but is also responsible for drawing Kint and his four partners into a multi-million dollar heist that ended with an explosion in San Pedro Harbor - leaving few survivors.",
                "When retiring police Detective William Somerset (Morgan Freeman) tackles a final case with the aid of newly transferred David Mills (Brad Pitt), they discover a number of elaborate and grizzly murders. They soon realize they are dealing with a serial killer (Kevin Spacey) who is targeting people he thinks represent one of the seven deadly sins. Somerset also befriends Mills' wife, Tracy (Gwyneth Paltrow), who is pregnant and afraid to raise her child in the crime-riddled city."};

            Console.WriteLine("IMBD\'s Mystery Top 5 Movies of 80s - 90s Directory");
            Console.Write("\nEnter a number from 1 to 5, 1 as the highest.");
            Console.Write("\n\nTop: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMovie Information");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Name    : " + movie[choice]);
            Console.WriteLine("Director: " + director[choice]);
            Console.WriteLine("Plot    : \n" + plot[choice]);
        }
    }
}
