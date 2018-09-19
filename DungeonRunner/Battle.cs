using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRunner
{
    interface Battle
    {
        void Attack( Monster monster); //Only used in the Monster Class

        void UseSpell(Ability ability); //Only used in the Character Class

        void CheckHealth(); //Used in Monster and Character
    }
}
