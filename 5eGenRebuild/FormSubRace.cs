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
    public partial class FormSubRace : Form
    {
        public Dictionary<string, string> SubraceList = new Dictionary<string, string>();
        Character ThisToon;

        public FormSubRace(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            PopulateSubraces();
        }

        private void FormSubRace_Load(object sender, EventArgs e)
        {
            if (ThisToon.Race == "Dragonborn")
            {
                BtnSub1.Text = "Moon Elf (base)";
                BtnSub1.Visible = true;
                BtnSub2.Text = "High Elf";
                BtnSub2.Visible = true;
                BtnSub3.Text = "Wood Elf";
                BtnSub3.Visible = true;
                BtnSub4.Text = "Eladrin";
                BtnSub4.Visible = true;
            }

            if (ThisToon.Race == "Dwarf")
            {
                BtnSub1.Text = "Hill Dwarf";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Mountain Dwarf";
                BtnSub2.Visible = true;
            }

            if (ThisToon.Race == "Halfling")
            {
                BtnSub1.Text = "Lightfoot Halfling";
                BtnSub1.Visible = true;
                BtnSub2.Text = "Stout Halfling";
                BtnSub2.Visible = true;
            }

            if (ThisToon.Race == "Elf")
            {
                BtnSub1.Text = "Moon Elf (base)";
                BtnSub1.Visible = true;
                BtnSub2.Text = "High Elf";
                BtnSub2.Visible = true;
                BtnSub3.Text = "Wood Elf";
                BtnSub3.Visible = true;
                BtnSub4.Text = "Eladrin";
                BtnSub4.Visible = true;
            }
        }

        private void BtnSub1_Click(object sender, EventArgs e)
        {
            if (BtnSub1.Text == "Moon Elf (base)")
            {
                LblSelection.Text = "Moon Elf";
                TxtDisplayInfo.Text = "";
            }
            else
            {
                LblSelection.Text = BtnSub1.Text;
            }
        }

        private void BtnSub2_Click(object sender, EventArgs e)
        {
            if (BtnSub2.Text == "High Elf")
            {
                LblSelection.Text = "High Elf";
                TxtDisplayInfo.Text = "";
            }
            else
            {
                LblSelection.Text = BtnSub2.Text;
            }

            //<-----------LOOK HERE----------->
            //Create function here so Selection Label = Selected Button Text
            //Search Subrace Dictionary for Selection Label Text to pull TxtDisplayInfo Text
            //Subrace name = Key    Subrace description/info = Value
            //LblSelection.Text = BtnSub2.Text;
        }

        private void BtnSub3_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub3.Text;
        }

        private void BtnSub4_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub4.Text;
        }

        private void BtnSub5_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub5.Text;
        }

        private void BtnSub6_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub6.Text;
        }

        private void BtnSub7_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub7.Text;
        }

        private void BtnSub8_Click(object sender, EventArgs e)
        {
            LblSelection.Text = BtnSub8.Text;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ThisToon.SetSubRace(ThisToon, LblSelection.Text);
            this.Hide();
            FormNewToon NewToonMenu = new FormNewToon(ThisToon);
            NewToonMenu.Show();
        }

        private void PopulateSubraces()
        {
            SubraceList.Add("Black Dragon", @"Breath Weapon
You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest.

Damage Resistance
You have resistance to the damage type associated with your draconic ancestry.");
            SubraceList.Add("Blue Dragon", @" ");
        }
    }
}
