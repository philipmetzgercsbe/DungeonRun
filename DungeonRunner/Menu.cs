using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DungeonRunner
{

    public class Menu
    {
        //Reference all used Objects
        public Monster Enemy;
        public Room Room;
        public Character MyCharacter = new Character();
        private Character character;
        private CharClass Abilities;
        private Item Items;
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
                    ShowMainMenu();
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
            Console.WriteLine("╠-Enter your Age     {0} -╣", name);
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
            return;

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
            

            if (File.Exists("DungeonRunner/Saves/Json/" + MyCharacter.Name1 + ".json") ||
                File.Exists("DungeonRunner/Saves/Txt/" + MyCharacter.Name1 + ".txt"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A Save File with the same Name already exists");
                Console.ForegroundColor = ConsoleColor.White;
                //ShowMainMenu();

            }
            ShowMainMenu();


        }

        public void ShowLoadMenu()
        {
            Load load = new Load();
            Console.WriteLine("╔=--------------=°=--------------=╗");
            Console.WriteLine("╠-In which file is your character-╣");
            Console.WriteLine("╚=--------------===--------------=╝");
            string charName = Console.ReadLine();
            MyCharacter.Name1 = charName;
            load.CheckIfCharExists(charName);
            load.LoadCharacter(MyCharacter);
            ShowMainMenu();
            
           
        }

        public void GameStart()
        {
            Console.WriteLine("╔=---------------------=°=---------------------=╗");
            Console.WriteLine("╠-You enter the Dungeon and encounter a Monster-╣");
            Console.WriteLine("╚=---------------------===---------------------=╝");
            Room = new Room(1, 1);
            if (Room.isDone() == true)
            {
                Room = null;
                IncreaseRoom();

            }
            
            //Call Game Constructor with Character Object;
            //show individual menus
        }

        private void IncreaseRoom()
        {
            int roomLevel = this.Room.Level1;
            if (Room == null)
            {
                for (int i = 0; i <= roomLevel; i++)
                {
                    Room = new Room(i, i);
                    FightMenu();
                }
            }
        }

        private void WriteToCharObj(string name, int age, string charClass)
        {
             MyCharacter = new Character(name, age, charClass);
        }

        public void FightMenu() 
        {
            MyCharacter.ShowAbility();
            //Iterate through Abilities
            Console.WriteLine("╔=---------=°=--------=╗");
            Console.WriteLine("╠-Choose your Ability:-╣");
            Console.WriteLine("╚=---------===--------=╝");
            string spellname = Console.ReadLine();
            //UseSpell(Spellname)
            if (spellname != null)
            {
                MyCharacter.UseSpell(
                    Abilities.GetAbilities().FirstOrDefault(ability => ability.SpellName1 == spellname));

            }


            if (Room.Round >= 2)
            {
                bool useItem = false;
                Console.WriteLine("Do you want to use a Item");
                Console.WriteLine("Press [1] for yes | Press [2] for no");
                int itemChoice = Int32.Parse(Console.ReadLine());
                if (itemChoice == 1)
                {
                    MyCharacter.ShowItems();
                    string ItemName = Console.ReadLine();
                    MyCharacter.UseItem(MyCharacter.ShowItems().FirstOrDefault(item => item.ItemName1 == ItemName));
                }
                else
                {
                    return;
                }
                
            }

            if (MyCharacter.Lp == 0 )
            {
                MyCharacter = null;
                 
            }
           
            
           

        }
    }
}