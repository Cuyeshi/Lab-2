using System;
using LibraryForMatrix;


namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание переменных типа Matrixs.
            Matrixs matrixA = new Matrixs();
            Matrixs matrixB = new Matrixs(); 
            Matrixs matrixC = new Matrixs(); 
            int lineA, columnA, lineB, columnB; // Создание переменных для обозначения строчек и столбцов матриц.
            // Создание двумерных массивов для обозначения элементов матриц.
            double[,] valuesA = new double[1000, 1000];
            double[,] valuesB = new double[1000, 1000]; 

            Console.Write("Введите число строк для матрицы А:    ");
            lineA = Program.ReadInt();
            Console.Write("\nВведите число столбцов для матрицы А: ");
            columnA = Program.ReadInt();
            Console.Write("\nВведите число строк для матрицы B:    ");
            lineB = Program.ReadInt();
            Console.Write("\nВведите число столбцов для матрицы B: ");
            columnB = Program.ReadInt();
            Console.Write("\nВведите значение для матрицы A: ");
            valuesA = Matrixs.InputMatrix(lineA, columnA);
            Console.Write("\nВведите значение для матрицы B: ");
            valuesB = Matrixs.InputMatrix(lineB, columnB);
            Console.WriteLine("\n-----------ВВОД ДАННЫХ ЗАКОНЧЕН----------\n");
            matrixA = new Matrixs(lineA, columnA, valuesA); // Метод создания матрицы из полученной информации.
            matrixB = new Matrixs(lineB, columnB, valuesB);

            bool isRun = true;  // Это действие необходимо для начала работы цикла с выбором действий.

            while (isRun) // Консольное меню.
            {
                
                Console.WriteLine("\n╔════════════════════════════════════════╗");
                Console.WriteLine("║            Выберите действие:          ║");
                Console.WriteLine("║                                        ║");
                Console.WriteLine("║          1 - Вывод Матрицы A;          ║");
                Console.WriteLine("║          2 - Вывод Матрицы B;          ║");
                Console.WriteLine("║     3 - Перемножение Матриц A и B;     ║");
                Console.WriteLine("║     4 - Умножение Матрицы на число;    ║");
                Console.WriteLine("║        0 - Выход из программы;         ║");
                Console.WriteLine("╚════════════════════════════════════════╝\n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("\n");
                        Matrixs.OutputMatrix(matrixA);  // Метод вывода матрицы А.
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Matrixs.OutputMatrix(matrixB); // Метод вывода матрицы Б.
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        matrixC = matrixA * matrixB; // Операция умножения матриц.
                        if (matrixC.Line != 0)
                        {
                            Matrixs.OutputMatrix(matrixC);
                        }
                        else
                        {
                            Console.WriteLine("Умножение невозможно.");
                        }
                        break;

                    case 4:
                        bool choice = true;
                        double number;
                        Console.WriteLine("\nВведите число, на которое будете умножать.");
                        number = Program.ReadDouble();
                        while (choice)
                        {
                            Console.Write("\nВыберите Матрицу(A - 1, B - 2, C - 3, Выход - 0): ");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("\n");
                                    matrixA = number * matrixA; // Операция умножения матрицы на число.
                                    Matrixs.OutputMatrix(matrixA);
                                    choice = false;
                                    break;

                                case 2:
                                    Console.WriteLine("\n");
                                    matrixB = number * matrixB;
                                    Matrixs.OutputMatrix(matrixB);
                                    choice = false;
                                    break;

                                case 3:
                                    Console.WriteLine("\n");
                                    matrixC = number * matrixC;
                                    Matrixs.OutputMatrix(matrixC);
                                    choice = false;
                                    break;

                                case 0:
                                    choice = false; // Выход из программы.
                                    break;

                                default:
                                    Console.WriteLine("Некорректный выбор функции!");
                                    break;

                            }
                        }
                        break;

                    case 0:
                        isRun = false; // Выход из программы.
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор функции!");
                        break;
                }
            }
        }
        
        
        /// <summary>
        /// Метод для проверки вводимых целочисленных данных на корректность.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            string numeral = Console.ReadLine();
            int value;
            while (!Int32.TryParse(numeral, out value))
            {
                Console.WriteLine("Введённые данные не подходят. Введите корректное значение: ");
                numeral = Console.ReadLine();
            }
            return value;
        }
        /// <summary>
        /// Метод для проверки вводимых вещественных данных на корректность.
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            string numeral = Console.ReadLine();
            double value;
            while (!Double.TryParse(numeral, out value))
            {
                Console.WriteLine("Введённые данные не подходят. Введите корректное значение: ");
                numeral = Console.ReadLine();
            }
            return value;
        }
    }
}