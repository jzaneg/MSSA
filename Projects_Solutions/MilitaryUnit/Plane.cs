using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Plane : Vehicles
    {
        public Plane()
        {
            this.airVehicle = "F-35 Fighter Jets";
            this.serviceBranch = "Air Force";
            this.strength = "Range, payload, & stealth";
            this.damage = "Very High";
        }
    }
}
