using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = Program.ReadDouble();
            Matrix[,] matrix = new Matrix[n,m];
        }

        /// <summary> 
        /// Метод для проверки вводимых данных на корректность. 
        /// </summary> 
        /// <returns></returns> 
        public static double ReadDouble()
        {
            string numeral = Console.ReadLine();
            double value;
            while (!Double.TryParse(numeral, out value))
            {
                Console.WriteLine("\nВведённые данные не подходят. Введите корректное значение: ");
                numeral = Console.ReadLine();
            }
            return value;
        }

        public static int ReadDouble()
        {
            string numeral = Console.ReadLine();
            int value;
            while (!Double.TryParse(numeral, out value))
            {
                Console.WriteLine("\nВведённые данные не подходят. Введите корректное значение: ");
                numeral = Console.ReadLine();
            }
            return value;
        }
    }

    class Matrix
    {

    }

    
}
