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
    }
}
