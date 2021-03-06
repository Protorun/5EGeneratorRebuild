﻿using System;
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
            Subclass;

        public int Age,
            ProficiencyBonus,
            HitPoints,
            HitDie,
            TotalLevel;

        public Dictionary<string, int> Attributes = new Dictionary<string, int>();
        public Dictionary<string, int> AttributeModifiers = new Dictionary<string, int>();
        public Dictionary<string, int> SubClassLevel = new Dictionary<string, int>();
        public Dictionary<string, int> ClassList = new Dictionary<string, int>();
        public Dictionary<string, string> ClassSubclass = new Dictionary<string, string>();
        public Dictionary<string, int> SavingThrows = new Dictionary<string, int>();
        public List<string> SavingThrowProfs = new List<string>();


        public Character()
        {
            ProficiencyBonus = 2;
        }

        public void SetGender(Character ThisToon, string Gender)
        {
            ThisToon.Gender = Gender;
        }

        public void SetRace(Character ThisToon, string Race)
        {
            ThisToon.Race = Race;
        }

        public void SetupClass(Character ThisToon)
        {
            if(ThisToon.Class == "Barbarian")
            {
                HitDie = 12;
            }
            else if(ThisToon.Class == "Bard")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Cleric")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Druid")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Fighter")
            {
                HitDie = 10;
            }
            else if (ThisToon.Class == "Monk")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Paladin")
            {
                HitDie =10;
            }
            else if (ThisToon.Class == "Ranger")
            {
                HitDie = 10;
            }
            else if (ThisToon.Class == "Rogue")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Sorcerer")
            {
                HitDie = 6;
            }
            else if (ThisToon.Class == "Warlock")
            {
                HitDie = 8;
            }
            else if (ThisToon.Class == "Wizard")
            {
                HitDie = 6;
            }
            else
            {
                HitDie = 0;
            }
        }

        public void SetupRace(Character ThisToon)
        {
            if (ThisToon.Race == "Dragonborn")
            {

            }
            else if (ThisToon.Race == "Dwarf")
            {

            }
            else if (ThisToon.Race == "Elf")
            {

            }
            else if (ThisToon.Race == "Gnome")
            {

            }
            else if (ThisToon.Race == "Half-Elf")
            {

            }
            else if (ThisToon.Race == "Halfling")
            {

            }
            else if (ThisToon.Race == "Half-Orc")
            {

            }
            else if (ThisToon.Race == "Human")
            {

            }
            else if (ThisToon.Race == "Tiefling")
            {

            }
        }

        public void SetupSubrace(Character ThisToon)
        {

        }

        public void SetupAttributeMods(Character ThisToon)
        {
            ThisToon.AttributeModifiers.Clear();
            ThisToon.AttributeModifiers.Add("Strength", CalculateModifier(ThisToon.Attributes["Strength"]));
            ThisToon.AttributeModifiers.Add("Dexterity", CalculateModifier(ThisToon.Attributes["Dexterity"]));
            ThisToon.AttributeModifiers.Add("Constitution", CalculateModifier(ThisToon.Attributes["Constitution"]));
            ThisToon.AttributeModifiers.Add("Intelligence", CalculateModifier(ThisToon.Attributes["Intelligence"]));
            ThisToon.AttributeModifiers.Add("Wisdom", CalculateModifier(ThisToon.Attributes["Wisdom"]));
            ThisToon.AttributeModifiers.Add("Charisma", CalculateModifier(ThisToon.Attributes["Charisma"]));
        }

        public void SetupSaves(Character ThisToon)
        {
            ThisToon.SavingThrows.Clear();
            ThisToon.SavingThrows.Add("Strength", ThisToon.AttributeModifiers["Strength"]);
            ThisToon.SavingThrows.Add("Dexterity", ThisToon.AttributeModifiers["Dexterity"]);
            ThisToon.SavingThrows.Add("Constitution", ThisToon.AttributeModifiers["Constitution"]);
            ThisToon.SavingThrows.Add("Intelligence", ThisToon.AttributeModifiers["Intelligence"]);
            ThisToon.SavingThrows.Add("Wisdom", ThisToon.AttributeModifiers["Wisdom"]);
            ThisToon.SavingThrows.Add("Charisma", ThisToon.AttributeModifiers["Charisma"]);
        }

        public int CalculateModifier(int Attribute)
        {
            int Modifier = (Attribute - 10) / 2;

            if (Attribute < 10)
            {
                Modifier = (int)Math.Floor((Attribute - 10) / 2.0);
            }
            return Modifier;
        }

        public static int RollDice(int MaxValue)
        {
            //int rolls[] = new int[];
            var DiceRoll = new Random();
            var Result = DiceRoll.Next(1, MaxValue);
            return Result;
        }

        public int RollAttribute()
        {
            int[] Rolls = { 0, 0, 0, 0 };
            int Attribute = 0;
            var DiceRoller = new Random();
            for (int i = 0; i < 4; i++)
            {
                int Result = DiceRoller.Next(1, 7);
                Rolls.SetValue(Result, i);
                //Console.WriteLine(Result);		
            }
            Array.Sort(Rolls);
            for (int i = 1; i < Rolls.Length; i++)
            {
                Attribute += Rolls[i];
            }
            //int Modifier = CalcMod(Attribute);
            //Console.WriteLine("Modifier is : " + Modifier);
            return Attribute;
        }

        public int[] RollArray()
        {
            int[] FinalArray = { 0, 0, 0, 0, 0, 0 };

            int[] Rolls = { 0, 0, 0, 0 };
            int Attribute = 0;
            var DiceRoller = new Random();
            for (int x = 0; x < 6; x++)
            {
                for (int i = 0; i < 4; i++)
                {
                    int Result = DiceRoller.Next(1, 7);
                    Rolls.SetValue(Result, i);
                    //Console.WriteLine(Result);
                }
                Array.Sort(Rolls);
                for (int i = 1; i < Rolls.Length; i++)
                {
                    Attribute += Rolls[i];
                }

                FinalArray.SetValue(Attribute, x);
                Attribute = 0;
            }
            return FinalArray;
        }

        public int CalculateTotalLevel(Character ThisToon)
        {
            int Level = 0;
            foreach (var item in ThisToon.ClassList.Values)
            {
                Level =+ item;
            }
            return Level;
        }
    }
}
