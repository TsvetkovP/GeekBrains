﻿using System;

namespace lesson1

{
    class Task1 //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует программа <Анкета>");
            Console.WriteLine("Напишите ваше имя:");

            string имя = Console.ReadLine();

            Console.WriteLine("Напишите вашу фамилию:");

            string фамилия = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");

            string возраст = Console.ReadLine();

            Console.WriteLine("Какой у вас рост в см?");

            string рост = Console.ReadLine();

            Console.WriteLine("Сколько вы весите в кг?");

            string вес = Console.ReadLine();

            Console.WriteLine($"имя: {имя},фамилия: {фамилия},возраст: {возраст} лет,рост: {рост} см.,вес: {вес} кг.");

        }
    }
}

namespace lesson1

{
    class Task2 //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

    {
        public static void Main2(string[] args)

        {

            Console.WriteLine("Я могу рассчитать и вывести индекс массы тела!");

            Console.WriteLine("введите ваш вес в кг:");

            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("введите ваш рост в м:");

            double h = double.Parse(Console.ReadLine());


            double indM = m / (h * h);
            Console.WriteLine(indM.ToString());
        }
    }
}

namespace lesson1

{
    class Task3 //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
                //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    {
        public static void Main3(string[] args)

        {
            Console.Write("Введите координату x1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату y1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату x2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками", r);

            Console.ReadKey();

        }
    }
}

namespace lesson1

{
    class Task4 //Написать программу обмена значениями двух переменных с использованием третьей переменной;

    {
        public static void Main4(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int tmp;

            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}

