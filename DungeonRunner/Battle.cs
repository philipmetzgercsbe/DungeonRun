using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRunner
{
    interface Battle
    {
        void Attack();

        void UseSpell();

        void CheckHealth();
    }
}
