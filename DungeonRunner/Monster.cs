using System;

namespace DungeonRunner
{
    public class Monster : Battle
    {

        private Random rand;
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

        public void Attack(Monster monster)
        {
            monster = this;
            int Damage = rand.Next(DMG, DMG * 2);
            MyCharacter.LP -= Damage;
            //Randomize DMG
            //remove LP from Character
            throw new System.NotImplementedException();
        }

        public void UseSpell(Ability ability)
        {
            //Keep Emoty
            throw new System.NotImplementedException();
        }

        public void CheckHealth()
        {
            if (this.LP == 0)
            {
                this.IsDead = true;
                this.;
            }
            //Set Monster Object to null to create Space for a new Monster

           
        }
    }
}