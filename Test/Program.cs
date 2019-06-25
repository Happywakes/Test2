using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {//This is a horror story from many perspectives.May or may not be entertaining.
            Console.WriteLine("You stand inside a lobby as a nurse with crazy eyes but impecabble posture approaches you.");
            Console.WriteLine("You think about leaving.");
                Console.WriteLine("Welcome to the APSGE GMO Spa! Would you like to know more?, says the nurse.");
            //All People Suffer Genetic Errors
            string response;
            response = Console.ReadLine();
            if (response == "Yes")
            {
                Console.WriteLine("Excellent! WE have many options for custom modification of your personal genome.");
                Console.WriteLine("Would prefer to be modified mentally or physically?");
                string y = Console.ReadLine();
                if (y == "physically")
                {
                    Console.WriteLine("Wonderful. Just one small injection....");
                    Console.WriteLine("You're dead. Don't trust doctors; especially if they carry needles.");

                }
                else
                {
                    Console.WriteLine("It's ok; at least you made to us! Can you read and sign this paperwork?");
                    Console.WriteLine("(Speech options: I can't read. or Of course!)");
                    Console.ReadLine();
                    Console.WriteLine("Wonderful! Just one little injection....... ");
                    Console.WriteLine("You pass out. You're dead. Don't trust paperwork.");
                }
            }
            else if (response == "I am Charles 'Chip' Rothberd the III and the CEO of APSGE GMO Spa inc.!")
            /*Chip this is the "hidden level" of my game. Hopefully
             * you're reading my code, see this note, and find it. Cheers crypto dude!*/
            {
                Console.WriteLine("I'm so sorry Mr.Chip.");
                Console.WriteLine("Are you here for the corporate inspection?");
                Console.WriteLine("(Text options:Of course I bloody am. or Just here for my yearly percentage.");



            }

            else // annoyance
            {
                Console.WriteLine("Have a nice day!");
                Console.Write("As you walk away you hear screams come from the the windows and the mutated semblance of a man briefly walks in front of a window.");
                Console.Write("It; for no more was it kin to man; stood brow against window. It's eyes a yellow glow. The blind bestial rage evident.");
                Console.WriteLine("You run away down the street and aquire a lifelong problem with Iatrophobia.");

            }

        }
}   }
