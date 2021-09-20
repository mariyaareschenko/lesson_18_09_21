using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Тип byte: " + byte.MaxValue.ToString() + " " + byte.MinValue.ToString());
            Console.WriteLine("Тип sbyte: " + sbyte.MaxValue.ToString() + " " + sbyte.MinValue.ToString());
            Console.WriteLine("Тип short: " + short.MaxValue.ToString() + " " + short.MinValue.ToString());
            Console.WriteLine("Тип ushort: " + ushort.MaxValue.ToString() + " " + ushort.MinValue.ToString());
            Console.WriteLine("Тип int: " + int.MaxValue.ToString() + " " + int.MinValue.ToString());
            Console.WriteLine("Тип uint: " + uint.MaxValue.ToString() + " " + uint.MinValue.ToString());
            Console.WriteLine("Тип long: " + long.MaxValue.ToString() + " " + long.MinValue.ToString());
            Console.WriteLine("Тип ulong: " + ulong.MaxValue.ToString() + " " + ulong.MinValue.ToString());
            Console.WriteLine("Тип float: " + float.MaxValue.ToString() + " " + float.MinValue.ToString());
            Console.WriteLine("Тип double: " + double.MaxValue.ToString() + " " + double.MinValue.ToString());
            Console.WriteLine("Тип decimal: " + decimal.MaxValue.ToString() + " " + decimal.MinValue.ToString());
            Console.WriteLine("Тип DateTime: " + DateTime.MaxValue.ToString() + " " + DateTime.MinValue.ToString());

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Город: ");
            string city = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PIN-код: ");
            int PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", name, city, age, PIN);

            Console.WriteLine("Задание 3");
            string str = Console.ReadLine();
            string new_str = "";
            foreach(var c in str)
            {
                if (char.IsLower(c))
                    new_str += char.ToUpper(c);
                else
                    new_str += char.ToLower(c);
            }
            Console.WriteLine(new_str);

            Console.WriteLine("Задание 4");
            str = Console.ReadLine();
            string substring = Console.ReadLine();
            int count = (str.Length - str.Replace(substring, "").Length) / substring.Length;
            Console.WriteLine("Количество вхождений: {0}", count);

            Console.WriteLine("Задание 5");
            double speed = Convert.ToDouble(Console.ReadLine());
            double speed_2 = Math.Floor((speed * 1000 * 100) / 3600);
            Console.WriteLine("Скорость таракана в см/с = {0}", speed_2);

            Console.WriteLine("Задание 6");
            double age_father = Convert.ToDouble(Console.ReadLine());
            double age_son = Convert.ToDouble(Console.ReadLine());
            if (2 * age_son < age_father)
            {
                double difference = age_father - age_son * 2;
                Console.WriteLine("Отец был вдове старше сына {0} лет назад", difference);
            }
            else if (age_father == age_son * 2)
                Console.WriteLine("Отец сейчас вдвое старше своего сына");
            else
            {
                double difference = age_son * 2 - age_father;
                Console.WriteLine("Отец будет вдвое старше сына через {0} год(а)/лет", difference);
            }

            Console.WriteLine("Задание 7");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            int salePrice = Convert.ToInt32(Console.ReadLine());
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double sale = (double) normPrice * (double)salePrice / 100;
            double num_bottles = (double) holidayPrice / sale;
            Console.WriteLine("Необходимое количество бутылок: {0}", Math.Floor(num_bottles));

            Console.ReadKey();
        }
    }
}
