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
    public partial class FormSelectAttribute : Form
    {
        Character ThisToon;
        int SelectionsRemaining;

        public FormSelectAttribute(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormSelectAttribute_Load(object sender, EventArgs e)
        {
            if (ThisToon.Race == "Half-Elf")
            {
                SelectionsRemaining = 2;
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStrength.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckStrength.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckDexterity_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDexterity.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckDexterity.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckConstitution_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckConstitution.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckConstitution.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckIntelligence_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIntelligence.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckIntelligence.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckWisdom_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckWisdom.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckWisdom.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void CheckCharisma_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCharisma.Checked == true)
            {
                SelectionsRemaining = SelectionsRemaining - 1;
            }
            if (CheckCharisma.Checked == false)
            {
                SelectionsRemaining = SelectionsRemaining + 1;
            }
            if (SelectionsRemaining == 1)
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attribute to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selection remaining";
            }
            else
            {
                lblSelectionNumber.Text = "Select " + SelectionsRemaining.ToString() + " attributes to receive a +1 bonus";
                lblTotalSelections.Text = "You have " + SelectionsRemaining.ToString() + " selections remaining";
            }
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            //List<CheckBox> CheckList = new List<CheckBox> { CheckStrength, CheckDexterity, CheckConstitution, CheckIntelligence, CheckWisdom, CheckCharisma };
            if (SelectionsRemaining == 0)
            {
                this.Hide();
                FormNewToon NewToonMenu = new FormNewToon(ThisToon);
                NewToonMenu.Show();
            }
            if (SelectionsRemaining < 0)
            {
                MessageBox.Show("Too many selections", "Selection error");
            }
            if (SelectionsRemaining > 0)
            {
                MessageBox.Show("Too few selections", "Selection error");
            }
        }
    }
}
