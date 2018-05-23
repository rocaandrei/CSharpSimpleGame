using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGame
{
    abstract class Ship
    {
        public int stamina;
        public int power;
        public string name;
        /// <summary>
        /// With this method we will build our ship.
        /// </summary>
        /// <param name="strength" = is the stamina></param>
        /// <param name="force" = is the power of the hit></param>
        /// <param name="callName" = is the name of the ship></param>
        public abstract void ShipDesign(int strength, int force, string callName);
    }
}
