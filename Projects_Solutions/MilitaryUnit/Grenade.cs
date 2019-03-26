using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Grenade : Weapons
    {
        public Grenade()
        {
            this.weaponName = "Attitude Adjuster";
            this.weaponType = "Grenade";
            this.fireRate = "Single Shot";
            this.dmg = "High";
            this.serviceBranch = ("Marines");
        }
    }
}
