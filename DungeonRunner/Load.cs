using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DungeonRunner
{
    public class Load
    {
        public Character MyCharacter;
        private static string JsonPath = "DungeonRunner//Saves//Json//";
        private static string TxtPath = "DungeonRunner//Saves//Txt//";
        private static string JsonFileEnd = ".json";
        private static string TxtFileEnd = ".txt";
        private string ChoosenFileEnd;
        private string ChoosenPath;
        private static string pickchar;
        private int FileEnd;
        private StreamReader sr;
        public Load()
        {
           
        }

        /*public void ReadStreamWithParams(Character character)
        {
            using (StreamReader reader = new StreamReader(ChoosenPath + character.Name1+ ChoosenFileEnd))
            {
                Console.WriteLine("╔=-------------=°=-------------=╗");
                Console.WriteLine("╠-Here is a list of characters:-╣");
                Console.WriteLine("╚=-------------===-------------=╝");
                string[] s;
                do
                {

                   s = Directory.GetFiles(ChoosenPath+character.Name1+ChoosenFileEnd);
                   Console.WriteLine(s);
                } while (s != null);
               
            } 
        }*/

        
        public void LoadCharacter(Character character)
        {
            Console.WriteLine("╔=----------------------------=°=---------------------------=╗");
            Console.WriteLine("╠-Press [1] to load .json file | Press [2] to load .txt file-╣");
            Console.WriteLine("╚=----------------------------===---------------------------=╝");
            FileEnd = Convert.ToInt32(Console.ReadLine());
            if (FileEnd == 1)
            {
              
                ChoosenFileEnd = JsonFileEnd;
                ChoosenPath = JsonPath;
                MyCharacter = JsonConvert.DeserializeObject<Character>(ChoosenPath + character.Name1 + ChoosenFileEnd);
                Console.WriteLine("You are: {0}",MyCharacter);
                
            }
            else
            {
                ChoosenFileEnd = TxtFileEnd;
                ChoosenPath = TxtPath;
                ReadStreamWithTxt(character);

            }

            
        }
        public void ReadStreamWithTxt(Character character)
        {
            
           Console.WriteLine("╔=-------------=°=-------------=╗");
           Console.WriteLine("╠-Here are your stats:         -╣");
           Console.WriteLine("╚=-------------===-------------=╝");
           
            /*using (StreamReader reader = new StreamReader(TxtPath + character.Name1+TxtFileEnd))
            {
                
                string[] s;
                do
                {

                    //s = Directory.GetFiles(TxtPath+character.Name1+TxtFileEnd);
                    s = File.ReadAllLines(TxtPath + character.Name1+TxtFileEnd);
                    Console.WriteLine(s);
                } while (s != null);
              
               
               
            } */
            //svar lines = File.ReadLines(
               // "C:\\Users\\vmadmin\\RiderProjects\\DungeonRun\\DungeonRunner\\bin\\Debug\\DungeonRunner\\Saves\\Txt\\zeta.txt");
            var lines = File.ReadLines(TxtPath +character.Name1+TxtFileEnd);//Dr Fehler ligt am character.Name1. D igab stimmt nit überi mit .Name1
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }    
        
        public void CheckIfCharExists(string FileName)
        {
            
            if (File.Exists(Path.Combine(JsonPath + FileName + JsonFileEnd)))
            {
                return;
            }
            if (File.Exists(Path.Combine( TxtPath + FileName + TxtFileEnd)))
            {
                return;
            }
            pickchar = FileName;
            if (FileName == FileName + JsonFileEnd)
            {
                sr = File.OpenText(JsonPath + FileName + JsonFileEnd);
                {
                    MatchCharacter(FileName,TxtFileEnd);
                }


            }else if (FileName == FileName + TxtFileEnd)
            {
                sr = File.OpenText(TxtPath + FileName + TxtFileEnd);
                {
                    MatchCharacter(FileName,JsonFileEnd);
                }
            }
        }

           

        private void MatchCharacter(string FileName,string FileEnd)
        {
           
            if (FileEnd == TxtFileEnd)
            {
                string[] lines = File.ReadAllLines(TxtPath + FileName + TxtFileEnd);
                bool isMatch = false;
                for (int x = 0; x < lines.Length - 1; x++)
                {
                    if (pickchar == lines[x])
                    {
                        Console.WriteLine("Char found");
                        sr.Close();
                        isMatch = true;
                    }
                }

                if (!isMatch)
                {
                    Console.WriteLine("Char not found");
                    sr.Close();
                }
            }
            else if (FileEnd == JsonFileEnd)
            {
                string[] lines = File.ReadAllLines(JsonPath + FileName + JsonFileEnd);
                bool isMatch = false;
                for (int x = 0; x < lines.Length - 1; x++)
                {
                    if (pickchar == lines[x])
                    {
                        Console.WriteLine("Char found");
                        sr.Close();
                        isMatch = true;
                    }
                }

                if (!isMatch)
                {
                    Console.WriteLine("Char not found");
                    sr.Close();
                }
            }
           
            
        }
    }
}