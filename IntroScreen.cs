using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Tutorial;

namespace IntroScreen
{
    public class IntroToGame
    {
        TutorialScreen choiceSystem = new TutorialScreen();
        public void introText()
        {
            Console.Clear();
            Console.WriteLine("\nThe year is 1066, you are the great norwegian king Harald Hardrada and you have a claim to the English throne which is currently occupied by Harold Godwinson.");
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nEarlier this year, during summer, you have defeated an English army led by Edwin and Morcar, earls of respectively Mercia and Northumbria, in the battle of Fulford, a great victory, but not enough to cripple the English war machine.");
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nToday is the 25th of september, you and your army are camped near the city of York, waiting for the defeated Northumbrians to bring you supplies and prisoners.");
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYour army is not ready for battle and yet, unexpectedly, Harold Godwinson appears with a great army of Englishmen, ready to repel the invaders. ");
            Console.WriteLine("\nPress any button to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYou, the great King of Norway, must now lead your army into battle and, if the Gods will it, beat the English army and become king of England!");
            Console.WriteLine("\nDo you wish to skip the tutorial? Y/N.");
            userDecision();

        }       
        public void userDecision()
        {
            string userDecision2 = Console.ReadLine()!;
            if (userDecision2.ToUpper() == "N")
            {
                choiceSystem.tutorial();
            }
            else if (userDecision2.ToUpper() == "Y")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("choose again");
                userDecision();
            }
            Console.ReadLine();
            Console.Clear();
        }   



    
    
    
    }
}
