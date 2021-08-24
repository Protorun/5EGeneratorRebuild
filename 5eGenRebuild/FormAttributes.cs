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
    public partial class FormAttributes : Form
    {
        Character ThisToon;

        public FormAttributes(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormAttributes_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewToon CharacterMenu = new FormNewToon(ThisToon);
            CharacterMenu.Show();
        }
    }
}
