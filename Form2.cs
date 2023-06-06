﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infection
{
    public partial class Form2 : Form
    {
        static int fieldSize = InfectionClass.FieldSize;
        int cellSize;

        ButtonCell[,] cells = new ButtonCell[fieldSize, fieldSize];

        bool IsPlaying = false;
        bool IsActing = false;

        int timeS, timeM = 0;
        int simTime = -1;

        Random rnd = new Random();

        int random1, random2, random3, random4 = 0;


        public Form2()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            InitCells();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var cell in cells)
                cell.Dispose();

            fieldSize = InfectionClass.FieldSize;
            label2.Text = InfectionClass.FieldSize.ToString();
            cells = new ButtonCell[fieldSize, fieldSize];
            InitCells();
        }



        void InitCells()
        {
            switch (fieldSize)
            {
                case 5:
                    cellSize = 100;
                    break;
                case 7:
                    cellSize = 70;
                    break;
                case 9:
                    cellSize = 55;
                    break;
                case 11:
                    cellSize = 45;
                    break;
                case 13:
                    cellSize = 39;
                    break;
                case 15:
                    cellSize = 33;
                    break;
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    ButtonCell button = new ButtonCell();
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.White;

                    button.Location = new Point(i * cellSize + 50, j * cellSize + 25);
                    this.Controls.Add(button);
                    cells[i, j] = button;
                }
            }
        }

        public void Check_Sim() //displays the current state of the field (updates the simulation)
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    switch (cells[i, j].State)
                    {
                        case 0:
                            cells[i, j].BackColor = Color.LimeGreen;
                            break;
                        case 1:
                            cells[i, j].BackColor = Color.DarkRed;
                            break;
                        case 2:
                            cells[i, j].BackColor = Color.CornflowerBlue;
                            break;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsActing = false;
            IsPlaying = false;

            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //the main button that activates the simulation
        {
            IsPlaying = true;
            int center = Convert.ToInt32(Math.Floor(Convert.ToDecimal(fieldSize / 2))); //calculation of the central point
            cells[center, center].State = 1; //accepting the central point as infected
            Check_Sim();
            stopWatch_Start();
            main_Simulation();
            Start.Enabled = false;

        }

        private void main_Simulation()
        {
            Spreading();
            Healing();
            Immunity();
            Check_Sim();

        }

        public void Spreading()
        {
            if (IsPlaying == true)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        if(simTime > 0)
                        {
                            if (cells[i, j].State == 1 && cells[i, j].State != 2)
                            {
                                Randomizer();
                                try
                                {
                                    if (random1 > 50 && cells[i + 1, j].State != 2)
                                    {
                                        cells[i + 1, j].State = 1;
                                    }
                                    else
                                    {

                                    }
                                }
                                catch { }
                                try
                                {
                                    if (random2 > 50 && cells[i - 1, j].State != 2)
                                    {
                                        cells[i - 1, j].State = 1;
                                    }
                                }
                                catch { }
                                try
                                {
                                    if (random3 > 50 && cells[i, j + 1].State != 2)
                                    {
                                        cells[i, j + 1].State = 1;
                                    }
                                }
                                catch { }
                                try
                                {
                                    if (random4 > 50 && cells[i, j - 1].State != 2)
                                    {
                                        cells[i, j - 1].State = 1;
                                    }
                                }
                                catch { }

                            }
                        }
                    }
                }
                simTime++;
            }
        }

        public void Healing()
        {
            if (IsPlaying == true)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        if (cells[i, j].State == 1)
                        {
                            cells[i, j].TimeInfected++;
                        }

                        if (cells[i, j].TimeInfected > 6)
                        {
                            cells[i, j].State = 2;
                            cells[i, j].TimeInfected = 0;
                        }
                    }

                }
            }
        }

        public void Immunity()
        {
            if (IsPlaying == true)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        if (cells[i, j].State == 2)
                        {
                            cells[i, j].TimeImmune++;
                        }

                        if (cells[i, j].TimeImmune == 4)
                        {
                            cells[i, j].State = 0;
                            cells[i, j].TimeImmune = 0;
                        }
                    }

                }
            }
        }


        private void Randomizer()
        {
            random1 = rnd.Next(0, 100);
            random2 = rnd.Next(0, 100);
            random3 = rnd.Next(0, 100);
            random4 = rnd.Next(0, 100);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //when 1 tick passes, 1 second is added, if more than 60 seconds, 1 minute is added
        {
            if (IsActing == true)
            {
                timeS++;

                if (timeS > 59)
                {
                    timeM++;
                    timeS = 0;
                }

            }
            TimeChange();


            if (IsPlaying == true) //timer of simulation for code
            {
                simTime++;
                main_Simulation();
            }
        }

        private void TimeChange() //function that changes the labels to the current stopwatch time
        {
            label6.Text = String.Format("{0:00}", timeM);
            label7.Text = String.Format("{0:00}", timeS);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//button that stops the simulation
        {
            stopSim();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void stopSim() //stops the simulation
        {
            IsActing = false;
            IsPlaying = false;

            Start.Enabled = true;
        }


        private void button5_Click_1(object sender, EventArgs e) //button Перезапустити, activates resetting of simulation
        {
            IsActing = false;
            IsPlaying = false;

            StopwatchReset();
            ResetStates();
            Check_Sim();

            Start.Enabled = true;
        }

        private void ResetStates()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    cells[i, j].State = 0;
                    cells[i, j].TimeInfected = 0;
                    cells[i, j].TimeImmune = 0;
                }

            }
        }

        private void StopwatchReset() //reset of stopwatch
        {
            timeS = 0;
            timeM = 0;
        }
        private void stopWatch_Start() //a function that gives a sign that the timer is activated
        {
            IsActing = true;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            MessageBoxButtons exit = MessageBoxButtons.YesNo;
            String message = "Ви справді хочете закрити програму?";
            String caption = "Вихід";
            if (MessageBox.Show(message, caption, exit) == DialogResult.Yes)
                Environment.Exit(0);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
/*
    Отче наш, що єси на небесах,
    нехай святиться ім’я Твоє,
    нехай прийде Царство Твоє,
    нехай буде воля Твоя,
    як на небі, так і на землі.
    Хліб наш насущний дай нам сьогодні,
    і прости нам провини наші,
    як і ми прощаємо винуватцям нашим.
    І не введи нас у спокусу,
    але визволи нас від лукавого.
    Бо Твоє є Царство, і сила, і слава
    навіки. Амінь.
 */
