using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DungeonRunner
{
    public class Character : Buy , Battle
    {
      
        
        private List<Item> Item = new List<Item>();
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
            CharClass CharClass=  new CharClass();
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

        public void ShowItems()
        {
            foreach (var ownedItem in Item)
            {
                Console.WriteLine("You have in your inventory",ownedItem);
            }
        }

        public void ShowLifePoints()
        {
            Console.WriteLine(this.LP);    
        }

        public void ShowManaPoints()
        {
            Console.WriteLine(this.MP);
        }

        public void ShowCurrentGold()
        {
            Console.WriteLine(this.Gold);   
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void UseSpell()
        {
            throw new NotImplementedException();
        }

        public void CheckHealth()
        {
            throw new NotImplementedException();
        }

        public void buy()
        {
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem()
        {
            throw new NotImplementedException();
        }
    }
    
}