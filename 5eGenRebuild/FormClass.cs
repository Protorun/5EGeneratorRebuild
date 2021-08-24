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
            ThisToon.SavingThrowProfs.Clear();
            ThisToon.SavingThrowProfs.Add("");
            ThisToon.SavingThrowProfs.Add("");
        }

        private void BtnBard_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Bard";
            ThisToon.HitDie = 8;
        }

        private void BtnCleric_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Cleric";
            ThisToon.HitDie = 8;
        }

        private void BtnDruid_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Druid";
            ThisToon.HitDie = 8;
        }

        private void BtnFighter_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Fighter";
            ThisToon.HitDie = 10;
        }

        private void BtnMonk_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Monk";
            ThisToon.HitDie = 12;
        }

        private void BtnPaladin_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Paladin";
            ThisToon.HitDie = 10;
        }

        private void BtnRanger_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Ranger";
            ThisToon.HitDie = 10;
        }

        private void BtnRogue_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Rogue";
            ThisToon.HitDie = 8;
        }

        private void BtnSorcerer_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Sorcerer";
            ThisToon.HitDie = 6;
        }

        private void BtnWarlock_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Warlock";
            ThisToon.HitDie = 8;
        }

        private void BtnWizard_Click(object sender, EventArgs e)
        {
            LblSelection.Text = "Wizard";
            ThisToon.HitDie = 6;
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
