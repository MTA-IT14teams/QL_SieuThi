﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi.GUI
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        int direction = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
