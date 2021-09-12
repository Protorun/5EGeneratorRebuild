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
    public partial class FormSkills : Form
    {
        Character ThisToon;
        int NumberSelected, NumberAvailable;
        List<CheckBox> AllSkillBoxes = new List<CheckBox>();

        public FormSkills(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
            AllSkillBoxes.Add(CheckAthletics);
            AllSkillBoxes.Add(CheckAcrobatics);
            AllSkillBoxes.Add(CheckSleight);
            AllSkillBoxes.Add(CheckStealth);
            AllSkillBoxes.Add(CheckArcana);
            AllSkillBoxes.Add(CheckHistory);
            AllSkillBoxes.Add(CheckInvestigation);
            AllSkillBoxes.Add(CheckNature);
            AllSkillBoxes.Add(CheckReligion);
            AllSkillBoxes.Add(CheckAnimalHandling);
            AllSkillBoxes.Add(CheckInsight);
            AllSkillBoxes.Add(CheckMedicine);
            AllSkillBoxes.Add(CheckPerception);
            AllSkillBoxes.Add(CheckSurvival);
            AllSkillBoxes.Add(CheckDeception);
            AllSkillBoxes.Add(CheckIntimidation);
            AllSkillBoxes.Add(CheckPerformance);
            AllSkillBoxes.Add(CheckPersuasion);
            CalculateAvailable();
            SetBonusLabels();
            SetBackgroundSkills();
        }

        private void FormSkills_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            SetProficiencies();
            SaveSkills();
            this.Hide();
            FormNewToon CreationMenu = new FormNewToon(ThisToon);
            CreationMenu.Show();
        }

        private void SetProficiencies()
        {
            ThisToon.SkillProfs.Clear();
            foreach (var thing in AllSkillBoxes)
            {
                if (thing.Checked == true)
                {
                    ThisToon.SkillProfs.Add(thing.Text);
                    Console.WriteLine(thing.Text);
                }
            }
        }

        private void CalculateAvailable()
        {
            string Class = ThisToon.Class;
            switch (Class)
            {
                case "Barbarian":
                    NumberAvailable = 2;
                    CheckAnimalHandling.Enabled = true;
                    CheckAthletics.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckNature.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckSurvival.Enabled = true;
                    break;
                case "Bard":
                    NumberAvailable = 3;
                    CheckAthletics.Enabled = true;
                    CheckAcrobatics.Enabled = true;
                    CheckSleight.Enabled = true;
                    CheckStealth.Enabled = true;
                    CheckArcana.Enabled = true;
                    CheckHistory.Enabled = true;
                    CheckInvestigation.Enabled = true;
                    CheckNature.Enabled = true;
                    CheckReligion.Enabled = true;
                    CheckAnimalHandling.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckMedicine.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckSurvival.Enabled = true;
                    CheckDeception.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckPerformance.Enabled = true;
                    CheckPersuasion.Enabled = true;
                    break;
                case "Cleric":
                    NumberAvailable = 2;
                    CheckHistory.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckMedicine.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckReligion.Enabled = true;
                    break;
                case "Druid":
                    NumberAvailable = 2;
                    CheckArcana.Enabled = true;
                    CheckNature.Enabled = true;
                    CheckReligion.Enabled = true;
                    CheckAnimalHandling.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckMedicine.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckSurvival.Enabled = true;
                    break;
                case "Fighter":
                    NumberAvailable = 2;
                    CheckAcrobatics.Enabled = true;
                    CheckAnimalHandling.Enabled = true;
                    CheckAthletics.Enabled = true;
                    CheckHistory.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckSurvival.Enabled = true;
                    break;
                case "Monk":
                    NumberAvailable = 2;
                    CheckAcrobatics.Enabled = true;
                    CheckAthletics.Enabled = true;
                    CheckHistory.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckReligion.Enabled = true;
                    CheckStealth.Enabled = true;
                    break;
                case "Paladin":
                    NumberAvailable = 2;
                    CheckAthletics.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckMedicine.Enabled = true;
                    CheckPersuasion.Enabled = true;
                    CheckReligion.Enabled = true;
                    break;
                case "Ranger":
                    NumberAvailable = 3;
                    CheckAnimalHandling.Enabled = true;
                    CheckAthletics.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckInvestigation.Enabled = true;
                    CheckNature.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckStealth.Enabled = true;
                    CheckSurvival.Enabled = true;
                    break;
                case "Rogue":
                    NumberAvailable = 4;
                    CheckAcrobatics.Enabled = true;
                    CheckAthletics.Enabled = true;
                    CheckDeception.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckInvestigation.Enabled = true;
                    CheckPerception.Enabled = true;
                    CheckPerformance.Enabled = true;
                    CheckPersuasion.Enabled = true;
                    CheckSleight.Enabled = true;
                    CheckStealth.Enabled = true;
                    break;
                case "Sorcerer":
                    NumberAvailable = 2;
                    CheckArcana.Enabled = true;
                    CheckDeception.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckPersuasion.Enabled = true;
                    CheckReligion.Enabled = true;
                    break;
                case "Warlock":
                    NumberAvailable = 2;
                    CheckArcana.Enabled = true;
                    CheckDeception.Enabled = true;
                    CheckHistory.Enabled = true;
                    CheckIntimidation.Enabled = true;
                    CheckInvestigation.Enabled = true;
                    CheckNature.Enabled = true;
                    CheckReligion.Enabled = true;
                    break;
                case "Wizard":
                    NumberAvailable = 2;
                    CheckArcana.Enabled = true;
                    CheckHistory.Enabled = true;
                    CheckInsight.Enabled = true;
                    CheckInvestigation.Enabled = true;
                    CheckMedicine.Enabled = true;
                    CheckReligion.Enabled = true;
                    break;
            }
            LblSelectionsLeft.Text = NumberAvailable.ToString();
        }

        private void CalculateUsedPoints()
        {
            NumberSelected = 0;
            foreach(var thing in AllSkillBoxes)
            {
                if (thing.Checked == true)
                {
                    if (thing.Enabled == true)
                    {
                        NumberSelected++;
                    }
                    
                }
            }

            LblSelectionsLeft.Text = (NumberAvailable - NumberSelected).ToString();
        }

        private void SetBonusLabels()
        {
            // STRENGTH
            LblAthletics.Text = ThisToon.AttributeModifiers["Strength"].ToString();

            // DEXTERITY
            LblAcrobatics.Text = ThisToon.AttributeModifiers["Dexterity"].ToString();
            LblSleight.Text = ThisToon.AttributeModifiers["Dexterity"].ToString();
            LblStealth.Text = ThisToon.AttributeModifiers["Dexterity"].ToString();

            // INTELLIGENCE
            LblArcana.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();
            LblHistory.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();
            LblInvestigation.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();
            LblNature.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();
            LblReligion.Text = ThisToon.AttributeModifiers["Intelligence"].ToString();

            // WISDOM
            LblHandling.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();
            LblInsight.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();
            LblMedicine.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();
            LblPerception.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();
            LblSurvival.Text = ThisToon.AttributeModifiers["Wisdom"].ToString();

            // CHARISMA
            LblDeception.Text = ThisToon.AttributeModifiers["Charisma"].ToString();
            LblIntimidation.Text = ThisToon.AttributeModifiers["Charisma"].ToString();
            LblPerformance.Text = ThisToon.AttributeModifiers["Charisma"].ToString();
            LblPersuasion.Text = ThisToon.AttributeModifiers["Charisma"].ToString();

        }

        private void SaveSkills()
        {
            ThisToon.Skills["Athletics"] = Convert.ToInt32(LblAthletics.Text);
            ThisToon.Skills["Acrobatics"] = Convert.ToInt32(LblAcrobatics.Text);
            ThisToon.Skills["Sleight of Hand"] = Convert.ToInt32(LblSleight.Text);
            ThisToon.Skills["Stealth"] = Convert.ToInt32(LblStealth.Text);
            ThisToon.Skills["Arcana"] = Convert.ToInt32(LblArcana.Text);
            ThisToon.Skills["History"] = Convert.ToInt32(LblHistory.Text);
            ThisToon.Skills["Investigation"] = Convert.ToInt32(LblInvestigation.Text);
            ThisToon.Skills["Nature"] = Convert.ToInt32(LblNature.Text);
            ThisToon.Skills["Religion"] = Convert.ToInt32(LblReligion.Text);
            ThisToon.Skills["Animal Handling"] = Convert.ToInt32(LblHandling.Text);
            ThisToon.Skills["Insight"] = Convert.ToInt32(LblInsight.Text);
            ThisToon.Skills["Medicine"] = Convert.ToInt32(LblMedicine.Text);
            ThisToon.Skills["Perception"] = Convert.ToInt32(LblPerception.Text);
            ThisToon.Skills["Survival"] = Convert.ToInt32(LblSurvival.Text);
            ThisToon.Skills["Deception"] = Convert.ToInt32(LblDeception.Text);
            ThisToon.Skills["Intimidation"] = Convert.ToInt32(LblIntimidation.Text);
            ThisToon.Skills["Performance"] = Convert.ToInt32(LblPerformance.Text);
            ThisToon.Skills["Persuasion"] = Convert.ToInt32(LblPersuasion.Text);
        }

        private void SetBackgroundSkills()
        {
                switch (ThisToon.Background)
                {
                    case "Acolyte":
                        CheckInsight.Checked = true;
                        CheckInsight.Enabled = false;
                        CheckReligion.Checked = true;
                        CheckReligion.Enabled = false;
                        break;
                    case "Charlatan":
                        CheckDeception.Checked = true;
                        CheckDeception.Enabled = false;
                        CheckSleight.Checked = true;
                        CheckSleight.Enabled = false;
                        break;
                    case "Criminal":
                        CheckDeception.Checked = true;
                        CheckDeception.Enabled = false;
                        CheckStealth.Checked = true;
                        CheckStealth.Enabled = false;
                        break;
                    case "Entertainer":
                        CheckAcrobatics.Checked = true;
                        CheckAcrobatics.Enabled = false;
                        CheckPerformance.Checked = true;
                        CheckPerformance.Enabled = false;
                        break;
                    case "Folk Hero":
                        CheckAnimalHandling.Checked = true;
                        CheckAnimalHandling.Enabled = false;
                        CheckSurvival.Checked = true;
                        CheckSurvival.Enabled = false;
                        break;
                    case "Guild Artisan":
                        CheckInsight.Checked = true;
                        CheckInsight.Enabled = false;
                        CheckPersuasion.Checked = true;
                        CheckPersuasion.Enabled = false;
                        break;
                    case "Hermit":
                        CheckMedicine.Checked = true;
                        CheckMedicine.Enabled = false;
                        CheckReligion.Checked = true;
                        CheckReligion.Enabled = false;
                        break;
                    case "Noble":
                        CheckHistory.Checked = true;
                        CheckHistory.Enabled = false;
                        CheckPersuasion.Checked = true;
                        CheckPersuasion.Enabled = false;
                        break;
                    case "Outlander":
                        CheckAthletics.Checked = true;
                        CheckAthletics.Enabled = false;
                        CheckSurvival.Checked = true;
                        CheckSurvival.Enabled = false;
                        break;
                    case "Sage":
                        CheckArcana.Checked = true;
                        CheckArcana.Enabled = false;
                        CheckHistory.Checked = true;
                        CheckHistory.Enabled = false;
                        break;
                    case "Sailor":
                        CheckPerception.Checked = true;
                        CheckPerception.Enabled = false;
                        CheckReligion.Checked = true;
                        CheckReligion.Enabled = false;
                        break;
                    case "Soldier":
                        CheckAthletics.Checked = true;
                        CheckAthletics.Enabled = false;
                        CheckIntimidation.Checked = true;
                        CheckIntimidation.Enabled = false;
                        break;
                    case "Urchin":
                        CheckSleight.Checked = true;
                        CheckSleight.Enabled = false;
                        CheckStealth.Checked = true;
                        CheckStealth.Enabled = false;
                        break;
                }          
        }

        private void CheckAthletics_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckAthletics.Checked == true)
            {
                LblAthletics.Text = ((Convert.ToInt32(LblAthletics.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckAthletics.Checked = false;
                }
            }
            else if (CheckAthletics.Checked == false)
            {
                NumberSelected--;
                LblAthletics.Text = ((Convert.ToInt32(LblAthletics.Text)) - 2).ToString();
            }
        }

        private void CheckAcrobatics_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckAcrobatics.Checked == true)
            {
                LblAcrobatics.Text = ((Convert.ToInt32(LblAcrobatics.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckAcrobatics.Checked = false;
                }
            }
            else if (CheckAcrobatics.Checked == false)
            {
                NumberSelected--;
                LblAcrobatics.Text = ((Convert.ToInt32(LblAcrobatics.Text)) - 2).ToString();
            }
        }

        private void CheckSleight_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckSleight.Checked == true)
            {
                LblSleight.Text = ((Convert.ToInt32(LblSleight.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckSleight.Checked = false;
                }
            }
            else if (CheckSleight.Checked == false)
            {
                NumberSelected--;
                LblSleight.Text = ((Convert.ToInt32(LblSleight.Text)) - 2).ToString();
            }
        }

        private void CheckStealth_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckStealth.Checked == true)
            {
                LblStealth.Text = ((Convert.ToInt32(LblStealth.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckStealth.Checked = false;
                }
            }
            else if (CheckStealth.Checked == false)
            {
                NumberSelected--;
                LblStealth.Text = ((Convert.ToInt32(LblStealth.Text)) - 2).ToString();
            }
        }

        private void CheckArcana_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckArcana.Checked == true)
            {
                LblArcana.Text = ((Convert.ToInt32(LblArcana.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckArcana.Checked = false;
                }
            }
            else if (CheckArcana.Checked == false)
            {
                NumberSelected--;
                LblArcana.Text = ((Convert.ToInt32(LblArcana.Text)) - 2).ToString();
            }
        }

        private void CheckHistory_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckHistory.Checked == true)
            {
                LblHistory.Text = ((Convert.ToInt32(LblHistory.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckHistory.Checked = false;
                }
            }
            else if (CheckHistory.Checked == false)
            {
                NumberSelected--;
                LblHistory.Text = ((Convert.ToInt32(LblHistory.Text)) - 2).ToString();
            }
        }

        private void CheckInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckInvestigation.Checked == true)
            {
                LblInvestigation.Text = ((Convert.ToInt32(LblInvestigation.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckInvestigation.Checked = false;
                }
            }
            else if (CheckInvestigation.Checked == false)
            {
                NumberSelected--;
                LblInvestigation.Text = ((Convert.ToInt32(LblInvestigation.Text)) - 2).ToString();
            }
        }

        private void CheckNature_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckNature.Checked == true)
            {
                LblNature.Text = ((Convert.ToInt32(LblNature.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckNature.Checked = false;
                }
            }
            else if (CheckNature.Checked == false)
            {
                NumberSelected--;
                LblNature.Text = ((Convert.ToInt32(LblNature.Text)) - 2).ToString();
            }
        }

        private void CheckReligion_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckReligion.Checked == true)
            {
                LblReligion.Text = ((Convert.ToInt32(LblReligion.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckReligion.Checked = false;
                }
            }
            else if (CheckReligion.Checked == false)
            {
                NumberSelected--;
                LblReligion.Text = ((Convert.ToInt32(LblReligion.Text)) - 2).ToString();
            }
        }

        private void CheckAnimalHandling_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckAnimalHandling.Checked == true)
            {
                LblHandling.Text = ((Convert.ToInt32(LblHandling.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckAnimalHandling.Checked = false;
                }
            }
            else if (CheckAnimalHandling.Checked == false)
            {
                NumberSelected--;
                LblHandling.Text = ((Convert.ToInt32(LblHandling.Text)) - 2).ToString();
            }
        }

        private void CheckInsight_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckInsight.Checked == true)
            {
                LblInsight.Text = ((Convert.ToInt32(LblInsight.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckInsight.Checked = false;
                }
            }
            else if (CheckInsight.Checked == false)
            {
                NumberSelected--;
                LblInsight.Text = ((Convert.ToInt32(LblInsight.Text)) - 2).ToString();
            }
        }

        private void CheckMedicine_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckMedicine.Checked == true)
            {
                LblMedicine.Text = ((Convert.ToInt32(LblMedicine.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckMedicine.Checked = false;
                }
            }
            else if (CheckMedicine.Checked == false)
            {
                NumberSelected--;
                LblMedicine.Text = ((Convert.ToInt32(LblMedicine.Text)) - 2).ToString();
            }
        }

        private void CheckPerception_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckPerception.Checked == true)
            {
                LblPerception.Text = ((Convert.ToInt32(LblPerception.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckPerception.Checked = false;
                }
            }
            else if (CheckPerception.Checked == false)
            {
                NumberSelected--;
                LblPerception.Text = ((Convert.ToInt32(LblPerception.Text)) - 2).ToString();
            }
        }

        private void CheckSurvival_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckSurvival.Checked == true)
            {
                LblSurvival.Text = ((Convert.ToInt32(LblSurvival.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckSurvival.Checked = false;
                }
            }
            else if (CheckSurvival.Checked == false)
            {
                NumberSelected--;
                LblSurvival.Text = ((Convert.ToInt32(LblSurvival.Text)) - 2).ToString();
            }
        }

        private void CheckDeception_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckDeception.Checked == true)
            {
                LblDeception.Text = ((Convert.ToInt32(LblDeception.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckDeception.Checked = false;
                }
            }
            else if (CheckDeception.Checked == false)
            {
                NumberSelected--;
                LblDeception.Text = ((Convert.ToInt32(LblDeception.Text)) - 2).ToString();
            }
        }

        private void CheckIntimidation_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckIntimidation.Checked == true)
            {
                LblIntimidation.Text = ((Convert.ToInt32(LblIntimidation.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckIntimidation.Checked = false;
                }
            }
            else if (CheckIntimidation.Checked == false)
            {
                NumberSelected--;
                LblIntimidation.Text = ((Convert.ToInt32(LblIntimidation.Text)) - 2).ToString();
            }
        }

        private void CheckPerformance_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckPerformance.Checked == true)
            {
                LblPerformance.Text = ((Convert.ToInt32(LblPerformance.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckPerformance.Checked = false;
                }
            }
            else if (CheckPerformance.Checked == false)
            {
                NumberSelected--;
                LblPerformance.Text = ((Convert.ToInt32(LblPerformance.Text)) - 2).ToString();
            }
        }

        private void CheckPersuasion_CheckedChanged(object sender, EventArgs e)
        {
            CalculateUsedPoints();
            if (CheckPersuasion.Checked == true)
            {
                LblPersuasion.Text = ((Convert.ToInt32(LblPersuasion.Text)) + 2).ToString();
                if (Convert.ToInt32(LblSelectionsLeft.Text) == -1)
                {
                    MessageBox.Show("Too many skills selected", "Not enough proficiencies available");
                    CheckPersuasion.Checked = false;

                }
            }
            else if (CheckPersuasion.Checked == false)
            {
                NumberSelected--;
                LblPersuasion.Text = ((Convert.ToInt32(LblPersuasion.Text)) - 2).ToString();
            }
        }
    }
}
