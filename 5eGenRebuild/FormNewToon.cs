using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _5eGenRebuild
{
    public partial class FormNewToon : Form
    {
        Character ThisToon = new Character();
        
        

        public FormNewToon()
        {
            InitializeComponent();
        }

        public FormNewToon(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void BtnGender_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Gender = new FormGender(ThisToon);
            Gender.Show();
        }

        private void FormNewToon_Load(object sender, EventArgs e)
        {
            EnableSpells();
            LblGender.Text = ThisToon.Gender;
            LblRace.Text = ThisToon.Race;
            LblSubrace.Text = ThisToon.SubRace;
            LblStr.Text = ThisToon.Attributes["Strength"].ToString();
            LblDex.Text = ThisToon.Attributes["Dexterity"].ToString();
            LblCon.Text = ThisToon.Attributes["Constitution"].ToString();
            LblInt.Text = ThisToon.Attributes["Intelligence"].ToString();
            LblWis.Text = ThisToon.Attributes["Wisdom"].ToString();
            LblCha.Text = ThisToon.Attributes["Charisma"].ToString();
            LblStrMod.Text = ThisToon.AttributeModifiers["Strength"].ToString();
            LblDexMod.Text = ThisToon.AttributeModifiers["Dexterity"].ToString();
            LblConMod.Text = ThisToon.AttributeModifiers["Constitution"].ToString();
            LblIntMod.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();
            LblWisMod.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();
            LblChaMod.Text = ThisToon.AttributeModifiers["Charisma"].ToString();
            if (ThisToon.Class == "Cleric")
            {
                LblClass.Text = ThisToon.Class + " - " + ThisToon.Domain + " Domain";
            }
            else
            {
                LblClass.Text = ThisToon.Class;
            }

        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Race = new FormRace(ThisToon);
            Race.Show();
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Class = new FormClass(ThisToon);
            Class.Show();
        }

        private void BtnAttributes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Attributes = new FormAttributes(ThisToon);
            Attributes.Show();
        }

        private void BtnSkills_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Skills = new FormSkills(ThisToon);
            Skills.Show();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string FilePath = @"SavedCharacters\" + TxtFirstName.Text + TxtLastName.Text + ".txt";
            FileStream DataStream = null;
            DataStream = new FileStream(FilePath, FileMode.OpenOrCreate);
            string content = TxtFirstName.Text + " " + TxtLastName.Text;
            string GenderString = LblGender.Text;

            try
            {
                using (StreamWriter outputFile = new StreamWriter(DataStream, Encoding.UTF8))
                {
                    outputFile.WriteLine(TxtFirstName.Text);
                    outputFile.WriteLine(TxtLastName.Text);
                    outputFile.WriteLine(LblGender.Text);
                    outputFile.WriteLine(LblRace.Text);
                    outputFile.WriteLine(LblSubrace.Text);
                    Console.WriteLine("Data written successfully");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnAddFireball_Click(object sender, EventArgs e)
        {
            // PRINT ALL KEYS
            Dictionary<int, List<Spell>>.KeyCollection keys = ThisToon.Spellbook.Keys;
            foreach (int key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }
            // PRINT ALL VALUES
            foreach (var pair in ThisToon.Spellbook)
            {
                Console.WriteLine("Key = {0}, Value = {1}", pair.Key, pair.Value);
            }
            // PRINT ALL VALUES WITH KEY 0
            Console.WriteLine("ALL VALUES WITH KEY 0:");
            foreach (var thing in ThisToon.Spellbook[0])
            {
                Console.WriteLine(thing.GetSpellName());
            }
            // PRINT ALL VALUES WITH KEY 1
            Console.WriteLine("ALL VALUES WITH KEY 1:");
            foreach (var thing in ThisToon.Spellbook[1])
            {
                Console.WriteLine(thing.GetSpellName());
            }
        }

        private void BtnFeat_Click(object sender, EventArgs e)
        {
            //Feat TestFeat = new Feat("Alertness", "Description of Alertness");
            //TestFeat.AddToFeatList(ThisToon);
            //Feat TestFeat2 = new Feat("Toughness", "Description of Toughness", "Con", 2);
            //TestFeat2.AddToFeatList(ThisToon);
            //TestFeat.AddToFeatList(ThisToon);

            foreach(var thing in ThisToon.Attributes)
            {
                Console.WriteLine(thing.Key + " - " + thing.Value);
            }


            foreach (var thing in ThisToon.FeatList)
            {
                Console.WriteLine(thing.GetFeatName());
                Console.WriteLine(thing.GetFeatDesc());
                Console.WriteLine(thing.GetFeatPassive());
                Console.WriteLine(thing.GetFeatStat());
                Console.WriteLine(thing.GetFeatModValue());
            }

            Feat TestFeat3 = new Feat("Alertness", "Description of Alertness");
            TestFeat3.AddToFeatList(ThisToon);

            foreach (var thing in ThisToon.FeatList)
            {
                Console.WriteLine(thing.GetFeatName());
                Console.WriteLine(thing.GetFeatDesc());
                Console.WriteLine(thing.GetFeatPassive());
                Console.WriteLine(thing.GetFeatStat());
                Console.WriteLine(thing.GetFeatModValue());
            }
        }

        private void BtnSpells_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Spells = new FormSpellSelection(ThisToon);
            Spells.Show();
        }

        private void EnableSpells()
        {
            if (ThisToon.Class != null)
            {
                if (ThisToon.Class == "Bard" || ThisToon.Class == "Cleric" || ThisToon.Class == "Druid" || ThisToon.Class == "Sorcerer" || ThisToon.Class == "Warlock" || ThisToon.Class == "Wizard")
                {
                    BtnSpells.Enabled = true;
                }
            }
        }

        private void BtnBackground_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Background = new FormBackground(ThisToon);
            Background.Show();
        }
    }
}
