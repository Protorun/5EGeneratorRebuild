using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eGenRebuild
{
    public class Character
    {
        public string FirstName,
            LastName,
            Gender,
            Race,
            SubRace,
            Class,
            SubClass;

        public int Age,
            ProficiencyBonus,
            HitPoints,
            HitDie,
            Level;

        public Dictionary<string, int> SubClassLevel = new Dictionary<string, int>();
        public Dictionary<string, Dictionary<string, int>> ClassList = new Dictionary<string, Dictionary<string, int>>();

        public Character()
        {
            
        }

        public void SetGender(Character ThisToon, string Gender)
        {
            ThisToon.Gender = Gender;
        }

        public void SetRace(Character ThisToon, string Race)
        {
            ThisToon.Race = Race;
        }
    }
}
