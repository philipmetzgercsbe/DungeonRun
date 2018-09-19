using System;
using System.Collections.Generic;

namespace DungeonRunner
{
    public class Trader : Buy
    {
        private List<Item> TraderItems = new List<Item>();
        private int SellPrice;
        private List<string> PotionName;

        public List<Item> Items
        {
            get => TraderItems;
            set => TraderItems = value;
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
                TraderItems.Add(new Item(PotionName.Find("Health Potion"),));//Add Potions to Trader
            }
        }

        public void ShowItems()
        {
            foreach (var item in TraderItems)
            {
                Console.WriteLine("Item: " + item);
                //Print all Potions in Inventory 

            }
        }

        public void BuyItem(Item item)
        {
            //Keep Method empty
            return;
        }

        public void UseItem(Item item)
        {
            //Keep Method empty
            return;
            
        }

        public void RemoveItem(Item item)
        {
            //remove Item from Trader
            TraderItems.Remove(item);
            throw new NotImplementedException();
        }
    }
}