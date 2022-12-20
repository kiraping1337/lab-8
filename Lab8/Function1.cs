using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab8
{
    public partial class Function1 : Form
    {
        private double a;
        private double b;
        private double result;
        private double userResult;
        private int attemps = 3;
        public Function1()
        {
            InitializeComponent();
        }

        private void Function1_Load(object sender, EventArgs e)
        {

        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            bool readA = double.TryParse(ReadA.Text, out a);
            bool readB = double.TryParse(ReadB.Text, out b);
            if ((string.IsNullOrEmpty(ReadA.Text)) || (string.IsNullOrEmpty(ReadB.Text)))
            {
                MessageBox.Show("Вы не ввели значения переменных", "Ошибка №1337");
            }
            else if ((!readA) || (!readB))
            {
                MessageBox.Show("Вы ввели не число", "Ошибка№228");
            }
            else
            {
                label1.Enabled = false;
                label2.Enabled = false;
                ReadA.Enabled = false;
                ReadB.Enabled = false;
                label3.Enabled = true;
                label5.Visible = true;
                ReadUserResult.Enabled = true;
                result = Helper.CalculationFunction1 (b,a);
                label4.Text = "Правильный ответ: " + result;
                label5.Text = "Осталось попыток: " + attemps;
                Calculation.Enabled = false;
                Attemp.Enabled = true;
            }
        }

        private void Attemp_Click(object sender, EventArgs e)
        {          
            label5.Text = "Осталось попыток: " + attemps;
            bool ReadUR = double.TryParse(ReadUserResult.Text, out userResult);
            if (!ReadUR)
            {
                MessageBox.Show("Вы ввели не число", "Ошибка№228");
            }
            else if (attemps == 0)
            {
                MessageBox.Show("У вас закончились все попытки, к сожалению вы проиграли", ":(");
                label5.Visible = false;
                label4.Visible = true;
                label3.Enabled = false;
                ReadUserResult.Enabled = false;
                Attemp.Enabled = false;
            }
            else if (userResult != result)
            {
                MessageBox.Show("Неправильно. Не расстраивайтесь, получится в следующий раз", ":(");
                attemps--;
                label5.Text = "Осталось попыток: " + attemps;
            }
            else if (userResult == result)
            {
                MessageBox.Show("Правильно. Поздравляем, вы выиграли: ничего", ":)");
                label5.Visible = false;
                label4.Visible = true;
                label3.Enabled = false;
                ReadUserResult.Enabled = false;
                Attemp.Enabled = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            a=0;
            b=0;
            result=0;
            attemps = 3;
            userResult = 0;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = false;
            label4.Visible = false;
            label5.Visible = false;
            Calculation.Enabled = true;
            Attemp.Enabled = false;
            ReadA.Clear();
            ReadB.Clear();
            ReadUserResult.Clear();
            ReadA.Enabled = true;
            ReadB.Enabled = true;
            ReadUserResult.Enabled = false;
        }
    }
}
