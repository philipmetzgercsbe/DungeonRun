using System.Collections.Generic;

namespace DungeonRunner
{
    public class CharClass
    {
        private Dictionary<string, List<Ability>> Abilities = new Dictionary<string, List<Ability>>();
        private string Name;

        public CharClass(string name)
        {
            
            Name = name;
        }
            
        
    }
}