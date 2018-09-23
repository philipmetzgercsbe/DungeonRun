using System;

namespace DungeonRunner
{
    public class Monster : Battle
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

        public void Attack(Monster monster,Character character)
        {
            Random rand = new Random();
            monster = this;
            int Damage = rand.Next(DMG, DMG * 2);
            character.Lp -= Damage;
            //Randomize DMG
            //remove LP from Character
            throw new System.NotImplementedException();
        }

        public void UseSpell(Ability ability)
        {
            //Keep Empty
            throw new System.NotImplementedException();
        }

        public void CheckHealth()
        {
            Console.WriteLine(LP);
            if (this.LP == 0)
            {
                this.IsDead = true;
                Console.WriteLine("The Monster died and you earned {0} Gold and gained + {1} Life and Mana",GoldToDrop,LP);
                //should add +=LP to Character and call it here;
                
               
            }

            
            //Set Monster Object to null to create Space for a new Monster

           
        }
    }
}