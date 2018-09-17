using System;
using System.Collections.Generic;

namespace DungeonRunner
{
    public class Trader
    {
        private List<Item> items = new List<Item>();
        private int SellPrice;
        private List<string> PotionName;

        public List<Item> Items
        {
            get => items;
            set => items = value;
        }

        public int SellPrice1
        {
            get => SellPrice;
            set => SellPrice = value;
        }

        public List<string> PotionName1
        {
            get => PotionName;
            set => PotionName = value;
        }

        public Trader(int sellPrice)
        {
            SellPrice = sellPrice;
            PotionName.Add("Health Potion");
            PotionName.Add("Mana Potion");
            for (int i = 0; i < 2; i++)
            {
                items.Add();//Add Potions to Trader
            }
        }

        public void ShowItems()
        {
            foreach (var Potion in items)
            {
                Console.WriteLine("Item: " + Potion);
                //Print all Potions in Inventory 

            }
        }
    }
}