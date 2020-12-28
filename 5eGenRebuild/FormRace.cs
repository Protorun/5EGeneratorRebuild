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
    public partial class FormRace : Form
    {
        Character ThisToon;

        public FormRace(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormRace_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            List<string> racelist = new List<string> { "Human", "Half-Elf", "Tiefling" };
            if(racelist.Contains(ThisToon.Race))
            {
                this.Hide();
                FormNewToon NewToonMenu = new FormNewToon();
                NewToonMenu.Show();
            }
            else
            {
                this.Hide();
                FormSubRace SubRaceMenu = new FormSubRace();
                SubRaceMenu.Show();
            }
        }

        private void BtnHuman_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Human");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnElf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Elf");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnHalfElf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Half-Elf");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnDwarf_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Dwarf");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnDragonborn_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Dragonborn");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnTiefling_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Tiefling");
            LblSelection.Text = ThisToon.Race;
        }

        private void BtnHalfling_Click(object sender, EventArgs e)
        {
            ThisToon.SetRace(ThisToon, "Halfling");
            LblSelection.Text = ThisToon.Race;
        }
    }
}
