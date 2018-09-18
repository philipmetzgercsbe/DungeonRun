using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace DungeonRunner
{
    
    
    public class Save
    {
        StreamWriter FileWriter;
       
        
        public void WriteCharToTxt(Character character)
        {
            //TODO: Write to CharName.txt and load values from Character Object
            FileWriter = new StreamWriter(@"DungeonRunner\\saves\\Txt\\"+character + ".txt");
            //TODO: Call dynamic Object and write to file
            FileWriter.WriteLine(character.Name1);
            FileWriter.WriteLine(character.Age1);
            FileWriter.WriteLine(character.Lp);
            FileWriter.WriteLine(character.Mp);
            
            
            

        }

        public void WriteToJson(Character character)
        {

          
            
            JObject o = (JObject) JToken.FromObject(new
            {
                character = new
                {
                    Name =  character.Name1,
                    Age = character.Age1,
                    LP = character.Lp,
                    MP = character.Mp
                }
            });;


            FileWriter = new StreamWriter(@"DungeonRunner\\saves\\json\\" + character + ".json", true);
                string jsonobject = JsonConvert.SerializeObject(o);
                FileWriter.Write(jsonobject);
                
            
        }
    }
}