﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class symptoms : Form
    {
        public symptoms()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedetail p_page = new pedetail();
            this.Hide();
            p_page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotelmainpage hotels = new Hotelmainpage();
            this.Hide();
            hotels.Show();
        }
    }
}