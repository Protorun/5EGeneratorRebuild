using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eGenRebuild
{
    public class Feat
    {
        string Name, Description, StatMod;
        int ModValue;
        bool IsPassive;

        public Feat()
        {

        }

        public Feat(string FeatName, string FeatDesc)
        {
            Name = FeatName;
            Description = FeatDesc;
            IsPassive = true;
            StatMod = null;
            ModValue = 0;
        }

        public Feat(string FeatName, string FeatDesc, string Stat, int StatValue)
        {
            Name = FeatName;
            Description = FeatDesc;
            IsPassive = false;
            StatMod = Stat;
            ModValue = StatValue;
        }

        public string AddToFeatList (Character ThisToon)
        {
            List<string> FeatNames = new List<string>();
            foreach (var thing in ThisToon.FeatList)
            {
                FeatNames.Add(thing.Name);
            }

            if (FeatNames.Contains(this.Name) == false)
            {
                ThisToon.FeatList.Add(this);
                Console.WriteLine("Feat added to character");
            }
            else if (FeatNames.Contains(this.Name) == true)
            {
                Console.WriteLine("Character already has this feat");
            }
            Console.WriteLine("Feat operation complete");
            return "Feat successfully added";
        }

        public string GetFeatName()
        {
            return this.Name;
        }

        public string GetFeatDesc()
        {
            return this.Description;
        }

        public bool GetFeatPassive()
        {
            return this.IsPassive;
        }

        public string GetFeatStat()
        {
            return this.StatMod;
        }

        public int GetFeatModValue()
        {
            return this.ModValue;
        }
    }
}
