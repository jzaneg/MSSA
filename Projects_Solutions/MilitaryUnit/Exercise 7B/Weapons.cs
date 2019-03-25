using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Weapons : Mission
    {
        public string weapon_name;
        public string weapon_type;
        public string fire_rate;
        public string damage;
        public string serviceBranch;

        public string weaponName
        {
            get { return weapon_name; }
            set { weapon_name = value; }
        }
        public string weaponType
        {
            get { return weapon_type; }
            set { weapon_type = value; }
        }
        public string fireRate
        {
            get { return fire_rate; }
            set { fire_rate = value; }
        }
        public string dmg
        {
            get { return damage; }
            set { damage = value; }
        }
    }
}
