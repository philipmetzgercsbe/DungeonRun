using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRunner
{
    interface Buy
    {
        
        void BuyItem(Item item); //Used in Character

        void UseItem(Item item); //Used in Character

        void RemoveItem(Item item); //Used in Character and Trader
    }
}
