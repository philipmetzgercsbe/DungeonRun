namespace DungeonRunner
{
    public class Monster
    {
        private int LP;
        private int DMG;
        private int GoldToDrop;
        private bool isDead;

        public int Lp
        {
            get => LP;
            set => LP = value;
        }

        public int Dmg
        {
            get => DMG;
            set => DMG = value;
        }

        public int GoldToDrop1
        {
            get => GoldToDrop;
            set => GoldToDrop = value;
        }

        public Monster(int lp, int dmg, int goldToDrop)
        {
            LP = lp;
            DMG = dmg;
            GoldToDrop = goldToDrop;
            isDead = false;
        }

        public bool IsDead
        {
            get => isDead;
            set => isDead = value;
        }
    }
}