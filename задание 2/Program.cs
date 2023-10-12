using System.ComponentModel.Design;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Выберите действие\n1.Игра угадай число\n2.Таблица умножения\n3.Вывод делителей числа\n0.Выход");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Igrushechka();
                        break;
                    case 2:
                        tabliza();
                        break;
                    case 3:
                        deliteli();
                        break;
                    case 0:
                        Console.WriteLine("пока");
                        return;
                }
            }

        }
        static void Igrushechka()
        {
            {
                Console.WriteLine("Введите число");
                Random rnd = new Random();
                int value = rnd.Next(11);
                int count = 1;
                Console.WriteLine("Компьютер загадал  число от 0 до 10");
                Console.WriteLine("Введите первое число");
                int b = Convert.ToInt32(Console.ReadLine());
                while (count <= 5)
                {
                    if (value == b)
                    {
                        Console.WriteLine("Вы победили");
                        break;
                    }
                    else
                    {
                        count++;
                        if (count == 6)
                        {
                            Console.WriteLine("Увы вы не угадали загаданное число. Это было " + value);
                            break;
                        }
                        Console.WriteLine("Нет это не число " + b + "! Попытка " + (count - 1));
                        b = Convert.ToInt32(Console.ReadLine());


                    }
                }
            }
        }
        static void tabliza()
        {
            var tableza = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tableza[i, j] = i * j;
                }
            }
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    Console.Write("{0, 4}", tableza[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void deliteli()
        {
            Console.WriteLine("Введите число");
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <=i ; a++)
            {
                if (i % a == 0) 
                Console.WriteLine("{0} ", a);
            }
        }
    }
}