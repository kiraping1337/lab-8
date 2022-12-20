using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab8
{
    public partial class Sort : Form
    {
        Stopwatch timeBubble = new Stopwatch();
        Stopwatch timeShake = new Stopwatch();
        private int[] arr;
        private int[] arr1;
        private int[] arr2;
        private int[] arr3;
        public Sort()
        {
            InitializeComponent();
            arraylength.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Length = int.Parse(arraylength.Text);
            if (Length <= 1)
            {
                MessageBox.Show("Длина массива должна быть больше 1", "Ошибка№322");
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button1.Enabled = false;
                arraylength.Enabled = false;
                arr = new int[Length];
                Helper.RandomArray(arr);
                arr1 = Helper.CopyArr(arr);
                arr2 = Helper.CopyArr(arr);
                arr3 = Helper.CopyArr(arr);
                Unsorted.Enabled = true;
                Unsorted.ColumnCount = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    Unsorted.Rows[0].Cells[i].Value = arr[i];
                }
                if (arr.Length >= 29)
                {
                    Unsorted.Rows[0].Cells[29].Value = "...";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            arraylength.Text = "10";
            arraylength.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            Sorted.Columns.Clear();
            Sorted.Refresh();
            Unsorted.Columns.Clear();
            Unsorted.Refresh();
            TimeSort1.Text = "";
            TimeSort2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Helper.SortShake (arr1);
            Sorted.ColumnCount = arr1.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                Sorted.Rows[0].Cells[i].Value = arr1[i];
            }
            if (arr.Length >= 29)
            {
                Sorted.Rows[0].Cells[29].Value = "...";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timeBubble.Start();
            Helper.SortBubble(arr2);
            timeBubble.Stop();
            timeShake.Start();
            Helper.SortShake(arr3);
            timeShake.Stop();
            TimeSort1.Text = timeBubble.Elapsed.ToString();
            TimeSort2.Text = timeShake.Elapsed.ToString();
            if (timeBubble.Elapsed > timeShake.Elapsed)
            {
                MessageBox.Show($"Сортировка перемешиванием быстрее сортировки пузырьком", "Результаты");
            }
            else
            {
                MessageBox.Show($"Сортировка перемешиванием быстрее сортировки пузырьком", "Результаты");
            }
            button5.Enabled = false;
        }       
    }
}
