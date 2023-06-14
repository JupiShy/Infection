using System;
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
        int colorTheme;
        int fieldSize;
        public Form4()
        {
            InitializeComponent();
            colorTheme = InfectionClass.ColorTheme;
            Set_Theme();
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


        public int CheckValue() //функція, що перевіряє значення
        {
            try{
                fieldSize = System.Convert.ToInt32(textBox1.Text); //розмір поля дорівнює конвертованому в інт32 значенню тексту з textBox1
            }
            catch { }

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
                case 17:
                    fieldSize = 17;
                    break;
                case 19:
                    fieldSize = 19;
                    break;
                default:
                    MessageBox.Show("Введіть непарне число від 5 до 19", "Помилка!", MessageBoxButtons.OK); //помилка при некоректному значенні
                    break;
            }
            return fieldSize; //повертає розмір поля
        }
        

        private void button1_Click(object sender, EventArgs e) //кнопка ОК
        {
            int fieldSize = CheckValue(); 
            if(fieldSize==5||fieldSize == 7||fieldSize == 9|| fieldSize == 11|| fieldSize == 13|| fieldSize == 15 || fieldSize == 17 || fieldSize == 19)
            {
                InfectionClass.FieldSize = fieldSize; //прирівнює значення змінної FieldSize класу InfectionClass до fieldSize, щоб передати значення у форму 2
                this.Hide();
                Form2 infModel = new Form2();
                infModel.Show(); //відкриває вікно з симуляцією
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 2; //обмеження в кількості можливих введених символів

            char number = e.KeyChar; //символ number дорівнює введеному з клавіатури значенню

            if (!Char.IsDigit(number) && number != 8) //якщо символ це цифра і не є пробілом
            {
                e.Handled = true; //ввід підтверджується
            }
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

