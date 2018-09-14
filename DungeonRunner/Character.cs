namespace DungeonRunner
{
    public class Character
    {
      

        //List<CharClass> class = List<CharClass>;
        /*private List<T> class
        private List<T> Item*/
        private string Name;
        private int Age;
        private int LP;
        private int MP;
        private int Gold;
        private int CharAtRoom;
        private bool Dead;
        
        public Character(string name, int age, int lp, int mp)
        {
            Name = name;
            Age = age;
            LP = lp;
            MP = mp;
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
    }
    
}