using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MenuTextJson
{
    public class MenuTextToJson
    {
        List<string> mainMenuText = new List<string>();
        
        public void menuTextToJson() 
        {
            mainMenuText.Add("BATTLE OF STAMFORD BRIDGE");
            mainMenuText.Add("\nPress p to Play\nPress q to Quit");
            
            string output = JsonConvert.SerializeObject(mainMenuText);
            File.WriteAllText(@"C:\Repos\Viking-Game-thingy\JsonFIles\MenuText\MenuText.json", output);
            
        }
        public void menuTextFromJson()
        {
            List<string> deserializedMainMenuText = new List<string>();
            deserializedMainMenuText = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(@"C:\Repos\Viking-Game-thingy\JsonFIles\MenuText\MenuText.json"))!;
            Console.WriteLine(deserializedMainMenuText[0]);
            Console.WriteLine(deserializedMainMenuText[1]);


        } 
    
    
    
    }
}
