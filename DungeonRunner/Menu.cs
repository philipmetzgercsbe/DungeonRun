using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace DungeonRunner
{
    
    public class Menu
    {
        //Reference all used Objects
        public Character MyCharacter;
        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Dungeon Runner");
            Console.WriteLine(
                "Press [1] to Create a Character\n Press [2] to save a created Character\n Press [3] to load a saved Character\n Press [4] to Start Dungeon Runner");
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
            string CharLP = MyCharacter.ShowLifePoints().ToString();
            string CharMP = MyCharacter.ShowManaPoints().ToString();
            string CharGold = MyCharacter.ShowCurrentGold().ToString();
            string Inventory = MyCharacter.ShowItems().ToString();
            Console.WriteLine("LP: {0} MP: {1} Gold: {2} \n Inventory: {3}" , CharLP, CharMP, CharGold, Inventory);
            
          

        }

        public void ShowCharMenu()
        {
            Console.WriteLine("╔=---------=°=---------=╗");
            Console.WriteLine("╠-Choose your name Hero-╣");
            Console.WriteLine("╚=---------===---------=╝");
            string name = Console.ReadLine();
            Console.WriteLine("╔=----------=°=----------=╗");
            Console.WriteLine("╠-Enter your Age {0}     -╣", name);
            Console.WriteLine("╚=----------===----------=╝");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("╔=----------=°=----------=╗");
            Console.WriteLine("╠-Chooose your Class {0} -╣", name);
            Console.WriteLine("╚=----------===----------=╝");
            Console.WriteLine("Press [1] to be a Ranger\n Press [2] to be a Rogue\n Press [3] to be a Mage\n Press [4] to be a Barbarian");
            int CharClassOption = Int32.Parse(Console.ReadLine());
            switch (CharClassOption)
            {
                case 1:
                    WriteToCharObj(name, age, "Ranger");
                    break;
                case 2:
                    WriteToCharObj(name, age, "Rogue");
                    break;
                case 3:
                    WriteToCharObj(name, age, "Mage");
                    break;
                case 4:
                    WriteToCharObj(name, age, "Barbarian");
                    break;
                default:
                    ShowCharMenu();
                    break;
            }

            Console.WriteLine("Your are done creating your Character");
            ShowMainMenu();

            //Hallo

        }

        public void ShowSaveMenu() //Character
        {
            Save Save = new Save();
            Console.WriteLine("╔=--------=°=--------=╗");
            Console.WriteLine("╠-Save your Character-╣");
            Console.WriteLine("╚=--------===--------=╝");
            Console.WriteLine("╔=---------=°=----------=╗");
            Console.WriteLine("╠-Enter your file option-╣");
            Console.WriteLine("╠--------txt | json------╣");
            Console.WriteLine("╚=---------===----------=╝");
            string option = Console.ReadLine();
            switch (option)
            {
                case "txt":
                    Save.WriteCharToTxt(MyCharacter);
                    break;
                case "json":
                    Save.WriteToJson(MyCharacter);
                    break;
                default:
                    Console.WriteLine("No option given");
                    break;
            }

            if (File.Exists("DungeonRunner/Saves/Json/" + MyCharacter + ".json") ||
                File.Exists("DungeonRunner/Saves/Txt/" + MyCharacter + ".txt"))
            {
                Console.WriteLine("A Save File with the same Name already exists");
                ShowMainMenu();
            }


        }

        public void ShowLoadMenu()
        {
            Load load = new Load();
            Console.WriteLine("╔=--------------=°=--------------=╗");
            Console.WriteLine("╠-In which file is your character-╣");
            Console.WriteLine("╚=--------------===--------------=╝");
            string CharName = Console.ReadLine();
            load.CheckIfCharExists(CharName);
            load.LoadCharacter();
            ShowMainMenu();
           
        }

        public void GameStart()
        {
            Console.WriteLine("╔=---------------------=°=---------------------=╗");
            Console.WriteLine("╠-You enter the Dungeon and encounter a Monster-╣");
            Console.WriteLine("╚=---------------------===---------------------=╝");
            Room StartingRoom = new Room(1, 1);
           
            //Call Game Constructor with Character Object;
            //show individual menus
        }

        private void WriteToCharObj(string name, int age, string charClass)
        {
            Character MyCharacter = new Character(name, age, charClass);
        }

        private void FightMenu()
        {
            Console.WriteLine(MyCharacter.Abilities);
            foreach (var Ability in MyCharacter.Abilities)
            {
                Console.WriteLine(Ability);   
            }
            //Iterate through Abilities
            Console.WriteLine("╔=---------=°=--------=╗");
            Console.WriteLine("╠-Choose your Ability:-╣");
            Console.WriteLine("╚=---------===--------=╝");
            string Spellname = Console.ReadLine();
            //UseSpell(Spellname)
            MyCharacter.UseSpell(Spellname);
            if (Room.round >= 2)
            {
                MyCharacter.ShowItems();
                string ItemName = Console.ReadLine();
                MyCharacter.UseItem(item:Item);
            }
           
            //Get Curr Room and
            //Check if enemy or self alive
            //LP += GainStats + MP+=GainStats + CurrentGold += GoldtoDrop
            //If dead 
            MyCharacter = null;

        }
    }
}