using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void task4()
        {
            int num;

            num = Convert.ToInt16(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("Плохо"); break;
                case 2: Console.WriteLine("Неудовлетворительно"); break;
                case 3: Console.WriteLine("Удовлетворительно"); break;
                case 4: Console.WriteLine("Хорошо"); break;
                case 5: Console.WriteLine("Отлично"); break;
                default: Console.WriteLine("Введено неправельное число"); break;
            }

            if (num == 1)
            {
                Console.WriteLine("Плохо");
            }
            else if (num == 2)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (num == 3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (num == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (num == 5)
            {
                Console.WriteLine("Отлично");
            }
            else
            {
                Console.WriteLine("Введено неправельное число");
            }

            Console.ReadKey();

        }

        static void task5()
        {
            int operation;
            double a, b, otvet;

            Console.WriteLine("Введи число a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи число b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи номер операции");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            operation = Convert.ToInt16(Console.ReadLine());

            switch (operation)
            {
                case 1: Console.WriteLine("Сложение"); break;
                case 2: Console.WriteLine("Вычитание"); break;
                case 3: Console.WriteLine("Умножение"); break;
                case 4: Console.WriteLine("Деление"); break;
                default: Console.WriteLine("Введена неправельная операция"); break;
            }

            if (operation == 1)
            {
                otvet = a + b;
                Console.WriteLine(otvet);
            }
            else if (operation == 2)
            {
                otvet = a - b;
                Console.WriteLine(otvet);
            }
            else if (operation == 3)
            {
                otvet = a * b;
                Console.WriteLine(otvet);
            }
            else if (operation == 4)
            {
                otvet = a / b;
                Console.WriteLine(otvet);
            }
            else
            {
                Console.WriteLine(a + " ? " + b);
            }

            Console.ReadKey();
        }

        static void task6()
        {
            int xx, a, b, otvet;

            Console.WriteLine("Введи xx(двух-значное число)");
            xx = Convert.ToInt32(Console.ReadLine());

            if (xx <= 9)
            {
                Console.WriteLine("Введено не двух-значное число");
            }
            else if (xx >= 100)
            {
                Console.WriteLine("Введено не двух-значное число");
            }
            else
            {
                a = xx % 10;
                b = a * a;
                otvet = b % 10;

                Console.WriteLine("a(последнее число xx) = " + a);
                Console.WriteLine("b(квадрат a) = " + b);
                Console.WriteLine("Ответ(последнее число b) = " + otvet);
            }

            Console.ReadKey();
        }

        static void task7()
        {

        }
        static void Main(string[] args)
        {
            task6();
        }
    }
}
