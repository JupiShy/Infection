using System;
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
    public partial class Form1 : Form
    {
        int colorTheme;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorTheme = InfectionClass.ColorTheme;
            Set_Theme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 infectionInfo = new Form3();
            infectionInfo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 dialogWindow = new Form4();
            dialogWindow.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Theme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 change_theme = new Form5();
            change_theme.Show();
        }

        private void Set_Theme()
        {
            if(colorTheme == 0)
            {
                this.BackColor = Color.LightSteelBlue;
            }
            else if(colorTheme == 1)
            {
                this.BackColor = Color.LightSlateGray;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons exit = MessageBoxButtons.YesNo;
            String message = "Ви справді хочете закрити програму?";
            String caption = "Вихід";
            if (MessageBox.Show(message, caption, exit) == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
