using System;
using System.Security.Cryptography.X509Certificates;

namespace DungeonRunner
{
    public class Room
    {
        public Trader Trader;
        public Monster Enemy;
        public Character MyCharacter;
        Random rand = new Random();
        public int Round;
        private static int Level;
        private int StatsAfterVictory;

        public Room(int level, int statsAfterVictory)
        {
            Enemy = new Monster(statsAfterVictory,statsAfterVictory,statsAfterVictory+2);
            Level = level;
            StatsAfterVictory = statsAfterVictory;
            SpawnTrader();
            IncrementLevel();
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
          
            if (Level >= 1 && Level <= 200 && rand.Next(1,10) < 5)
            {
              Trader = new Trader(Math.Abs(StatsAfterVictory/2));   
            }
        }

        private void GetRoundPlayer()
        {
            if (Round % 2 == 0)
            {
                
                this.Round++;
            }else if (Round % 2 == 1)
            {
                Enemy.Attack(Enemy,MyCharacter);
                this.Round++;
            }
        }

        public bool isDone()
        {
            if (Enemy.IsDead == true )
            {
                Enemy = null;
                Trader = null;

                this.MyCharacter.Lp += Enemy.Lp;
                this.MyCharacter.Mp += Enemy.Lp;
                return true;

            }

            return false;
        }
    }
}