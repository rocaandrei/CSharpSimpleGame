using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGame
{
    class Bismarck : Ship
    {
        public override void ShipDesign(int life, int force, string callName, int Speed)
        {
            stamina = life;
            power = force;
            name = callName;
            speed = Speed;
        }
    }
}
