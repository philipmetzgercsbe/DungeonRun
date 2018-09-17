using System.Collections.Generic;

namespace DungeonRunner
{
    public class CharClass
    {
        private Dictionary<string, List<Ability>> Abilities = new Dictionary<string, List<Ability>>();
        private string Name;
        //All Ability names and saved in an Array. Will be used to create Classes with for loop
        private string[] _MageAbilities = {"Use Wand", "Fireball", "Frostbolt", "Pyroblast"}; //[0] is basic, [1] a weak Ability, [2] is the mediocre Ability and [3] is the strongest
        private string[] _RogueAbilities = {"Stab", "Eviscerate", "Hack and Slash", "Assasinate"};
        private string[] _RangerAbilities = {"Fire Arrow", "Toxic Arrow", "Arcane Shot", "Explosive Shot"};
        private string[] _BarbarianAbilites = {"Swing Axe", "Charge", "Cleave", "Execute"};
        private static int[] _ManaCost = {0,2,5,10};
        private static int[] _AbilityDMG = {1, 2, 5, 10};

        public CharClass()
        {
            
        }
        public CharClass(string name)
        {
            List<Ability> RangerAbilitiesList = new List<Ability>();
            List<Ability> MageAbilitiesList = new List<Ability>();
            List<Ability> RogueAbilitesList = new List<Ability>();
            List<Ability> BarbarianAbilitiesList = new List<Ability>();
            Name = name;
            if (name == "Ranger")   // Check Classname and their Abilites. 
            {
                
                for (int i = 0; i <= _RangerAbilities.Length; i++)
                {
                   
                    RangerAbilitiesList.Add(new Ability(_ManaCost[i], _AbilityDMG[i], _RangerAbilities[i]));
                    //General ClassName Abilitygenerationblock 
                    Abilities.Add(_RangerAbilities[i], RangerAbilitiesList); 
                }
            }
            else if (name == "Mage")
            {
                for (int i = 0; i <= _MageAbilities.Length; i++)
                {
                    MageAbilitiesList.Add(new Ability(_ManaCost[i], _AbilityDMG[i], _MageAbilities[i]));
                    Abilities.Add(_MageAbilities[i], MageAbilitiesList);
                }

            }
            else if (name == "Rogue")
            {
                for (int i = 0; i <= _RogueAbilities.Length; i++)
                {
                    RogueAbilitesList.Add(new Ability(_ManaCost[i], _AbilityDMG[i], _RogueAbilities[i]));   
                    Abilities.Add(_RogueAbilities[i], RogueAbilitesList);
                }

            }
            else if (name == "Barbarian")
            {
                for (int i = 0; i <= _BarbarianAbilites.Length; i++)
                {
                    BarbarianAbilitiesList.Add(new Ability(_ManaCost[i], _AbilityDMG[i], _BarbarianAbilites[i]));
                    Abilities.Add(_BarbarianAbilites[i], BarbarianAbilitiesList);
                }

            }
        }
            
        
    }
}