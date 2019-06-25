using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the RPSGE GMO Spa! Would you like to know more?");
            //Rude People Suffer Genetic Errors
            string response;
            response = Console.ReadLine();
            if (response == "Yes")
            {
                Console.WriteLine("Excellent! WE have many options for custom modification of your personal genome. Would prefer to be modified mentally or physically?");
                string y = Console.ReadLine();
                if (y == "physically")
                {
                    Console.WriteLine("Wonderful. Just one small injection....");
                    Console.WriteLine("You're dead. Don't trust doctors");

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
            else if (response == "I am Charles 'Chip' Rothberd the III and the CEO of RPSGE GMO Spa inc.!")
            /*Chip this is the "hidden level" of my game. Hopefully
             * you're reading my code, see this note, and find it. Cheers crypto dude!*/
            {
                Console.WriteLine("I'm so sorry Mr.Chip.");
                Console.WriteLine("Are you here for the corporate inspection?");


            }







            else // annoyance
            {
                Console.WriteLine("Have a nice day!");

            }

        }
}   }
