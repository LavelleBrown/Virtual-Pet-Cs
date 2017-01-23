using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        
        //Fields
        private int hunger = 5;
        private int thirst = 5;
        private int play = 5;
        private int mood = 5;
        
        //Properties
        public int hungerLevel { get; set; }
        public int thirstLevel { get; set; }
        public int playLevel { get; set; }
        public int moodLevel { get; set; }

        //Constructors
        public VirtualPet()
        {

        }
        public VirtualPet(int hungerLevel, int thirstLevel, int playLevel, int moodLevel)
        {
          
        }
        //Methods
        public void Food()
        {
            hungerLevel = hungerLevel + 5;
            thirstLevel = thirstLevel + 5;
            playLevel = playLevel + 2;
            moodLevel = moodLevel + 3;
            if (hungerLevel > 5)
            {
                Console.WriteLine("The BoogyMan is feeling good and ready to play");
            }
            else if (hungerLevel <=5)
            {
                Console.WriteLine("The BoogyMan is still hungry!");
            }
            else if (hungerLevel < 0)
            {
                Console.WriteLine("You are taking food away from The BoogyMan! The BoogyMan is gonna get you!!");
            }
            else
            {
                Console.WriteLine("The BoogyMan wants to scare someone.");
            }

        }
        public void Water()
        {
            hungerLevel = hungerLevel +5;
            thirstLevel = thirstLevel + 6;
            playLevel = playLevel - 1;
            moodLevel = moodLevel + 3;
            if (thirstLevel > 5)
            {
                Console.WriteLine("The BoogyMan is feeling good and needs to play.");
            }
            else
            {
                Console.WriteLine("The BoogyMan is still thirsty. Hurry before he comes for you!");
            }
        }
        public void Play()
        {
            hungerLevel = hungerLevel - 3;
            thirstLevel = thirstLevel - 3;
            playLevel = playLevel + 5;
            moodLevel = moodLevel + 5;
            Console.WriteLine("The BoogyMan had fun but now he is hungry and thirsty.");
            if (playLevel > 8)
            {
                Console.WriteLine("You better feed him before The BoogyMan gets you");
                Console.WriteLine();

            }
            
        }
        public void Mood()
        {
            hungerLevel = hungerLevel + 5;
            thirstLevel = thirstLevel + 5;
            playLevel = playLevel +5;
            moodLevel = moodLevel + 5;
        }
        public void Status()
        {
            int changes;
            Random levels = new Random();
            changes = levels.Next(1,10);

            if (changes <= 5 && changes > 0)
            {
                hunger = hungerLevel + changes;
                thirst = thirstLevel + changes;
                play = playLevel + changes;
                mood = moodLevel + changes;

                Console.WriteLine("The BoogyMan feels different now. This is what he needs now. Before he comes for you!");

                //Console.WriteLine("Hunger Level: {0}", hungerLevel);
                //Console.WriteLine("Thirsrt Level: {0}", thirstLevel);
                //Console.WriteLine("Play Level: {0}", playLevel);
                //Console.WriteLine("Mood Level: {0}", moodLevel);
            }
            else
            {
                hungerLevel = hunger + 2;
                thirstLevel = thirst + 2;
                playLevel = play + 2;
                moodLevel = mood + 2;
              

                Console.WriteLine("This is how he feels now.");

            }   Console.WriteLine("Hunger Level: {0}", hungerLevel);
                Console.WriteLine("Thirsrt Level: {0}", thirstLevel);
                Console.WriteLine("Play Level: {0}", playLevel);
                Console.WriteLine("Mood Level: {0}", moodLevel);
        }

    }
    
}
