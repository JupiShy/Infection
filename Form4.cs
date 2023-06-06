﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Infection
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        public int CheckValue()
        {
            int fieldSize = System.Convert.ToInt32(textBox1.Text);


            switch(fieldSize)
            {
                case 5:
                    fieldSize = 5;
                    break;
                case 7: 
                    fieldSize = 7; 
                    break;
                case 9: 
                    fieldSize = 9;
                    break;
                case 11:
                    fieldSize = 11;
                    break;
                case 13:
                    fieldSize = 13;
                    break;
                case 15:
                    fieldSize = 15;
                    break;
                default:
                    MessageBox.Show("Введіть непарне число", "Помилка!", MessageBoxButtons.OK);
                    break;
            }
            return fieldSize;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int fieldSize = CheckValue();
            if(fieldSize==5||fieldSize == 7||fieldSize == 9|| fieldSize == 11|| fieldSize == 13|| fieldSize == 15)
            {
                InfectionClass.FieldSize = fieldSize;
                this.Hide();
                Form2 infModel = new Form2();
                infModel.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 2;

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}

