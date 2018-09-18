using System;
using System.IO;

namespace DungeonRunner
{
    public class Load
    {
        private static string JsonPath = "";
        private static string TxtPath = "";
        private static string JsonFileEnd = ".json";
        private static string TxtFileEnd = ".txt";
        private static string pickchar;
        private StreamReader sr;
        
        public Load()
        {
           
        }

        public void LoadCharacter(/*ref CreateChar ch1*/)
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                Console.WriteLine("Here is a list of characters:");//show only names
                string s;
                do
                {
                    s = reader.ReadLine();
                    Console.WriteLine(s/*ch1.ChName*/);
                } while (s != null);

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
            sr = File.OpenText(TxtPath + FileName + TxtFileEnd);
            {
                string[] lines = File.ReadAllLines("test.txt");
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