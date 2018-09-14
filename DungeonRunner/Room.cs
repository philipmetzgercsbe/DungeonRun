namespace DungeonRunner
{
    public class Room
    {
        /*Monster Monster*/
        /*Character Character*/
        /*Trader trader*/
        /*Random random*/
        private int Round;
        private int Level;
        private int StatsAfterVictory;

        public Room(int level, int statsAfterVictory)
        {
            Level = level;
            StatsAfterVictory = statsAfterVictory;
        }

        public int Round1
        {
            get => Round;
            set => Round = value;
        }

        public int Level1
        {
            get => Level;
            set => Level = value;
        }

        public int StatsAfterVictory1
        {
            get => StatsAfterVictory;
            set => StatsAfterVictory = value;
        }
    }
}