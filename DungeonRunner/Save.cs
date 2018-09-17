using System;
using System.IO;
using System.Runtime.Serialization;


namespace DungeonRunner
{
    
    
    public class Save
    {
       
        
        public void WriteCharToTxt()
        {
            //TODO: Write to CharName.txt and load values from Character Object
            StreamWriter FileWriter = new StreamWriter("test.txt");
            Console.WriteLine("What is your name?: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("How old are you{0}?: ",n1);
            int a1 = Convert.ToInt16(Console.ReadLine());
            
            //TODO: Call dynamic Object and write to file
            Character ch1 = new Character(n1,a1);
           //
            FileWriter.WriteLine(ch1.Name1);
            FileWriter.WriteLine(ch1.Age1);
            FileWriter.WriteLine(ch1.Lp);
            FileWriter.WriteLine(ch1.Mp);
            
            
            

        }

        public void WriteToJson()
        {
            //Write to json

        }
    }
}