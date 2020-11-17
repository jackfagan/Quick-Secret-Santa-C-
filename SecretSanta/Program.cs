using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to the FAGAN Secret Santa Selector");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("WOOOOOOOOOOOOOOOOOOO");
            Console.WriteLine("  __");
            Console.WriteLine(" _|_|_");
            Console.WriteLine(" (..)");
            Console.WriteLine(" (   )");
            Console.WriteLine("(     )");
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("The way this will work is that we will go from oldest to youngest and taking turns you will go up to the laptop and get your name!");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Billy - Obviously you are up first! You have 10 seconds to find a spot to shield the laptop from everyone");

            System.Threading.Thread.Sleep(10000);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");


            List<string> People = new List<string>(new string[] { "Jack", "EllenP", "EllieF", "Kane", "Billy", "Lucy", "Patsy", "Alex" });
            List<List<string>> ListOfAll = new List<List<string>>();

            List<string> Billy = new List<string>(new string[] { "Billy", "" });
            ListOfAll.Add(Billy);
            List<string> Lucy = new List<string>(new string[] { "Lucy", "" });
            ListOfAll.Add(Lucy);
            List<string> Kane = new List<string>(new string[] { "Kane", "" });
            ListOfAll.Add(Kane);
            List<string> EllieF = new List<string>(new string[] { "EllieF", "" });
            ListOfAll.Add(EllieF);
            List<string> Alex = new List<string>(new string[] { "Alex", "" });
            ListOfAll.Add(Alex);
            List<string> Patsy = new List<string>(new string[] { "Patsy", "" });
            ListOfAll.Add(Patsy);
            List<string> Jack = new List<string>(new string[] { "Jack", "" });
            ListOfAll.Add(Jack);
            List<string> EllenP = new List<string>(new string[] { "EllenP", "" });
            ListOfAll.Add(EllenP);


            foreach (var person in ListOfAll)
            {
                var Name = person.First();
                var random = new Random();
                int index = random.Next(People.Count);
                var SS = People[index];

                if (Name == "Billy" || Name == "Lucy")
                {
                    while (SS == "Billy" || SS == "Lucy")
                    {
                        random = new Random();
                        index = random.Next(People.Count);
                        SS = People[index];
                    }
                }

                if (Name == "Kane" || Name == "EllieF")
                {
                    while (SS == "Kane" || SS == "EllieF")
                    {
                        random = new Random();
                        index = random.Next(People.Count);
                        SS = People[index];
                    }
                }

                if (Name == "Alex" || Name == "Patsy")
                {
                    while (SS == "Alex" || SS == "Patsy")
                    {
                        random = new Random();
                        index = random.Next(People.Count);
                        SS = People[index];
                    }
                }

                if (Name == "Jack" || Name == "EllenP")
                {
                    while (SS == "Jack" || SS == "EllenP")
                    {
                        random = new Random();
                        index = random.Next(People.Count);
                        SS = People[index];
                    }
                }

                person[1] = SS;

                Console.WriteLine(Name + " you're up!");
                Console.WriteLine(Name + " Ho ho ho! You will be buying a present for: " + SS);
                People.Remove(SS);
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*****************************************************");
                System.Threading.Thread.Sleep(8000);
            }
            Console.WriteLine("Secret Santa is complete, the list of who has who will display in 10 seconds for DAD (NOT MUM to take a picture of)");
            Console.WriteLine("Dad please do this now!");
            Console.WriteLine("--------------------------------------");

            foreach (var peep in ListOfAll)
            {
                var Name = peep.First();
                var SS = peep[1];
                Console.WriteLine(Name + "'s is buying a present for " + SS);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
