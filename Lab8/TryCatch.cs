using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class TryCatch : Form
    {
        private int x;
        private int y;
        private int f;
        public TryCatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool readX = int.TryParse(ReadX.Text, out x);
            bool readY = int.TryParse(ReadY.Text, out y);
            if ((string.IsNullOrEmpty(ReadX.Text)) || (string.IsNullOrEmpty(ReadY.Text)))
            {
                MessageBox.Show("Вы не ввели значения переменных", "Ошибка №1337");
            }
            else if ((!readX) || (!readY))
            {
                MessageBox.Show("Вы ввели не число", "Ошибка№228");
            }
            else
            {
                try
                {
                    f = (x/y);
                    Result.Text = "Ответ: " + f;
                    Result.Visible = true;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Делить на 0 нельзя", "Фатальная ошибка");
                }
            }
        }
    }
}
