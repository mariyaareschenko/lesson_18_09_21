using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание А1.1");
            int sec = Convert.ToInt32(Console.ReadLine());
            int hour = sec / 3600;
            int minute = (sec - hour * 3600) / 60;
            sec = sec - hour * 3600 - minute * 60;
            Console.WriteLine("С начала суток прошло {0} часов {1} минут {2} секунд", hour, minute, sec);

            Console.WriteLine("Задание А1.2");
            int len_rectangle_1 = 543;
            int len_rectangle_2 = 130;
            int len_square = 130;
            int count = (len_rectangle_1 / len_square) * (len_rectangle_2 / len_square);
            Console.WriteLine("{0} квадрата можно отрезать", count);

            Console.WriteLine("Задание A1.3");
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n & n <= 11)
            {
                int x = n + 1;
                Console.WriteLine(x);
            }
            else if (n == 12)
            {
                int x = 1;
                Console.WriteLine(x);
            }

            Console.WriteLine("Задание A1.4");
            int num = Convert.ToInt32(Console.ReadLine());
            int count_doz = num / 10;
            int count_units = num % 10;
            int sum = count_doz + count_units;
            int product = count_doz * count_units;
            Console.WriteLine("Число десятков: {0}\n Число единиц: {1}\n Сумма цифр: {2}\n Произведение цифр:{3}", count_doz, count_units, sum, product);

            Console.WriteLine("Задание A1.5");
            num = Convert.ToInt32(Console.ReadLine());
            count_doz = num / 100;
            int num_2 = num - count_doz * 100;
            int finally_num = num_2 * 10 + count_doz;
            Console.WriteLine("Полученное число: {0}", finally_num);

            Console.WriteLine("Задание A1.6");
            finally_num = 237;
            count_units = finally_num / 100;
            num_2 = finally_num - count_units * 100;
            num = num_2 * 10 + count_units;
            Console.WriteLine("Исходное число: {0}", num);

            Console.WriteLine("Задание A1.7");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            while ((a1 + b1 + (a2 + b2) * 10) < 100)
            {
                int c1 = (a1 + b1) % 10;
                int c2 = a2 + b2 + (a1 + b1) / 10;
                Console.WriteLine("Полученные цифры: {0} {1}", c2, c1);
                break;
            }

            Console.WriteLine("Задание A1.8");
            int k = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Задание 1.9");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine("A или B: {0}", A | B);
            Console.WriteLine("A и B: {0}", A & B);
            Console.WriteLine("B или C: {0}", B | C);

            Console.WriteLine("Задание 1.10");
            bool X = Convert.ToBoolean(Console.ReadLine());
            bool Y = Convert.ToBoolean(Console.ReadLine());
            bool Z = Convert.ToBoolean(Console.ReadLine());
            bool a = !(X | Y) & (!X | !Z);
            bool b = !(!X & Y) | (X | !Z);
            bool c = X | !Y & !(X | !Z);
            Console.WriteLine("a) {0}", a);
            Console.WriteLine("б) {0}", b);
            Console.WriteLine("в) {0}", c);

            Console.ReadKey();
        }
    }
}
