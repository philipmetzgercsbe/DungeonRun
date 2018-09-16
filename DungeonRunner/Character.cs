using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DungeonRunner
{
    public class Character
    {
      
        List<CharClass> CharClass=  new List<CharClass>();
        private List<Item> Item = new List<Item>();
        private string Name;
        private int Age;
        private int LP= 100;
        private int MP = 0;
        private int Gold = 0;
        private int CharAtRoom = 0;
        private bool Dead;

        public void ReturnName()
        {
            Console.WriteLine(Name);
        }
        public Character(string name, int age)
        {
            Name = name;
            Age = age;
            
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

        public List<string> getItems()
        {
            foreach (var ownedItem in Item)
            {
                Console.WriteLine("You have in your inventory",ownedItem);
            }
        }
    }
    
}