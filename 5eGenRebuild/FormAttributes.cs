using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eGenRebuild
{
    public partial class FormAttributes : Form
    {
        Character ThisToon;
        int Str, Dex, Con, Int, Wis, Cha;
        int StrMod, DexMod, ConMod, IntMod, WisMod, ChaMod;
        int RaceStr, RaceDex, RaceCon, RaceInt, RaceWis, RaceCha;
        int TotalStr, TotalDex, TotalCon, TotalInt, TotalWis, TotalCha;
        int Points;
        Dictionary<string, int> SavedRolls = new Dictionary<string, int>();
        Dictionary<string, int> PointBuy = new Dictionary<string, int>();
        List<ComboBox> ArrayBoxes = new List<ComboBox>();
        List<NumericUpDown> PointBuyBoxes = new List<NumericUpDown>();
        string[] DefaultValues = { "15", "14", "13", "12", "10", "8" };

        public FormAttributes(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            SavedRolls.Add("Str", 0);
            SavedRolls.Add("Dex", 0);
            SavedRolls.Add("Con", 0);
            SavedRolls.Add("Int", 0);
            SavedRolls.Add("Wis", 0);
            SavedRolls.Add("Cha", 0);

            PointBuy.Add("8", 0);
            PointBuy.Add("9", 1);
            PointBuy.Add("10", 2);
            PointBuy.Add("11", 3);
            PointBuy.Add("12", 4);
            PointBuy.Add("13", 5);
            PointBuy.Add("14", 7);
            PointBuy.Add("15", 9);
            PointBuy.Add("16", 11);
            PointBuy.Add("17", 13);
            PointBuy.Add("18", 15);

            ArrayBoxes.Add(ComboStr);
            ArrayBoxes.Add(ComboDex);
            ArrayBoxes.Add(ComboCon);
            ArrayBoxes.Add(ComboInt);
            ArrayBoxes.Add(ComboWis);
            ArrayBoxes.Add(ComboCha);

            PointBuyBoxes.Add(CounterStr);
            PointBuyBoxes.Add(CounterDex);
            PointBuyBoxes.Add(CounterCon);
            PointBuyBoxes.Add(CounterInt);
            PointBuyBoxes.Add(CounterWis);
            PointBuyBoxes.Add(CounterCha);

            Str = Dex = Con = Int = Wis = Cha = 8;
            RaceStr = RaceDex = RaceCon = RaceInt = RaceWis = RaceCha = 0;

            if (ThisToon.Race == "Half-Elf")
            {
                lblHalfElfStats.Visible = true;
                ComboRace1.Visible = true;
                ComboRace2.Visible = true;
            }

            CalculateRacialBonus();
            UpdateLabels();

            TxtDisplayInfo.Text = @"Strength:
Used to calculate the attack bonus (AB) and bonus damage of most melee and thrown weapons. If the Dungeon Master (DM) keeps track of carrying capacity, strength also dictates the amount of weight a character can carry.

    Associated skills:
    Athletics

Dexterity:
Used to calculate the attack bonus (AB) and bonus damage of most ranged weapons and some melee weapons (provided they have the finesse quality). Dexterity is also used to calculate armour class (AC) and initiative modifier.

    Associated skills:
    Acrobatics
    Sleight of Hand
    Stealth

Intelligence:
Used by Wizards to calculate the difficulty check (DC) and attack bonus of their spells.

    Associated skills:
    Arcana
    History
    Investigation
    Nature
    Religion

Wisdom:
Used by Clerics, Druids and Rangers to calculate the difficulty check (DC) and attack bonus of their spells. Also used by Monks to calculate the difficulty check (DC) of some of their abilities.

    Associated skills:
    Animal Handling
    Insight
    Medicine
    Perception
    Survival

Charisma:
Used by Bards, Paladins, Sorcerers and Warlocks to calculate the difficulty check (DC) and attack bonus of their spells.

    Associated skills:
    Deception
    Intimidation
    Performance
    Persuasion";
        }

        private void ComboRace1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurrentSelection1 = ComboRace1.GetItemText(ComboRace1.SelectedItem);
            string CurrentSelection2 = ComboRace2.GetItemText(ComboRace2.SelectedItem);
            if (CurrentSelection1 == CurrentSelection2)
            {
                MessageBox.Show("Please select two unique attributes", "Same attribute selected twice");
                ComboRace2.Text = "";
            }
            else
            {
                SetHalfElfBonus();
            }
        }

        private void ComboRace2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurrentSelection1 = ComboRace1.GetItemText(ComboRace1.SelectedItem);
            string CurrentSelection2 = ComboRace2.GetItemText(ComboRace2.SelectedItem);
            if (CurrentSelection2 == CurrentSelection1)
            {
                MessageBox.Show("Please select two unique attributes", "Same attribute selected twice");
                ComboRace1.Text = "";
            }
            else
            {
                SetHalfElfBonus();
            }
        }

        private void CheckOptions()
        {
            foreach (var firstthing in ArrayBoxes)
            {
                if (firstthing.SelectedItem == null)
                {
                    firstthing.Items.Clear();
                    firstthing.Items.AddRange(DefaultValues);
                }
            }
            foreach (var thing in ArrayBoxes)
            {                
                foreach (var nextthing in ArrayBoxes)
                {
                    if (thing == nextthing)
                    {

                    }
                    else if (thing.SelectedItem != null)
                    {
                        if (nextthing.Items.Contains(thing.SelectedItem))
                        {
                            nextthing.Items.Remove(thing.SelectedItem);
                        }
                    }
                }
            }
        }

        private void ComboStr_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Str = Convert.ToInt32(ComboStr.SelectedItem.ToString());
            UpdateLabels();
        }

        private void ComboDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Dex = Convert.ToInt32(ComboDex.SelectedItem.ToString());
            UpdateLabels();
        }

        private void ComboCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Con = Convert.ToInt32(ComboCon.SelectedItem.ToString());
            UpdateLabels();
        }

        private void ComboInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Int = Convert.ToInt32(ComboInt.SelectedItem.ToString());
            UpdateLabels();
        }

        private void ComboWis_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Wis = Convert.ToInt32(ComboWis.SelectedItem.ToString());
            UpdateLabels();
        }

        private void ComboCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOptions();
            Cha = Convert.ToInt32(ComboCha.SelectedItem.ToString());
            UpdateLabels();
        }

        private void BtnArrayClearSelection_Click(object sender, EventArgs e)
        {
            foreach (var thing in ArrayBoxes)
            {
                thing.Items.Clear();
                thing.Items.AddRange(DefaultValues);
                thing.ResetText();
            }
            ResetAttributes();
            UpdateLabels();
        }

        private void FormAttributes_Load(object sender, EventArgs e)
        {

        }

        private void CalculateRacialBonus()
        {
            if (ThisToon.Race == "Human")
            {
                RaceStr = RaceDex = RaceCon = RaceInt = RaceWis = RaceCha = 1;
            }
            else if (ThisToon.Race == "Elf")
            {
                RaceDex = 2;
                if (ThisToon.SubRace == "High Elf")
                {
                    RaceInt = 1;
                }
                else if (ThisToon.SubRace == "Dark Elf")
                {
                    RaceCha = 1;
                }
                else if (ThisToon.SubRace == "Wood Elf")
                {
                    RaceWis = 1;
                }
            }
            else if (ThisToon.Race == "Half-Elf")
            {
                RaceCha = 2;
            }
            else if (ThisToon.Race == "Dwarf")
            {
                RaceCon = 2;
                if (ThisToon.SubRace == "Hill Dwarf")
                {
                    RaceWis = 1;
                }
                else if (ThisToon.SubRace == "Mountain Dwarf")
                {
                    RaceStr = 2;
                }
            }
            else if (ThisToon.Race == "Gnome")
            {
                RaceInt = 2;
                if (ThisToon.SubRace == "Forest Gnome")
                {
                    RaceDex = 1;
                }
                else if (ThisToon.SubRace == "Rock Gnome")
                {
                    RaceCon = 1;
                }
            }
            else if (ThisToon.Race == "Tiefling")
            {
                RaceCha = 2;
                RaceInt = 1;
            }
            else if (ThisToon.Race == "Halfling")
            {
                RaceDex = 2;
                if (ThisToon.SubRace == "Lightfoot Halfling")
                {
                    RaceCha = 1;
                }
                else if (ThisToon.SubRace == "Stout Halfling")
                {
                    RaceCon = 1;
                }
            }
            else if (ThisToon.Race == "Half-Orc")
            {
                RaceStr = 2;
                RaceCon = 1;
            }
            else if (ThisToon.Race == "Dragonborn")
            {
                RaceStr = 2;
                RaceCha = 1;
            }
        }

        private void SetHalfElfBonus()
        {
            RaceStr = RaceDex = RaceCon = RaceInt = RaceWis = 0;
            string Choice1 = ComboRace1.Text;
            string Choice2 = ComboRace2.Text;
            switch (Choice1)
            {
                case "Strength":
                    RaceStr = 1;
                    break;
                case "Dexterity":
                    RaceDex = 1;
                    break;
                case "Constitution":
                    RaceCon = 1;
                    break;
                case "Intelligence":
                    RaceInt = 1;
                    break;
                case "Wisdom":
                    RaceWis = 1;
                    break;
            }
            switch (Choice2)
            {
                case "Strength":
                    RaceStr = 1;
                    break;
                case "Dexterity":
                    RaceDex = 1;
                    break;
                case "Constitution":
                    RaceCon = 1;
                    break;
                case "Intelligence":
                    RaceInt = 1;
                    break;
                case "Wisdom":
                    RaceWis = 1;
                    break;
            }
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            CalculateAllModifiers();

            if (TabCtrlGroup.SelectedTab.Text == "Point buy")
            {
                LblBuyTotalStr.Text = TotalStr.ToString();
                LblBuyTotalDex.Text = TotalDex.ToString();
                LblBuyTotalCon.Text = TotalCon.ToString();
                LblBuyTotalInt.Text = TotalInt.ToString();
                LblBuyTotalWis.Text = TotalWis.ToString();
                LblBuyTotalCha.Text = TotalCha.ToString();

                LblBuyModStr.Text = StrMod.ToString();
                LblBuyModDex.Text = DexMod.ToString();
                LblBuyModCon.Text = ConMod.ToString();
                LblBuyModInt.Text = IntMod.ToString();
                LblBuyModWis.Text = WisMod.ToString();
                LblBuyModCha.Text = ChaMod.ToString();
            }

            else if (TabCtrlGroup.SelectedTab.Text == "Roll stats")
            {
                LblRollStr.Text = Str.ToString();
                LblRollDex.Text = Dex.ToString();
                LblRollCon.Text = Con.ToString();
                LblRollInt.Text = Int.ToString();
                LblRollWis.Text = Wis.ToString();
                LblRollCha.Text = Cha.ToString();

                LblRollTotalStr.Text = (Str + RaceStr).ToString();
                LblRollTotalDex.Text = (Dex + RaceDex).ToString();
                LblRollTotalCon.Text = (Con + RaceCon).ToString();
                LblRollTotalInt.Text = (Int + RaceInt).ToString();
                LblRollTotalWis.Text = (Wis + RaceWis).ToString();
                LblRollTotalCha.Text = (Cha + RaceCha).ToString();

                LblRollModStr.Text = StrMod.ToString();
                LblRollModDex.Text = DexMod.ToString();
                LblRollModCon.Text = ConMod.ToString();
                LblRollModInt.Text = IntMod.ToString();
                LblRollModWis.Text = WisMod.ToString();
                LblRollModCha.Text = ChaMod.ToString();
            }

            else if (TabCtrlGroup.SelectedTab.Text == "Standard array")
            {
                LblArrayTotalStr.Text = (Str + RaceStr).ToString();
                LblArrayTotalDex.Text = (Dex + RaceDex).ToString();
                LblArrayTotalCon.Text = (Con + RaceCon).ToString();
                LblArrayTotalInt.Text = (Int + RaceInt).ToString();
                LblArrayTotalWis.Text = (Wis + RaceWis).ToString();
                LblArrayTotalCha.Text = (Cha + RaceCha).ToString();

                LblArrayModStr.Text = StrMod.ToString();
                LblArrayModDex.Text = DexMod.ToString();
                LblArrayModCon.Text = ConMod.ToString();
                LblArrayModInt.Text = IntMod.ToString();
                LblArrayModWis.Text = WisMod.ToString();
                LblArrayModCha.Text = ChaMod.ToString();
            }

            LblBuyRaceStr.Text = LblRollRaceStr.Text = LblArrayRaceStr.Text = RaceStr.ToString();
            LblBuyRaceDex.Text = LblRollRaceDex.Text = LblArrayRaceDex.Text = RaceDex.ToString();
            LblBuyRaceCon.Text = LblRollRaceCon.Text = LblArrayRaceCon.Text = RaceCon.ToString();
            LblBuyRaceInt.Text = LblRollRaceInt.Text = LblArrayRaceInt.Text = RaceInt.ToString();
            LblBuyRaceWis.Text = LblRollRaceWis.Text = LblArrayRaceWis.Text = RaceWis.ToString();
            LblBuyRaceCha.Text = LblRollRaceCha.Text = LblArrayRaceCha.Text = RaceCha.ToString();

            //Console.WriteLine(ComboStr.Items.Count);
        }

        private void ResetAttributes()
        {
            Str = Dex = Con = Int = Wis = Cha = 0;
            StrMod = DexMod = ConMod = IntMod = WisMod = ChaMod = 0;
            RaceStr = RaceDex = RaceCon = RaceInt = RaceWis = RaceCha = 0;
        }

        private void CalculateAllModifiers()
        {
            TotalStr = Str + RaceStr;
            TotalDex = Dex + RaceDex;
            TotalCon = Con + RaceCon;
            TotalInt = Int + RaceInt;
            TotalWis = Wis + RaceWis;
            TotalCha = Cha + RaceCha;

            // Generate modifiers
            StrMod = ThisToon.CalculateModifier(TotalStr);
            DexMod = ThisToon.CalculateModifier(TotalDex);
            ConMod = ThisToon.CalculateModifier(TotalCon);
            IntMod = ThisToon.CalculateModifier(TotalInt);
            WisMod = ThisToon.CalculateModifier(TotalWis);
            ChaMod = ThisToon.CalculateModifier(TotalCha);
        }

        private void BtnGenerateRolls_Click(object sender, EventArgs e)
        {
            int[] CurrentRolls = ThisToon.RollArray();

            // Set attributes to rolls
            Str = CurrentRolls[0];
            Dex = CurrentRolls[1];
            Con = CurrentRolls[2];
            Int = CurrentRolls[3];
            Wis = CurrentRolls[4];
            Cha = CurrentRolls[5];

            UpdateLabels();
        }

        private void BtnSaveRolls_Click(object sender, EventArgs e)
        {
            SavedRolls["Str"] = Convert.ToInt32(LblRollStr.Text);
            SavedRolls["Dex"] = Convert.ToInt32(LblRollDex.Text);
            SavedRolls["Con"] = Convert.ToInt32(LblRollCon.Text);
            SavedRolls["Int"] = Convert.ToInt32(LblRollInt.Text);
            SavedRolls["Wis"] = Convert.ToInt32(LblRollWis.Text);
            SavedRolls["Cha"] = Convert.ToInt32(LblRollCha.Text);
            Console.WriteLine("Saved rolls = " + SavedRolls["Str"] + " + " + SavedRolls["Dex"] + " + " + SavedRolls["Con"] + " + " + SavedRolls["Int"] + " + " + SavedRolls["Wis"] + " + " + SavedRolls["Cha"]);
        }

        private void BtnLoadRolls_Click(object sender, EventArgs e)
        {
            Str = SavedRolls["Str"];
            Dex = SavedRolls["Dex"];
            Con = SavedRolls["Con"];
            Int = SavedRolls["Int"];
            Wis = SavedRolls["Wis"];
            Cha = SavedRolls["Cha"];

            CalculateAllModifiers();
            UpdateLabels();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (TabCtrlGroup.SelectedTab.Text == "Point buy")
            {
                
                Str = Convert.ToInt32(LblBuyTotalStr.Text);
                Dex = Convert.ToInt32(LblBuyTotalDex.Text);
                Con = Convert.ToInt32(LblBuyTotalCon.Text);
                Int = Convert.ToInt32(LblBuyTotalInt.Text);
                Wis = Convert.ToInt32(LblBuyTotalWis.Text);
                Cha = Convert.ToInt32(LblBuyTotalCha.Text);

                StrMod = Convert.ToInt32(LblBuyModStr.Text);
                DexMod = Convert.ToInt32(LblBuyModDex.Text);
                ConMod = Convert.ToInt32(LblBuyModCon.Text);
                IntMod = Convert.ToInt32(LblBuyModInt.Text);
                WisMod = Convert.ToInt32(LblBuyModWis.Text);
                ChaMod = Convert.ToInt32(LblBuyModCha.Text);

                if (Convert.ToInt32(LblPointsLeft.Text) == 0)
                {
                    ThisToon.Attributes["Strength"] = Str;
                    ThisToon.Attributes["Dexterity"] = Dex;
                    ThisToon.Attributes["Constitution"] = Con;
                    ThisToon.Attributes["Intelligence"] = Int;
                    ThisToon.Attributes["Wisdom"] = Wis;
                    ThisToon.Attributes["Charisma"] = Cha;

                    ThisToon.AttributeModifiers["Strength"] = StrMod;
                    ThisToon.AttributeModifiers["Dexterity"] = DexMod;
                    ThisToon.AttributeModifiers["Constitution"] = ConMod;
                    ThisToon.AttributeModifiers["Intelligence"] = IntMod;
                    ThisToon.AttributeModifiers["Wisdom"] = WisMod;
                    ThisToon.AttributeModifiers["Charisma"] = ChaMod;

                    this.Hide();
                    FormNewToon CharacterMenu = new FormNewToon(ThisToon);
                    CharacterMenu.Show();
                }
                else if (Convert.ToInt32(LblPointsLeft.Text) < 0)
                {
                    MessageBox.Show("Too many points spent", "Incorrect stats");
                }
                else if (Convert.ToInt32(LblPointsLeft.Text) > 0)
                {
                    MessageBox.Show("There are unspent points available", "Incorrect points");
                }
            }
            else if (TabCtrlGroup.SelectedTab.Text == "Roll stats")
            {
                
                if (LblRollStr.Text != "0")
                {
                    ThisToon.Attributes["Strength"] = Convert.ToInt32(LblRollTotalStr.Text);
                    ThisToon.Attributes["Dexterity"] = Convert.ToInt32(LblRollTotalDex.Text);
                    ThisToon.Attributes["Constitution"] = Convert.ToInt32(LblRollTotalCon.Text);
                    ThisToon.Attributes["Intelligence"] = Convert.ToInt32(LblRollTotalInt.Text);
                    ThisToon.Attributes["Wisdom"] = Convert.ToInt32(LblRollTotalWis.Text);
                    ThisToon.Attributes["Charisma"] = Convert.ToInt32(LblRollTotalCha.Text);

                    ThisToon.AttributeModifiers["Strength"] = Convert.ToInt32(LblRollModStr.Text);
                    ThisToon.AttributeModifiers["Dexterity"] = Convert.ToInt32(LblRollModDex.Text);
                    ThisToon.AttributeModifiers["Constitution"] = Convert.ToInt32(LblRollModCon.Text);
                    ThisToon.AttributeModifiers["Intelligence"] = Convert.ToInt32(LblRollModInt.Text);
                    ThisToon.AttributeModifiers["Wisdom"] = Convert.ToInt32(LblRollModWis.Text);
                    ThisToon.AttributeModifiers["Charisma"] = Convert.ToInt32(LblRollModCha.Text);

                    this.Hide();
                    FormNewToon CharacterMenu = new FormNewToon(ThisToon);
                    CharacterMenu.Show();
                }
                else
                {
                    MessageBox.Show("Roll for stats before continuing", "No stats rolled");
                }
            }
            else if (TabCtrlGroup.SelectedTab.Text == "Standard array")
            {
                
                if (ComboStr.Items.Count == 1)
                {
                    ThisToon.Attributes["Strength"] = Convert.ToInt32(LblArrayTotalStr.Text);
                    ThisToon.Attributes["Dexterity"] = Convert.ToInt32(LblArrayTotalDex.Text);
                    ThisToon.Attributes["Constitution"] = Convert.ToInt32(LblArrayTotalCon.Text);
                    ThisToon.Attributes["Intelligence"] = Convert.ToInt32(LblArrayTotalInt.Text);
                    ThisToon.Attributes["Wisdom"] = Convert.ToInt32(LblArrayTotalWis.Text);
                    ThisToon.Attributes["Charisma"] = Convert.ToInt32(LblArrayTotalCha.Text);

                    ThisToon.AttributeModifiers["Strength"] = Convert.ToInt32(LblArrayModStr.Text);
                    ThisToon.AttributeModifiers["Dexterity"] = Convert.ToInt32(LblArrayModDex.Text);
                    ThisToon.AttributeModifiers["Constitution"] = Convert.ToInt32(LblArrayModCon.Text);
                    ThisToon.AttributeModifiers["Intelligence"] = Convert.ToInt32(LblArrayModInt.Text);
                    ThisToon.AttributeModifiers["Wisdom"] = Convert.ToInt32(LblArrayModWis.Text);
                    ThisToon.AttributeModifiers["Charisma"] = Convert.ToInt32(LblArrayModCha.Text);

                    this.Hide();
                    FormNewToon CharacterMenu = new FormNewToon(ThisToon);
                    CharacterMenu.Show();
                }
                else
                {
                    MessageBox.Show("Assign all options for Standard array before continuing", "Standard array incomplete");
                }
            }

        }

        private void CounterStr_ValueChanged(object sender, EventArgs e)
        {
            Str = Convert.ToInt32(CounterStr.Value);
            StrMod = ThisToon.CalculateModifier(Str);
            LblBuyModStr.Text = StrMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CounterDex_ValueChanged(object sender, EventArgs e)
        {
            Dex = Convert.ToInt32(CounterDex.Value);
            DexMod = ThisToon.CalculateModifier(Dex);
            LblBuyModDex.Text = StrMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CounterCon_ValueChanged(object sender, EventArgs e)
        {
            Con = Convert.ToInt32(CounterCon.Value);
            ConMod = ThisToon.CalculateModifier(Con);
            LblBuyModCon.Text = ConMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CounterInt_ValueChanged(object sender, EventArgs e)
        {
            Int = Convert.ToInt32(CounterInt.Value);
            IntMod = ThisToon.CalculateModifier(Int);
            LblBuyModInt.Text = IntMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CounterWis_ValueChanged(object sender, EventArgs e)
        {
            Wis = Convert.ToInt32(CounterWis.Value);
            WisMod = ThisToon.CalculateModifier(Wis);
            LblBuyModWis.Text = WisMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CounterCha_ValueChanged(object sender, EventArgs e)
        {
            Cha = Convert.ToInt32(CounterCha.Value);
            ChaMod = ThisToon.CalculateModifier(Cha);
            LblBuyModCha.Text = ChaMod.ToString();
            CalculatePoints();
            UpdateLabels();
        }

        private void CalculatePoints()
        {
            Points = 25;
            int PointsUsed = 0;
            int PointsRemaining = 0;
            foreach (var thing in PointBuyBoxes)
            {
                if (thing.Value >= 8)
                {
                    PointsUsed += PointBuy[thing.Value.ToString()];
                    Console.WriteLine("This box value = " + thing.Value);
                    Console.WriteLine(PointsUsed.ToString());
                    PointsRemaining = Points - PointsUsed;
                    Console.WriteLine(PointsRemaining);
                    LblPointsLeft.Text = PointsRemaining.ToString();
                }
            }
        }
    }
}
