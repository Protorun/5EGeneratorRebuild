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
    public partial class FormGender : Form
    {
        Character ThisToon;

        public FormGender(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormGender_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnMale_Click(object sender, EventArgs e)
        {
            ThisToon.SetGender(ThisToon, "Male");
            LblSelection.Text = ThisToon.Gender;
        }

        private void BtnFemale_Click(object sender, EventArgs e)
        {
            ThisToon.SetGender(ThisToon, "Female");
            LblSelection.Text = ThisToon.Gender;
        }

        private void BtnBoth_Click(object sender, EventArgs e)
        {
            ThisToon.SetGender(ThisToon, "Both");
            LblSelection.Text = ThisToon.Gender;
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            ThisToon.SetGender(ThisToon, "None");
            LblSelection.Text = ThisToon.Gender;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            FormNewToon NewToonMenu = new FormNewToon(ThisToon);
            NewToonMenu.Show();
            this.Hide();
        }
    }
}
