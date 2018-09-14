namespace DungeonRunner
{
    public class Item
    {
        private string ItemName;
        private int Restore;

        public string ItemName1
        {
            get => ItemName;
            set => ItemName = value;
        }

        public int Restore1
        {
            get => Restore;
            set => Restore = value;
        }

        public Item(string itemName, int restore)
        {
            ItemName = itemName;
            Restore = restore;
        }
    }
}