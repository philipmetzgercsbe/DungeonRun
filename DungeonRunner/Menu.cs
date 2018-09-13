using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace DungeonRunner
{
    public class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Dungeon Runner");
            ShowCharMenu();
            ShowSaveMenu();
            ShowLoadMenu();
            Console.WriteLine("Press [4] to start the game");
            GameStart();
        }


        public void ShowRessources()
        {
            Console.WriteLine("Inventory: LP: MP: Gold:");
            //Inventory: Character.showItems() Character.showLifePoints() Character.showManaPoints(); Character.showCurrentGold

        }

        public void ShowCharMenu()
        {
            Console.WriteLine("Choose your name Hero");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age {0}",name);
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Chooose your Class {0}",name);
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
            //Initiate Load Class
            Console.WriteLine("In which file is your character");
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