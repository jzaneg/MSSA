using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Rifle : Weapons
    {
        public Rifle()
        {
            this.weaponName = "M-4";
            this.weaponType = "Rifle";
            this.fireRate = "Automatic";
            this.dmg = "Medium";
            this.serviceBranch = ("Army") + ("Marines");
        }
    }
}
