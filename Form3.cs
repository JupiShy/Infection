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
    public partial class Form3 : Form
    {
        int colorTheme;
        public Form3()
        {
            InitializeComponent();
            colorTheme = InfectionClass.ColorTheme;
            Set_Theme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void Set_Theme()
        {
            if (colorTheme == 0)
            {
                this.BackColor = Color.LightSteelBlue;
            }
            else if (colorTheme == 1)
            {
                this.BackColor = Color.LightSlateGray;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
