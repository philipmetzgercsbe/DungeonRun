namespace DungeonRunner
{
    public class Ability
    {
        private int ManaCost;
        private int SpellDamage;
        private string SpellName;

        public Ability(int manaCost, int spellDamage, string spellName)
        {
            ManaCost = manaCost;
            SpellDamage = spellDamage;
            SpellName = spellName;
        }

        public int ManaCost1
        {
            get => ManaCost;
            set => ManaCost = value;
        }

        public int SpellDamage1
        {
            get => SpellDamage;
            set => SpellDamage = value;
        }

        public string SpellName1
        {
            get => SpellName;
            set => SpellName = value;
        }
    }
}