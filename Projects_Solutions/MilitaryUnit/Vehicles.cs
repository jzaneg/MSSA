using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Vehicles : Mission
    {
        public string air;
        public string ground;
        public string sea;
        public string serviceBranch;
        public string strength;
        public string damage;


        public string airVehicle
        {
            get { return air; }
            set { air = value; }
        }
        public string groundVehicle
        {
            get { return ground; }
            set { ground = value; }
        }
        public string seaVehicle
        {
            get { return sea; }
            set { sea = value; }
        }
    }
}
