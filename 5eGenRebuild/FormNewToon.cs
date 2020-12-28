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
        Character NewToon = new Character();

        public FormNewToon()
        {
            InitializeComponent();
        }

        public FormNewToon(Character ThisToon)
        {
            InitializeComponent();
            NewToon = ThisToon;
        }

        private void BtnGender_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Gender = new FormGender(NewToon);
            Gender.Show();
        }

        private void FormNewToon_Load(object sender, EventArgs e)
        {

        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Race = new FormRace(NewToon);
            Race.Show();
        }
    }
}
