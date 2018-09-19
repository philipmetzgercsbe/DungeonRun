using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRunner
{
    interface Buy
    {
        
        void BuyItem(Item item);

        void UseItem(Item item);

        void RemoveItem(Item item);
    }
}
