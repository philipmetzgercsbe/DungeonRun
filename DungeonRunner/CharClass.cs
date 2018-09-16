using System.Collections.Generic;

namespace DungeonRunner
{
    public class CharClass
    {
        private Dictionary<string, List<Ability>> Abilities = new Dictionary<string, List<Ability>>();
        private string Name;
        //All Ability names and saved in an Array. Will be used to create Classes with for loop
        private string[] _MageAbilities = {"Use Wand", "Fireball", "Frostbolt", "Pyroblast"}; //[0] is basic, [1] a weak Ability, [2] is the mediocre Ability and [3] is the strongest
        private string[] _RogueAbilities = {"Stab", "Eviscerate", "Hack and Slash", "Assasination"};
        private string[] _RangerAbilities = {"Fire Arrow", "Toxic Arrow", "Arcane Shot", "Explosive Shot"};
        private string[] _BarbarianAbilites = {"Swing Axe", "Charge", "Cleave", "Execute"};
        private static int[] _ManaCost = {0,2,5,10};
        private static int[] _AbilityDMG = {1, 2, 5, 10};


        public CharClass(string name)
        {
            Name = name;
            if (name == "Ranger")   // Check Classname and their Abilites. 
            {
                for (int i = 0; i <= _RangerAbilities.Length; i++)
                {
                    //General ClassName Abilitygenerationblock will need to figure out how to add the Ability to the list
                   // Abilities.Add(_RangerAbilities[i], new Ability(_ManaCost[i], _AbilityDMG[i], _RangerAbilities[i])); 
                }
            }else if (name == "Mage")
            {

            }else if (name == "Rogue")
            {

            }
        }
            
        
    }
}