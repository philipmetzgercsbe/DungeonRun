using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonRunner
{
    
    class Program
    {
        public static Menu Start;
        public Character MyCharacter = Start.MyCharacter;
        static void Main(string[] args)
        {
            
            CreateDirectorys();
            Start = new Menu();
            Start.ShowMainMenu();
//            while (true)
//            {
//                //Loop through the game and check Character Health
//                EndGame();
//
//            }
//            
           // MyCharacter = new Character();

           //Possible loop
           /* while (Start.MyCharacter.Dead1 == false)
            {
                //show menu 
                
                if (Start.MyCharacter.Dead1 == true)
                {
                    EndGame();
                    Start.MyCharacter = new Character();
                }
            }
            */

            
            
            


        }

        public static void EndGame()
        {
            if (Start.MyCharacter == null)
            {
                Environment.Exit(0);
            }
            
        }

       private static void RestartGame()
       {
           
           Start.ShowMainMenu();
       }

        private static void CreateDirectorys()
        {
            if (!Directory.Exists("DungeonRunner//Saves"))
            {
                Directory.CreateDirectory("DungeonRunner//Saves");
                Directory.CreateDirectory("DungeonRunner//Saves//Txt");
                Directory.CreateDirectory("DungeonRunner//Saves//Json");
            }

        }
    }
}
