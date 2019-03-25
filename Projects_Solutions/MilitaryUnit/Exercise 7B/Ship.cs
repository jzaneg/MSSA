using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Ship : Vehicles
    {
        public Ship()
        {
            this.seaVehicle = "Aircraft Carriers";
            this.serviceBranch = "Navy";
            this.strength = "Range, ability to carry other vehicles, & firepower";
            this.damage = "Very High";
        }
    }
}
