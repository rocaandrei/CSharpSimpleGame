using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGame
{
    class Bismarck : Ship
    {
        public override void ShipDesign(int strength, int force, string callName)
        {
            stamina = strength;
            power = force;
            name = callName;
        }
    }
}
