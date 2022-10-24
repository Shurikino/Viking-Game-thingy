using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroScreen;
using Tutorial;
using MenuTextJson;

namespace Game
{
    public class game
    {
        IntroToGame introText = new IntroToGame();
        MenuTextToJson jsonConverter = new MenuTextToJson();

        public void menuAndIntro()
        {
            jsonConverter.menuTextToJson();
            jsonConverter.menuTextFromJson();
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
            
            
            
                

                
                
            
                
            
            
            
           
            






