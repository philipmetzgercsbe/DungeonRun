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
            //ShowMainMenu();
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
            

            if (File.Exists("DungeonRunner/Saves/Json/" + MyCharacter + ".json") ||
                File.Exists("DungeonRunner/Saves/Txt/" + MyCharacter + ".txt"))
            {
                Console.WriteLine("A Save File with the same Name already exists");
                //ShowMainMenu();
                
            }
            return;


        }

        public void ShowLoadMenu()
        {
            Load load = new Load();
            Console.WriteLine("╔=--------------=°=--------------=╗");
            Console.WriteLine("╠-In which file is your character-╣");
            Console.WriteLine("╚=--------------===--------------=╝");
            string CharName = Console.ReadLine();
            load.CheckIfCharExists(CharName);
            load.LoadCharacter(MyCharacter);
            //ShowMainMenu();
            return;
           
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
            if (Room == null)
            {
                for (int i = 0; i <= Room.Level1; i++)
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

        private void FightMenu(CharClass Abilities)
        {
            MyCharacter.ShowAbility();
            //Iterate through Abilities
            Console.WriteLine("╔=---------=°=--------=╗");
            Console.WriteLine("╠-Choose your Ability:-╣");
            Console.WriteLine("╚=---------===--------=╝");
            string spellname = Console.ReadLine();
            //UseSpell(Spellname)
            //MyCharacter.UseSpell(ability => ability.SpellName == spellname);
            //Option number 1
            //MyCharacter.Where(ability => ability.SpellName == spellname).Foreach(ability => UseSpell(ability));
            //Option number 2
            /*Ability test = Abilities.GetAbilities().FirstOrDefault(x => x.SpellName1 = spellname);
            if (test != null)
            {
                MyCharacter.UseSpell(test);
            }*/
            //Option number 3
            //MyCharacter.Where(Ability => Ability.SpellName1 == spellname).Foreach(ability => UseSpell(ability));
            
            
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
                    MyCharacter.UseItem(item => item.ItemName == item.ItemName);
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