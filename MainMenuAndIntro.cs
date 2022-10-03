using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroScreen;
using Tutorial;

namespace Game
{
    public class game
    {
        IntroToGame introText = new IntroToGame();

        public void menuAndIntro()
        {
            Console.WriteLine("BATTLE OF STAMFORD BRIDGE");
            Console.WriteLine("\nPress p to Play\nPress q to Quit");
            userDecision1();
        }
        public void userDecision1()
        {
            string userDecision = Console.ReadLine()!;

            if (userDecision.ToUpper() == "P")
            {
                introText.introText();



            }
            else if (userDecision.ToUpper() == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("choose again");
                userDecision1();
            }
        }   
    }
}
            
            
            
                

                
                
            
                
            
            
            
           
            






