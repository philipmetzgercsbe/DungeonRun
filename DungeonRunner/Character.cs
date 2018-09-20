using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DungeonRunner
{
    public class Character : Buy , Battle
    {
        private Trader Trader;
        private CharClass CharClass;
        private List<Item> Items = new List<Item>();
        private string Name;
        private int Age;
        private int LP= 10;
        private int MP = 10;
        private int Gold = 0;
        private int CharAtRoom = 0;
        private bool Dead;

        

        public void ReturnName()
        {
            Console.WriteLine(Name);
        }

        public Character()
        {
        }

        public Character(string name, int age, string ClassName)
        {
            
            Name = name;
            Age = age;
            CharClass = new CharClass(ClassName);
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public int Age1
        {
            get => Age;
            set => Age = value;
        }

        public int Lp
        {
            get => LP;
            set => LP = value;
        }

        public int Mp
        {
            get => MP;
            set => MP = value;
        }

        public int Gold1
        {
            get => Gold;
            set => Gold = value;
        }

        public int CharAtRoom1
        {
            get => CharAtRoom;
            set => CharAtRoom = value;
        }

        public bool Dead1
        {
            get => Dead;
            set => Dead = value;
        }

        public List<Item> ShowItems()
        {
            return this.Items;
        }

        public int ShowLifePoints()
        {
            return this.LP;
        }

        public int ShowManaPoints()
        {
            return this.MP;
        }

        public int ShowCurrentGold()
        {
            return this.Gold;
        }

       
        public void BuyItem(Item item)
        {
            if (Items.Count >= 2 && item.ItemName1 == "Health Potion")
            {
                for (int i = 0; i < Items.Count; i++)
                {
                   var ItemsToReplace = Items.Find(Item => Item.ItemName1 == item.ItemName1);
                    Items.Remove(ItemsToReplace);
                    Items.Add(new Item("Health Potion",Trader.SellPrice1));
                    this.Gold -= Trader.SellPrice1;
                }
                //Remove Item with the Name and re-add it with new values
            }else if (Items.Count >= 2 && item.ItemName1 == "Mana Potion")
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var ItemsToReplace = Items.Find(Item => Item.ItemName1 == item.ItemName1);
                    Items.Remove(ItemsToReplace);
                    Items.Add(new Item("Mana Potion", Trader.SellPrice1));
                    this.Gold -= Trader.SellPrice1;
                }
            }
            else
            {
                Items.Add(item);
                this.Gold -= Trader.SellPrice1;  //Item Cost from Trader
            }
            
        }

        public void UseItem(Item item)
        {
            
            if (Items.Contains(item))
            {
                
                Item usedItem = this.Items.Find(Item => Item.ItemName1 == item.ItemName1);
                if (usedItem.ItemName1 == "Health Potion")
                {
                    this.LP += usedItem.Restore1;
                }else if (usedItem.ItemName1 == "Mana Potion")
                {
                    this.MP += usedItem.Restore1;
                }
                RemoveItem(item);
                
                
               
            }
        }

        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
        }

        public void Attack(Character character, Monster monster)
        {
            //Randomize DMG
            //remove LP from Character
            throw new NotImplementedException();
        }

        public void UseSpell(Ability ability)
        {
            var SpellToUse = this.CharClass.GetAbilities();
            //Get all Abilites
            this.CharClass.GetAbilities();
            if (this.MP == 0)
            {
                Console.WriteLine("You cannot use advanced Abilities, drink a Mana Potion to restore Mana");
                var UsedSpell = SpellToUse.First();
                this.MP -= UsedSpell.ManaCost1; //This line is unnecessary because the first spell costs nothing

            }
            else if(this.MP >= 0)
            {
               
                var UsedSpell = SpellToUse.Find(abilityName => abilityName.SpellName1 == ability.SpellName1);
                this.MP -= UsedSpell.ManaCost1;

            }
            
            //Access Ability list and get MPCost and remove LP from Monster and Mana from Character
            
        }

        public void CheckHealth()
        {
            if (LP == 0)
            {
                Dead = true;
                Console.WriteLine("You died");
            }
             
        }

      

        public void Attack(Monster monster, Character character)
        {
            //Keep Empty
            throw new NotImplementedException();
        }

        public void ShowAbility()
        {

            var MyCharAbilites = this.CharClass.GetAbilities();
            foreach (var Ability in MyCharAbilites)
            {
                Console.WriteLine("Ability:",Ability);   
            }


        }
    }
    
}