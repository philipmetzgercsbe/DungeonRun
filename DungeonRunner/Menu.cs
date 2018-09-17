using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace DungeonRunner
{
    //Reference all Objects 
    public class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Dungeon Runner");
            Console.WriteLine("Press [1] to Create a Character\n Press [2] to save a created Character\n Press [3] to load a saved Character\n Press [4] to start Dungeon Runner");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ShowCharMenu();
                    break;
                case 2:
                    ShowSaveMenu();
                    break;
                case 3:
                    ShowLoadMenu();
                    break;
                case 4:
                    GameStart();
                    break;
                default:
                    Console.WriteLine("No Input given");
                    break;
            }
           
          
            
            
        }


        public void ShowResources()
        {
            Console.WriteLine("Inventory: LP: MP: Gold:");
            Console.WriteLine(MyCharacter.ShowItems() + MyCharacter.ShowLifePoints + MyCharacter.ShowManaPoints + MyCharacter.ShowCurrentGold());
            //ref Char

        }

        public void ShowCharMenu()
        {
            Console.WriteLine("Choose your name Hero");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age {0}",name);
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Chooose your Class {0}",name);
            Console.WriteLine("");
            //out List<CharClass> = "Ranger","Rogue","Mage","Barbarian"
            Console.WriteLine("Press enter to finish your Character");
            //Write to Character Object
            //Hallo
            
        }

        public void ShowSaveMenu()//Character
        {
            //initiate Save Class
            Console.WriteLine("Save your Character");
            //Input .txt/ .json
          //  Console.WriteLine("Do you want to save to a custom Path?");
            //Control if the CharFile already exists

        }

        public void ShowLoadMenu()
        {
            Load load = new Load();
            Console.WriteLine("In which file is your character");
            load.CheckIfCharExists();
            load.LoadCharacter();
            //Read file
            //Try Catch
        }

        public void GameStart()
        {
            //Call Game Constructor with Character Object;
            //show individual menus
        }
    }
}