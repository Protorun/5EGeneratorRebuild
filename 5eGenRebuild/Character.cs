using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eGenRebuild
{
    class Character
    {
        string FirstName,
            LastName,
            Gender,
            Race,
            SubRace,
            Class,
            SubClass;

        int Age,
            ProficiencyBonus,
            HitPoints,
            HitDie,
            Level;

        public Dictionary<string, int> SubClassLevel = new Dictionary<string, int>();
        public Dictionary<string, Dictionary<string, int>> ClassList = new Dictionary<string, Dictionary<string, int>>();

        public Character()
        {

        }
    }
}
