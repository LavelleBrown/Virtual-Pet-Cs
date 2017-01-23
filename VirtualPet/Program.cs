using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
           

            VirtualPet boogyMan = new VirtualPet(5, 5, 5, 5);

            Console.WriteLine("This is The BoogyMan my pet monster");
            Console.WriteLine("The BoogyMan is a monster that needs to be fed, given water, and played with.");
            Console.WriteLine("All of these things affects The BoogyMan's mood. Keep him happy or he will get you!.");
            Console.WriteLine();
            Console.WriteLine("Hit enter to take care of The BoogyMan");
            Console.ReadKey();
            Console.WriteLine();
            boogyMan.Status();
            Console.WriteLine();

           

            while (true)
            {
                Console.WriteLine("What do you want to do for The BoogyMan?");
                Console.WriteLine("Enter 1 to feed him.");
                Console.WriteLine("Enter 2 to give him water.");
                Console.WriteLine("Enter 3 to play with him.");
                Console.WriteLine("Enter 4 to simply do nothing.");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    boogyMan.Food();
                }
                else if (choice == 2)
                {
                    boogyMan.Water();
                }
                else if (choice == 3)
                {
                    boogyMan.Play();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("BOO...BOOO...The BoogyMan is going to get you!!!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }

                Console.WriteLine("This is how he feels now.");
                Console.WriteLine();
                Console.WriteLine("Hunger Level: {0}", boogyMan.hungerLevel);
                Console.WriteLine("Thirst Level: {0}", boogyMan.thirstLevel);
                Console.WriteLine("Play Level: {0}", boogyMan.playLevel);
                Console.WriteLine("Mood Level: {0}", boogyMan.moodLevel);
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? Enter 1 for Yes and 2 for No");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    continue;
                }
                else if (option == 2)
                {
                    Console.WriteLine("Boo...Booo! The BoogyMan is going to get you!!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2.");
                    option = Convert.ToInt32(Console.ReadLine());
                }



            }

            

        }
    }
}
