using System;
using System.IO;

namespace DungeonRunner
{
    public class Load
    {
        private string pickchar;
        
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
       
        public void CheckIfCharExists()
        {
            Console.WriteLine("Pick a character");
            pickchar = Console.ReadLine();
            using (StreamReader sr = File.OpenText("test.txt"))
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