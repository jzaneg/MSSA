using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Tank : Vehicles
    {
        public Tank()
        {
            this.groundVehicle = "M-1 Abrams Tanks";
            this.serviceBranch = "Army" + "Marines";
            this.strength = "Defense & multi-terrain";
            this.damage = "High";
        }
    }
}
