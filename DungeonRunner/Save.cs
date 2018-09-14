using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace DungeonRunner
{
    
    
    public class Save
    {
        
        
        public void takechar(ref Character[] Person1)
        {
            StreamWriter FileWriter = new StreamWriter("test.txt");
            FileWriter.WriteLine(Person1.Length + 1);
            
            for (int i = 0; i < Person1.Length; i++)
            {
                
                
            }
            
        }
    }
}