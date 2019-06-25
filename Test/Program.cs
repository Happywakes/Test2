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
                    Console.WriteLine("It's ok; at least you made it to us! Can you read and sign this paperwork?");
                    Console.WriteLine("(Speech options: I can't read. or Of course!)");
                    Console.ReadLine();
                    Console.WriteLine("Wonderful! Just one little injection....... ");
                    Console.WriteLine("You pass out. You're dead. Don't trust paperwork or people with good posture.");
                }
            }
            else if (response == "I am Charles 'Greenhand' Rothberd the III and the CEO of APSGE GMO Spa inc.!")
            /*Chip this is the "hidden level" of my game. Hopefully
             * you're reading my code, see this note, and find it. Cheers crypto dude!*/
            {
                Console.WriteLine("I'm so sorry Mr.Rothberd.");
                Console.WriteLine("Are you here for the corporate inspection?");
                Console.WriteLine("(Text options:Of course I bloody am. or Just here for my yearly percentage.");
                string q;
                q = Console.ReadLine();
                if (q == "Of course I bloody am.")
                {
                    Console.WriteLine("Yes sir. Right this way, the nurse stammers.");
                    Console.Write("She leads you through a hidden alcove behind the desk where monitors are.");
                    Console.WriteLine("As you can see sir; the research here has proven quite profitable, she whispers.");
                    Console.WriteLine("You gaze at the monitor screens and chuckle as you gaze at your creations.");
                    Console.WriteLine("Which experiments would you like to view, sir?, she says more confident.");
                    Console.WriteLine("(Text options ex1 ex2 ex3)");
                    string v;
                    v = Console.ReadLine();
                    if (v == "ex1")
                    {
                        Console.Write("Ok let me switch to that video stream, says the nurse while typing.");
                        Console.WriteLine("Static covers the screen for a brief second but then an image begins to appear as it clears.");
                        Console.WriteLine("You and the nurse laugh maniacally. Behold Weasel-Man!");
                    }
                    else if (v == "ex2")
                    {
                        Console.Write("Ok let me switch to that video stream, says the nurse while typing.");
                        Console.WriteLine("Static covers the screen for a brief second but then an image begins to appear as it clears.");
                        Console.Write("You and the nurse pause nervously. It is an empty space in your memory for some thing are beyond all imagining.");
                    }
                    else
                    {
                        Console.Write("Ok let me switch to that video stream, says the nurse while typing.");
                        Console.Write("The screen explodes. The room becomes filled with smoke. All is lost.");
                    }

                }
                else
                {
                    Console.WriteLine("Right this way sir, she starts walking through the door on the right.");
                    Console.Write("You walk into a room with piles of money in all denominations. Nestled ny the door; are two brief cases.");
                    Console.WriteLine("You take the money. You ignore the screams on your way out the door and to retirement.");
                }
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
