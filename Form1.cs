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

        private void Form1_Load(object sender, EventArgs e) //коли форма загружжається
        {
            colorTheme = InfectionClass.ColorTheme; //бере значення кольору теми з публічної статичної змінної
            Set_Theme(); //активує зміну теми
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            Form3 infectionInfo = new Form3(); 
            infectionInfo.Show(); //відкриває інформаційний лист
            this.Hide(); //головне меню приховується
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //головне меню приховується
            Form4 dialogWindow = new Form4();
            dialogWindow.Show(); //відкривається вікно вводу розміру поля
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Theme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 change_theme = new Form5();
            change_theme.Show(); //відкривається вікно зміни кольорової теми
        }

        private void Set_Theme() //функція зміни теми
        {
            if(colorTheme == 0) //якщо colorTheme дорівнює 0 (за замовчуванням)
            {
                this.BackColor = Color.LightSteelBlue; //світлий фон
            }
            else if(colorTheme == 1) //якщо colorTheme дорівнює 1
            {
                this.BackColor = Color.LightSlateGray; //темніший фон
            }
        }

        private void Exit_Click(object sender, EventArgs e) //нажаття кнопки виходу
        {
            MessageBoxButtons exit = MessageBoxButtons.YesNo;
            String message = "Ви справді хочете закрити програму?";
            String caption = "Вихід";
            if (MessageBox.Show(message, caption, exit) == DialogResult.Yes)
                Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                        
        }
    }
}
