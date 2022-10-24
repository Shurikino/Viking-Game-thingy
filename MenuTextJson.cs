using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace MenuTextJson
{
    public class MenuTextToJson
    {
        List<string> mainMenuText = new List<string>();
        string saveDirectory = Directory.GetCurrentDirectory() + "/JsonFiles";


        public void menuTextToJson() 
        {
            mainMenuText.Add("BATTLE OF STAMFORD BRIDGE");
            mainMenuText.Add("\nPress p to Play\nPress q to Quit");

            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            
            string output = JsonConvert.SerializeObject(mainMenuText);
            File.WriteAllText(saveDirectory + "/Test.json", output);
            
        }
        public void menuTextFromJson()
        {
            List<string> deserializedMainMenuText = new List<string>();
            deserializedMainMenuText = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(saveDirectory + "/Test.json"))!;
            Console.WriteLine(deserializedMainMenuText[0]);
            Console.WriteLine(deserializedMainMenuText[1]);


        } 
    
    
    
    }
}
