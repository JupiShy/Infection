﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infection
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.ControlBox = false; //відключення кнопок згортання, розгортання та закриття вікна 
        }

        private void Light_Click(object sender, EventArgs e) //кнопка вибору світлої теми
        {
            InfectionClass.ColorTheme = 0;
            this.BackColor = Color.LightSteelBlue;
        }

        private void Dark_Click(object sender, EventArgs e) //кнопка вибору темної теми
        {
            InfectionClass.ColorTheme = 1;
            this.BackColor = Color.LightSlateGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
