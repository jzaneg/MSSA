using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Branches : Military
    {
        public void AirForce()
        {
            this.personnel = "Airman";
            this.operational_area = "Air";
        }
        string rank = "";
        string name = "";
        public string[] AirForceRank = { "Airman Basic", "Airman", "Airman First Class", "Senior Airman", "Staff Sergeant", "Technical Sergeant", "Master Sergeant", "Senoir Master Sergeant", "Chief Master Sergenat" };
        public void callAF()
        {
            this.battle_cry = "Hooah";
            Random rdm = new Random();
            rank = AirForceRank.ElementAt(rdm.Next(AirForceRank.Length - 1));
            Console.WriteLine("Commanding Officer: what's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"{rank} {name}, reporting for duty.");
            Console.WriteLine($"Commanding Officer: {name} are you ready for battle?");
            Console.WriteLine("For 'yes' enter 'y' and for 'no' enter 'n'.");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y')
            {
                Console.WriteLine("Commanding Officer: Good, let's get going.");
                Console.WriteLine($"{rank} {name}: {battle_cry} !");
            }
            else if (response == 'n')
            {
                Console.WriteLine($"Commanding Officer: Too bad {name}, you're country needs you.");
                Console.WriteLine($"{battle_cry} ....");
            }
        }
        //call method to grab weapon
        //AF would grab Pistol
        //call method to assemble vehicles
        //AF would assemble Plane

        public void Army()
        {
            this.personnel = "Soldier";
            this.operational_area = "Land";
        }

        private string[] ArmyRank = { "Private", "Private Second Class", "Private First Class", "Specialist", "Corporal", "Sergeant", "Staff Sergeant", "Sergeant First Class", "Master Sergeant", "First Sergeant", "Sergenat Major" };
        public void callArmy()
        {
            this.battle_cry = "Hooah";
            Random rdm = new Random();
            rank = ArmyRank.ElementAt(rdm.Next(ArmyRank.Length - 1));
            Console.WriteLine("Commanding Officer: what's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"{rank} {name}, reporting for duty.");
            Console.WriteLine($"Commanding Officer: {name} are you ready for battle?");
            Console.WriteLine("For 'yes' enter 'y' and for 'no' enter 'n'.");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y')
            {
                Console.WriteLine("Commanding Officer: Good, let's get going.");
                Console.WriteLine($"{rank} {name}: {battle_cry} !");
            }
            else if (response == 'n')
            {
                Console.WriteLine($"Commanding Officer: Too bad {name}, you're country needs you.");
                Console.WriteLine($"{battle_cry} ....");
            }
        }
        //call method to grab weapon
        //AF would grab Rifle
        //call method to assemble vehicles
        //AF would assemble Tank

        public void Navy()
        {
            this.personnel = "Seaman";
            this.operational_area = "Land";
        }

        private string[] NavyRank = { "Seaman Recruit", "Seaman Apprentice", "Seaman", "Senior Airman", "Petty Officer Third Class", "Petty Officer Second Class", "Petty Officer First Class", "Chief Petty Officer", "Senior Chief Petty Officer", "Master Chief Petty Officer" };
        public void callUSN()
        {
            this.battle_cry = "Hooyah";
            Random rdm = new Random();
            rank = NavyRank.ElementAt(rdm.Next(NavyRank.Length - 1));
            Console.WriteLine("Commanding Officer: what's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"{rank} {name}, reporting for duty.");
            Console.WriteLine($"Commanding Officer: {name} are you ready for battle?");
            Console.WriteLine("For 'yes' enter 'y' and for 'no' enter 'n'.");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y')
            {
                Console.WriteLine("Commanding Officer: Good, let's get going.");
                Console.WriteLine($"{rank} {name}: {battle_cry} !");
            }
            else if (response == 'n')
            {
                Console.WriteLine($"Commanding Officer: Too bad {name}, you're country needs you.");
                Console.WriteLine($"{battle_cry} ....");
            }
        }
        //call method to grab weapon
        //AF would grab Pistol
        //call method to assemble vehicles
        //AF would assemble Ship

        public void Marines()
        {
            this.personnel = "Marine";
            this.operational_area = "Land";
        }

        private string[] MarinesRank = { "Private", "Private First Class", "Lance Corporal", "Corporal", "Sergeant", "Staff Sergeant", "Gunnery Sergeant", "Master Sergeant", "First Sergeant", "Master Gunnery Sergeant", "Sergeant Major" };
        public void callUSM()
        {
            this.battle_cry = "Hoorah";
            Random rdm = new Random();
            rank = MarinesRank.ElementAt(rdm.Next(MarinesRank.Length - 1));
            Console.WriteLine("Commanding Officer: what's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"{rank} {name}, reporting for duty.");
            Console.WriteLine($"Commanding Officer: {name} are you ready for battle?");
            Console.WriteLine("For 'yes' enter 'y' and for 'no' enter 'n'.");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y')
            {
                Console.WriteLine("Commanding Officer: Good, let's get going.");
                Console.WriteLine($"{rank} {name}: {battle_cry} !");
            }
            else if (response == 'n')
            {
                Console.WriteLine($"Commanding Officer: Too bad {name}, you're country needs you.");
                Console.WriteLine($"{battle_cry} ....");
            }
        }
        //call method to grab weapon
        //AF would grab Rifle + Grenade
        //call method to assemble vehicles
        //AF would assemble Tank

    }
}

