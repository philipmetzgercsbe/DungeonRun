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

        public Trader(int sellPrice, List<string> potionName)
        {
            SellPrice = sellPrice;
            PotionName = potionName;
        }
    }
}