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
    public partial class Strings : Form
    {
        int LowerCount = 0;
        int UpperCount = 0;
        int PunctuationCount = 0;
        int FirstSymbolCount = 0;
        public Strings()
        {
            InitializeComponent();
            Str1.Text = "Варкалось. Хливкие шорьки\nПырялись по наве,\nИ хрюкотали зелюки,\nКак мюмзики в мове.\nО бойся Бармаглота, сын!\nОн так свирлеп и дик,\nА в глуще рымит исполин -\nЗлопастный Брандашмыг";
            Str2.Text = "Быть может, вся Природа– мозаика цветов?";
            Str3.Text = "Быть может, вся Природа– различность голосов?";
        }

        private void LowerUpperStr_Click(object sender, EventArgs e)
        {
            string Line1 = Str1.Text;
            if (Line1 != "")
            {
                foreach (var letter in Line1)
                {
                    if (char.IsLower(letter))
                    {
                        LowerCount++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        UpperCount++;
                    }
                }
                MessageBox.Show($"Количество строчных букв: {LowerCount}, количество прописных: {UpperCount}.", "Информация");
            }
            else
            {
                MessageBox.Show("Строка 1 не может быть пустой", "Ошибка №1984");
            }    
            LowerCount = 0;
            UpperCount = 0;
        }

        private void PunctuationStr_Click(object sender, EventArgs e)
        {
            string Line1 = Str1.Text;
            if (Line1 != "")
            {
                foreach (var letter in Line1)
                {
                    if (char.IsPunctuation(letter))
                    {
                        PunctuationCount++;
                    }
                }
                MessageBox.Show($"Количество знаков препинания: {PunctuationCount}", "Информация");
            }
            else
            {
                MessageBox.Show("Строка 1 не может быть пустой", "Ошибка №1984");
            }
            PunctuationCount = 0;
        }

        private void Str2And3Op_Click(object sender, EventArgs e)
        {
            string Line2 = Str2.Text;
            string Line3 = Str3.Text;
            if (Line2 != "" && Line3 != "")
            {
                if (Line2.Length < Line3.Length)
                {
                    for (int i = 0; i < Line2.Length; i++)
                    {
                        if (Line2[i] == Line3[i])
                        {
                            FirstSymbolCount++;
                        }
                        else
                        {
                            i = Line2.Length;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Line3.Length; i++)
                    {
                        if (Line2[i] == Line3[i])
                        {
                            FirstSymbolCount++;
                        }
                        else
                        {
                            i = Line3.Length;
                        }
                    }
                }
                MessageBox.Show($"Количество первых символов строк, которые совпадают: {FirstSymbolCount}", "Информация");
            }
            else
            {
                MessageBox.Show("Строки 2 и 3 не могут быть пустыми", "Ошибка №1917");
            }
            FirstSymbolCount = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Str1.Text = "";
            Str2.Text = "";
            Str3.Text = "";
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            Str1.Text = "Варкалось. Хливкие шорьки\nПырялись по наве,\nИ хрюкотали зелюки,\nКак мюмзики в мове.\nО бойся Бармаглота, сын!\nОн так свирлеп и дик,\nА в глуще рымит исполин -\nЗлопастный Брандашмыг";
            Str2.Text = "Быть может, вся Природа– мозаика цветов?";
            Str3.Text = "Быть может, вся Природа– различность голосов?";
        }
    }
}
