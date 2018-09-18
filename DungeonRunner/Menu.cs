using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;
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
            Console.WriteLine("Press [1] to Create a Character\n Press [2] to save a created Character\n Press [3] to load a saved Character\n Press [4] to Start Dungeon Runner");
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
            Console.WriteLine("Inventory:" + MyCharacter.ShowItems() + "LP:" + MyCharacter.ShowLifePoints + "MP:" + MyCharacter.ShowManaPoints + "Gold:" + MyCharacter.ShowCurrentGold());
            //ref Char

        }

        public void ShowCharMenu()
        {
            Console.WriteLine("Choose your name Hero");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age {0}",name);
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Chooose your Class {0}",name);
            Console.WriteLine("Press [1] to be a Ranger\n Press [2] to be a Rogue\n Press [3] to be a Mage\n Press [4] to be a Barbarian");
            int CharClassOption = Int32.Parse(Console.ReadLine());
            switch (CharClassOption)
            {
                case 1: 
                    WriteToCharObj(name,age,"Ranger");
                    break;
                case 2:
                    WriteToCharObj(name, age, "Rogue");
                    break;
                case 3:
                    WriteToCharObj(name,age,"Mage");
                    break;
                case 4: WriteToCharObj(name, age, "Barbarian");
                    break;
                default: ShowCharMenu();
                    break;
            }
            Console.WriteLine("Press enter to finish your Character");
            //How do I return to main Menu

            //Hallo
            
        }

        public void ShowSaveMenu()//Character
        {
            Save Save = new Save();
            Console.WriteLine("Save your Character");
            Console.WriteLine("Enter your file option");
            Console.WriteLine("txt | json");
            string option = Console.ReadLine();
            switch (option)
            {
                case "txt": Save.WriteCharToTxt(MyCharacter);
                    break;
                case "json": Save.WriteToJson(MyCharacter);
                    break;
                default: Console.WriteLine("No option given");
                    break;
            }
            if (File.Exists("DungeonRunner/Saves/Json/" + MyCharacter + ".json") || File.Exists("DungeonRunner/Saves/Txt/" + MyCharacter + ".json") )
            {
                Console.WriteLine("A Save File with the same Name already exists");
                ShowMainMenu();
            }
            //Input .txt/ .json
            //  Console.WriteLine("Do you want to save to a custom Path?");
            //Control if the CharFile already exists

        }

        public void ShowLoadMenu()
        {
            Load load = new Load();
            Console.WriteLine("In which file is your character");
            string CharName = Console.ReadLine();
            load.CheckIfCharExists(CharName);
            load.LoadCharacter();
            //Read file
            //Try Catch
        }

        public void GameStart()
        {
            Room StartingRoom = new Room(1,1);
            //Call Game Constructor with Character Object;
            //show individual menus
        }

        private void WriteToCharObj(string name, int age, string charClass)
        {
            Character MyCharacter = new Character(name, age, charClass);
        }
    }
}