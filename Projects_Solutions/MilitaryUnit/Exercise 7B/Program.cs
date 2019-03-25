using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicles = new Vehicles();
            Mission mission = new Mission();

            Console.WriteLine("Commanding Officer: Looks like were headed for another conflict, time to get busy.");
            
            mission.planMission();

            Console.WriteLine("Commanding Officer: What vehicles do you want to bring?");
            Console.WriteLine("Press '1' for plane, '2' for tank, '3' for ship, or '4' for bring everything.");
            int vehicleAnswer = int.Parse(Console.ReadLine());
            if (vehicleAnswer == 1)
            {
                Plane plane = new Plane();
                Console.WriteLine("Great, we'll assemble the {0}. Heres the stats: service branch: {1}, strength: {2}, and damage: {3}.", plane.airVehicle, plane.serviceBranch, plane.strength, plane.damage);
            }
            if (vehicleAnswer == 2)
            {
                Tank tank = new Tank();
                Console.WriteLine("Great, we'll assemble the {0}. Heres the stats: service branch: {1}, strength: {2}, and damage: {3}.", tank.groundVehicle, tank.serviceBranch, tank.strength, tank.damage);
            }
            if (vehicleAnswer == 3)
            {
               Ship ship = new Ship();
                Console.WriteLine("Great, we'll assemble the {0}. Heres the stats: service branch: {1}, strength: {2}, and damage: {3}.", ship.seaVehicle, ship.serviceBranch, ship.strength, ship.damage);
            }
            if (vehicleAnswer == 4)
            {
                Plane plane = new Plane();
                Tank tank = new Tank();
                Ship ship = new Ship();
                Console.WriteLine("Great, you've chosen to bring  {0},  {1}, and {2}...nice.", plane.airVehicle, tank.groundVehicle, ship.seaVehicle);
            }

            Console.WriteLine("Commanding Offier: Alright troops grab your weapons.");
            Console.WriteLine("Which weapons will you be taking?");
            Console.WriteLine("Press '1' for pistol, '2' for rifle, '3' for grenade, or '4' for grab everything.");
            int weaponAnswer = int.Parse(Console.ReadLine());
            if (weaponAnswer == 1)
            {
                Pistol pistol = new Pistol();
                Console.WriteLine("Great, you've chosen a {0}. Heres the stats: weapon name: {1}, weapon type: {2}, and damage: {3}", pistol.weaponName,pistol.weaponType, pistol.fireRate, pistol.dmg);
            }
            if (weaponAnswer == 2)
            {
                Rifle rifle = new Rifle();
                Console.WriteLine("Great, you've chosen a {0}. Heres the stats: weapon name: {1}, weapon type: {2}, and damage: {3}", rifle.weaponName, rifle.weaponType, rifle.fireRate, rifle.dmg);
            }
            if (weaponAnswer == 3)
            {
                Grenade grenade = new Grenade();
                Console.WriteLine("Great, you've chosen a {0}. Heres the stats: weapon name: {1}, weapon type: {2}, and damage: {3}", grenade.weaponType, grenade.weaponName, grenade.fireRate, grenade.dmg);
            }
            if (weaponAnswer == 4)
            {
                Pistol pistol = new Pistol();
                Rifle rifle = new Rifle();
                Grenade grenade = new Grenade();
                Console.WriteLine("Great, you've chosen to bring a {0}, a {1}, and a {2}...nice.", pistol.weaponName, rifle.weaponName, grenade.weaponType);
            }

            Console.WriteLine("Well troops, time to go to war. Good Luck.");
            Console.ReadKey();
        }
    }  
    // Military => AF/ARMY/USN/USM => Mission => Vehicles/Weapons => Plane/Tank/Ship & Pistol/Rifle/Grenade
}



