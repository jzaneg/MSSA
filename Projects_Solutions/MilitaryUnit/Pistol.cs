using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Pistol : Weapons
    {
        public Pistol()
        {
            this.weaponName = "Glock";
            this.weaponType = "Pistol";
            this.fireRate = "Single Shot";
            this.dmg = "Low";
            this.serviceBranch = "Air Force" + "Navy";
        }
    }
}
