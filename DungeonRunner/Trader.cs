using System;
using System.Collections.Generic;

namespace DungeonRunner
{
    public class Trader : Buy
    {
        private List<Item> TraderItems = new List<Item>();
        private int SellPrice;
        private string[] PotionName = {"Health Potion", "Mana Potion"};

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

        public string[] PotionName1
        {
            get => PotionName;
            set => PotionName = value;
        }

        public Trader(int sellPrice)
        {
            SellPrice = sellPrice;
            for (int i = 0; i < 2; i++)
            {
                TraderItems.Add(new Item(PotionName[i],sellPrice));//Add Potions to Trader
            }
        }

        public void ShowItems()
        {
            foreach (var item in TraderItems)
            {
                //Print all Potions in Inventory 
                Console.WriteLine("Item: " + item);
                

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
            
        }
    }
}