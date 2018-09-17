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
        public static Menu start;
        public Character MyCharacter;
        static void Main(string[] args)
        {
            CreateDirectorys();
            start = new Menu();
           // MyCharacter = new Character();
           
          

            
            
            


        }

        static void EndGame()
        {
            /*if () Check if Character is alive
            {
                    End Game 
                    Delete Character Object
                    call Restart Game 
                    which calls start.MainMenu();

            } */
        }

       private static void RestartGame()
       {
           
           start.ShowMainMenu();
       }

        private static void CreateDirectorys()
        {
            if (!Directory.Exists("DungeonRunner/Saves"))
            {
                Directory.CreateDirectory("DungeonRunner/Saves");
                Directory.CreateDirectory("DungeonRunner/Saves/Txt");
                Directory.CreateDirectory("DungeonRUnner/Saves/Json");
            }

        }
    }
}
