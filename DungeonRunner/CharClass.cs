using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace DungeonRunner
{
    public class CharClass
    {
        private Dictionary<string,Ability> Abilities = new Dictionary<string, Ability>();
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
            
            Name = name;
            if (Name == "Ranger")   // Check Classname and their Abilites. 
            {
                
                for (int i = 0; i <= _RangerAbilities.Length-1; i++)
                {
                    //General ClassName Abilitygenerationblock 
                    Abilities.Add(_RangerAbilities[i] ,new Ability(_ManaCost[i], _AbilityDMG[i], _RangerAbilities[i])); 
                }
            }
            else if (Name == "Mage")
            {
                for (int i = 0; i <= _MageAbilities.Length-1; i++)
                {
                    
                    Abilities.Add(_MageAbilities[i],new Ability(_ManaCost[i], _AbilityDMG[i], _MageAbilities[i]) );
                }

            }
            else if (Name == "Rogue")
            {
                for (int i = 0; i <= _RogueAbilities.Length-1; i++)
                {
                   
                    Abilities.Add(_RogueAbilities[i], new Ability(_ManaCost[i], _AbilityDMG[i], _RogueAbilities[i]));
                }

            }
            else if (Name == "Barbarian")
            {
                for (int i = 0; i <= _BarbarianAbilites.Length-1; i++)
                {
                    
                    Abilities.Add(_BarbarianAbilites[i], new Ability(_ManaCost[i], _AbilityDMG[i], _BarbarianAbilites[i]));
                }

            }
        }

        public List<Ability> GetAbilities()
        {
            
            return Abilities.Select(kvp => kvp.Value).ToList();



        }


        public string GetName()
        {
            return this.Name;
        }    
        
    }
}