﻿using System;
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

        public FormSkills(Character NewToon)
        {
            InitializeComponent();
            ThisToon = NewToon;
        }

        private void FormSkills_Load(object sender, EventArgs e)
        {

        }
    }
}
