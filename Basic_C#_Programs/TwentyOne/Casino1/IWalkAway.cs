using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino1.Interfaces
{
    interface IWalkAway //supports multiple inheritances
    {
        void WalkAway(Player player); //method, everything is public in an interface
    }
}
