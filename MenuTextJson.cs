using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTextJson
{
    public class MenuTextToJson
    {
        List<string> mainMenuText = new List<string>();
        public void addMenuTextToList()
        {
            mainMenuText.Add("BATTLE OF STAMFORD BRIDGE");
            mainMenuText.Add("\nPress p to Play\nPress q to Quit");
        }
        public void indexMenuText()
        {
             Console.WriteLine(mainMenuText[0]);
             Console.WriteLine(mainMenuText[1]);
        }
    
    
    
    
    }
}
