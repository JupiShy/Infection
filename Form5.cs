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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Light_Click(object sender, EventArgs e)
        {
            InfectionClass.ColorTheme = 0;
            this.BackColor = Color.LightSteelBlue;
        }

        private void Dark_Click(object sender, EventArgs e)
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
    }
}
