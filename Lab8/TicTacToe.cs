using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class TicTacToe : Form
    {
        private double turn = 0;
        private Button[,] buttons = new Button[3, 3];
        public TicTacToe()
        {
            InitializeComponent();
            SetButtons();
        }
        private void SetButtons()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(130, 130);
                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Font = new Font("Segoe UI", 36F);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Location = new Point(12 + 136 * j, 82 + 136 * i);
                    buttons[i, j].Click += button1_Click;
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                ((Button)sender).Text = "X";
                turn++;
                ((Button)sender).Enabled = false;
                label3.Text = "Сейчас ходят: Нолики";
                CheckEndGame();
                CheckDraw();
            }
            else
            {
                ((Button)sender).Text = "O";
                turn++;
                ((Button)sender).Enabled = false;
                label3.Text = "Сейчас ходят: Крестики";
                CheckEndGame();
                CheckDraw();
            }

        }
        private void CheckEndGame()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text && buttons[0, 0].Text != "")
            {
                if (buttons[0, 0].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
            else if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text && buttons[1, 0].Text != "")
            {
                if (buttons[1, 0].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
            else if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text && buttons[2, 0].Text != "")
            {
                if (buttons[2, 0].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }


            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text && buttons[0, 0].Text != "")
            {
                if (buttons[0, 0].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
            else if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text && buttons[0, 1].Text != "")
            {
                if (buttons[0, 1].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
            else if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text && buttons[0, 2].Text != "")
            {
                if (buttons[0, 2].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }


            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
            {
                if (buttons[0, 0].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
            else if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text && buttons[0, 2].Text != "")
            {
                if (buttons[0, 2].Text == "X")
                {
                    MessageBox.Show("Крестики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                else
                {
                    MessageBox.Show("Нолики победили");
                    label3.Text = "Игра окончена";
                    TurnOff();
                }
                return;
            }
        }
        private void CheckDraw()
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Enabled == false && buttons[i, j].Text != "")
                    {
                        k++;
                    }
                }
            }
            if (k == 9 && label3.Text != "Игра окончена")
            {
                MessageBox.Show("Ничья");
                label3.Text = "Конец игры";
            }
        }
        private void TurnOff()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
