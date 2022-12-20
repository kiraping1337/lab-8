using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    /// <summary>
    /// Класс, содержащий методы-помощники 
    /// </summary>
    static class Helper
    {
        /// <summary>
        /// Метод для ввода числа
        /// </summary>
        /// <param name="letter">Информация о том, что необходимо вводить</param>
        /// <returns>Число, введеное пользователем</returns>
        static public double ReadNumber(string letter)
        {
            bool isNumber = false;
            double number = 0;
            do
            {
                Console.Write("Введите {0}: ", letter);
                isNumber = double.TryParse(Console.ReadLine(), out number);
                if (!isNumber)
                {
                    Console.WriteLine("Вы ввели не число. Попробуйте еще раз.");
                }
            }
            while (!isNumber);
            return number;
        }
        /// <summary>
        /// Метод для заполнения одномерного массива случайными числами
        /// </summary>
        /// <param name="arr"> Массив </param>
        static public void RandomArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
        }
        /// <summary>
        /// Метод для вывода массива
        /// </summary>
        /// <param name="arr">Массив</param>
        static public void arrOutput(int[] arr)
        {
            if (arr.Length < 300)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < 300; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.Write("...");
            }
        }
        /// <summary>
        /// Метод для копирования массива
        /// </summary>
        /// <param name="arr">Массив, который необходимо скопировать</param>
        /// <returns>Копия массива</returns>
        static public int[] CopyArr(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }
        /// <summary>
        /// Метод для считывания строки, введенной пользователем
        /// </summary>
        /// <param name="letter"></param>
        /// <returns>Строка, введенная пользователем</returns>
        static public string ReadStr(string letter)
        {
            string Stroke = "";
            bool isStroke = true;
            while (isStroke)
            {
                Console.Write("Введите {0}: ", letter);
                Stroke = Console.ReadLine();
                if (Stroke == "")
                {
                    Console.WriteLine("Вы ввели пустую строку.");
                }
                else
                {
                    isStroke = false;
                }
            }
            return Stroke;
        }
        static public void SortBubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    Swap(arr, i, j);
                }
            }
        }
        static public void SortShake(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    Swap(arr, i, i + 1);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    Swap(arr, i - 1, i);
                }
                left++;
            }
        }
        static void Swap(int[] arr, int i, int j)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        static public double CalculationFunction1(double b, double a)
        {
            double result = Math.Round(Math.Pow(Math.Log(b), 2) / (Math.Cos(a) - 1));
            return result;
        }
    }
}
