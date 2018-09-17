using System;

namespace DungeonRunner
{
    public class Room
    {
        /*Monster Monster*/
        /*Character Character*/
        /*Random random*/
        private int Round;
        private int Level;
        private int StatsAfterVictory;

        public Room(int level, int statsAfterVictory)
        {
            Level = level;
            StatsAfterVictory = statsAfterVictory;
            IncrementLevel();
            SpawnTrader();
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

        private void IncrementLevel()
        {
            this.Level++;
        }

        private void SpawnTrader()
        {
            Random rand = new Random();
            for (int i = 0; i < this.Level; i++)
            {
                //Trader trader = new Trader(); Figure out 
                
            }
        }
    }
}