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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void BtnNewToon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form NewMenu = new FormNewToon();
            NewMenu.Show();
        }
    }
}
