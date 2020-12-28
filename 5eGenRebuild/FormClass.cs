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
        }

        private void FormClass_Load(object sender, EventArgs e)
        {

        }
    }
}
