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
            LblGender.Text = ThisToon.Gender;
            LblRace.Text = ThisToon.Race;
            LblSubrace.Text = ThisToon.SubRace;
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

    }
}
