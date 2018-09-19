using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DungeonRunner
{
    public class Load
    {
        private static string JsonPath = "DungeonRunner//Saves//Json";
        private static string TxtPath = "DungeonRunner//Saves//Txt";
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

        public void Streamwithparams(Character character)
        {
            using (StreamReader reader = new StreamReader(ChoosenPath + character + ChoosenFileEnd))
            {
                Console.WriteLine("Here is a list of characters:");
                string[] s;
                do
                {

                    s = Directory.GetFiles(ChoosenPath);
                    Console.WriteLine(s);
                } while (s != null);
               
            } 
        }
        public void LoadCharacter()
        {
            Console.WriteLine("Press [1] to load .json file\nPress [2] to load .txt file");
            FileEnd = Convert.ToInt32(Console.ReadLine());
            if (FileEnd == 1)
            {
              
                ChoosenFileEnd = JsonFileEnd;
                ChoosenPath = JsonPath;

            }
            else
            {
                ChoosenFileEnd = TxtFileEnd;
                ChoosenPath = TxtPath;
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