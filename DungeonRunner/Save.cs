using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace DungeonRunner
{
    
    
    public class Save
    {
       
        
        public void WriteCharToTxt(Character character)
        {
            //TODO: Write to CharName.txt and load values from Character Object
            StreamWriter FileWriter = new StreamWriter(character + ".txt");
           
           
            //TODO: Call dynamic Object and write to file
          
           //
            FileWriter.WriteLine(character.Name1);
            FileWriter.WriteLine(character.Age1);
            FileWriter.WriteLine(character.Lp);
            FileWriter.WriteLine(character.Mp);
            
            
            

        }

        public void WriteToJson(Character character)
        {

           List<string> _data = new List<string>();
            _data.Add(character.Name1);
            _data.Add(character.Age1.ToString());
            _data.Add(character.Lp.ToString());
            _data.Add(character.Mp.ToString());

            string json = JsonConvert.SerializeObject(_data.ToArray());
            
            StreamWriter FileWriter = new StreamWriter(character + ".json");
            FileWriter.WriteLine(json);
        }
    }
}