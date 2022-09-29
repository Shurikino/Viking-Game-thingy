using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainMenu
{
    public class Menu
    {


        public void menuText()
        {
            Console.WriteLine("BATTLE OF STAMFORD BRIDGE");
            Console.WriteLine("Press p to Play, press q to Quit");
            string userDecision = Console.ReadLine()!;
            
            if (userDecision.ToUpper() == "P")
            {
                Console.WriteLine("game launched");
            }
            else if(userDecision.ToUpper() == "Q")
            {
                Console.WriteLine("game closed");
                Environment.Exit(0);
            }
            else 
            { 
                Console.WriteLine("choose again");
                menuText();
            }
            

                
                
            
                
            
            
            
           
            







        }
    }
}