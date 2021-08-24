using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eGenRebuild
{
    public class Spell
    {
        int SpellLevel, Range;
        string Name, Description, School, Duration;
        bool IsBonus, Verbal, Somatic, Material;

        public Spell()
        {

        }

        public Spell(int Level, string SpellName, string SpellDesc)
        {
            SpellLevel = Level;
            Name = SpellName;
            Description = SpellDesc;
            Console.WriteLine("Spell created successfully");
        }

        public Spell(int Level, string SpellName, string SpellDesc, string MagicSchool, bool BonusAction, int CastRange, string SpellDuration, bool V, bool S, bool M)
        {
            SpellLevel = Level;
            Name = SpellName;
            Description = SpellDesc;
            School = MagicSchool;
            IsBonus = BonusAction;
            Range = CastRange;
            Duration = SpellDuration;
            Verbal = V;
            Somatic = S;
            Material = M;
        }

        public string AddToSpellbook(Character ThisToon)
        {
            Boolean AddedSuccess;
            AddedSuccess = false;

            if (ThisToon.Spellbook.ContainsKey(this.SpellLevel) == true)
            {
                List<Spell> CurrentSpells = ThisToon.Spellbook[this.SpellLevel];
                List<string> SpellNames = new List<string>();

                foreach (var thing in CurrentSpells)
                {
                    SpellNames.Add(thing.Name);
                }

                if (SpellNames.Contains(this.Name) == false)
                {
                    ThisToon.Spellbook[this.SpellLevel].Add(this);
                    AddedSuccess = true;
                    Console.WriteLine("Spell Level already exists in book");
                }
                else
                {
                    Console.Write("Spell already exists at this level");
                }
                
            }
            else if (ThisToon.Spellbook.ContainsKey(this.SpellLevel) == false)
            {
                List<Spell> SpellList = new List<Spell>();
                SpellList.Add(this);
                ThisToon.Spellbook.Add(this.SpellLevel, SpellList);
                AddedSuccess = true;
                Console.WriteLine("Spell Level doesn't exist in book");
            }


            if (AddedSuccess == true)
            {
                return "Spell successfully added";
            }
            else
            {
                return "Spell addition unsuccessful";
            }
        }

        public string PrintSpell()
        {
            string returnstring = (this.SpellLevel + " - " + this.Name + " - " + this.Description);
            return returnstring;
        }

        public void SetSpellLevel(int Level)
        {
            this.SpellLevel = Level;
        }

        public int GetSpellLevel()
        {
            return this.SpellLevel;
        }

        public void SetSpellName(string Name)
        {
            this.Name = Name;
        }

        public string GetSpellName()
        {
            return this.Name;
        }

        public void SetSpellDesc(string Desc)
        {
            this.Description = Desc;
        }

        public string GetSpellDesc(string Desc)
        {
            return this.Description;
        }
    }
}
