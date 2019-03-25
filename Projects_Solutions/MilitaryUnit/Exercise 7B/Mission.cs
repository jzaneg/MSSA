using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B
{
    class Mission : Branches
    {
        public string air_campaign;
        public string ground_invasion;
        public string sea_invasion;
        public string urban_invasion;

        public string airCampaignMission
        {
            get { return air_campaign; }
            set { air_campaign = value; }
        }
        public string groundInvasionMission
        {
            get { return ground_invasion; }
            set { ground_invasion = value; }
        }
        public string seaInvasionMission
        {
            get { return sea_invasion; }
            set { sea_invasion = value; }
        }
        public string urbanConflictMission
        {
            get { return urban_invasion; }
            set { urban_invasion = value; }
        }

        public string planMission()
        {
            this.airCampaignMission = "air campaign";
            this.groundInvasionMission = "ground invasion";
            this.seaInvasionMission = "sea invasion";
            this.urbanConflictMission = "urban conflict invasion";

            string battle = "";
            string[] missions = { airCampaignMission, groundInvasionMission, seaInvasionMission, urbanConflictMission };
            Random rdm = new Random();
            battle = missions.ElementAt(rdm.Next(missions.Length));

            if (battle == missions[0])
            {
                Console.WriteLine("Commanding Officer: This looks like an aerial battle. Looks like were going to have to call in the Air Force.");
                callAF();
            }
            else if (battle == missions[1])
            {
                Console.WriteLine("Commanding Officer: This looks like an all out ground war. Looks like were going to have to call in the Army.");
                callArmy();
            }
            else if (battle == missions[2])
            {
                Console.WriteLine("Commanding Officer: This looks like a sea battle. Looks like were going to have to call in the Navy.");
                callUSN();
            }
            else if (battle == missions[3])
            {
                Console.WriteLine("Commanding Officer: This looks like an urban conflict. Looks like were going to have to call in the Marines.");
                callUSM();
            }
            return battle;
        }
    }
}
