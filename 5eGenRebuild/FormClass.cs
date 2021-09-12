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
    public partial class FormClass : Form
    {
        Character ThisToon;

        public FormClass(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            LblSelection.Text = " ";
            LblSelection.Visible = true;
        }

        private void FormClass_Load(object sender, EventArgs e)
        {

        }

        private void BtnBarbarian_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Barbarian";
            ThisToon.HitDie = 12;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
            Feat MartialWeapons = new Feat("Martial Weapon proficiency", "Able to equip all martial weapons");
            //ThisToon.FeatList.Add(MartialWeapons);
            MartialWeapons.AddToFeatList(ThisToon);
            Feat MediumArmour = new Feat("Medium armour proficiency", "Able to equip all medium armours and lighter");
            //ThisToon.FeatList.Add(MediumArmour);
            MediumArmour.AddToFeatList(ThisToon);
            Feat ShieldProf = new Feat("Shield proficiency", "Able to equip all shields");
            //ThisToon.FeatList.Add(ShieldProf);
            ShieldProf.AddToFeatList(ThisToon);

        }

        private void BtnBard_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Bard";
            ThisToon.HitDie = 8;
            ThisToon.HitPoints = 8;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Dexterity");
            ThisToon.SavingThrowProfs.Add("Charisma");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
            Feat BardWeapons = new Feat("Bard Weapons proficiency", "Able to equip hand crossbows, longswords, rapiers and shortswords");
            //ThisToon.FeatList.Add(BardWeapons);
            BardWeapons.AddToFeatList(ThisToon);
            Feat LightArmour = new Feat("Light armour proficiency", "Able to equip all light armours");
            //ThisToon.FeatList.Add(LightArmour);
            LightArmour.AddToFeatList(ThisToon);
        }

        private void BtnCleric_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Cleric";
            ThisToon.HitDie = 8;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Wisdom");
            ThisToon.SavingThrowProfs.Add("Charisma");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
            Feat MediumArmour = new Feat("Medium armour proficiency", "Able to equip all medium armours and lighter");
            //ThisToon.FeatList.Add(MediumArmour);
            MediumArmour.AddToFeatList(ThisToon);
            Feat ShieldProf = new Feat("Shield proficiency", "Able to equip all shields");
            //ThisToon.FeatList.Add(ShieldProf);
            ShieldProf.AddToFeatList(ThisToon);
        }

        private void BtnDruid_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Druid";
            ThisToon.HitDie = 8;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Intelligence");
            ThisToon.SavingThrowProfs.Add("Wisdom");
            Feat DruidWeapons = new Feat("Druid weapon proficiency", "Able to equip clubs, daggers, darts, javelins, maces, quarterstaffs, scimitars, sickles, slings, spears");
            DruidWeapons.AddToFeatList(ThisToon);
            Feat MediumArmour = new Feat("Medium armour proficiency", "Able to equip all medium armours and lighter");
            //ThisToon.FeatList.Add(MediumArmour);
            MediumArmour.AddToFeatList(ThisToon);
            Feat ShieldProf = new Feat("Shield proficiency", "Able to equip all shields");
            //ThisToon.FeatList.Add(ShieldProf);
            ShieldProf.AddToFeatList(ThisToon);
        }

        private void BtnFighter_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Fighter";
            ThisToon.HitDie = 10;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnMonk_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Monk";
            ThisToon.HitDie = 12;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnPaladin_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Paladin";
            ThisToon.HitDie = 10;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnRanger_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Ranger";
            ThisToon.HitDie = 10;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnRogue_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Rogue";
            ThisToon.HitDie = 8;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnSorcerer_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Sorcerer";
            ThisToon.HitDie = 6;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnWarlock_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Warlock";
            ThisToon.HitDie = 8;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnWizard_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Wizard";
            ThisToon.HitDie = 6;
            ThisToon.HitPoints = 12;
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("Strength");
            ThisToon.SavingThrowProfs.Add("Constitution");
            Feat SimpleWeapons = new Feat("Simple Weapon proficiency", "Able to equip all simple weapons");
            //ThisToon.FeatList.Add(SimpleWeapons);
            SimpleWeapons.AddToFeatList(ThisToon);
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ThisToon.Class = LblSelection.Text;
            ThisToon.TotalLevel = 1;

            if (ThisToon.Class == "Cleric")
            {
                this.Hide();
                FormDomain DomainSelection = new FormDomain(ThisToon);
                DomainSelection.Show();
            }
            else
            {
                this.Hide();
                FormNewToon NewToonMenu = new FormNewToon(ThisToon);
                NewToonMenu.Show();
            }
        }
    }
}
