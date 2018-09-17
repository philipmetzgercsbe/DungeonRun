using System;

namespace DungeonRunner
{
    public class Room
    {
        
        /*Character Character*/
        /*Random random*/
        private int Round;
        private static int Level;
        private int StatsAfterVictory;

        public Room(int level, int statsAfterVictory)
        {
            Monster Enemy = new Monster(statsAfterVictory,statsAfterVictory,statsAfterVictory+2);
            Level = level;
            StatsAfterVictory = statsAfterVictory;
            if (Enemy.IsDead == true)
            {
                IncrementLevel();
            }
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
            Level++;
        }

        private void SpawnTrader()
        {
            Random rand = new Random();
            if (Level == rand.Next(1, 10))
            {
             Trader Trader = new Trader(Math.Abs(StatsAfterVictory/2));   
            }
        }
    }
}