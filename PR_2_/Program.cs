class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Вам предложены 3 функции:\n" +
            "1. Игра \"Угадай число\"\n" +
            "2. Таблица умножения\n" +
            "3. Вывод делителей числа\n" +
            "Выберите одну из них: ");
        string result = Console.ReadLine();
        switch (result)
        {
            case "1":
                game();
                break;
            case "2":
                table();
                break;
            case "3":
                ints();
                break;
        }
    }
    static void game()
    {
        Console.Clear();
        Random rnd = new Random();
        int random = rnd.Next(100);
        Console.WriteLine("В этой игр Вам нужно угадать число от 1 до 100, в зависимости от Вашего ответа вам будет выдаваться ответ правильности, то есть больше, меньше или равно число которое Вы ввели, Удачи!");
        int user = -1;
        do
        {
            try
            {
                user = Convert.ToInt32(Console.ReadLine());
                if (random > user)
                {
                    Console.WriteLine("Нужно больше");
                }
                else if (random < user)
                {
                    Console.WriteLine("Нужно меньше");
                }
                else
                {
                    Console.WriteLine("Поздравляю - Вы угадали!!!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Thread.Sleep(1000); Main(); }
        } while (user != 0 && user != random);
        Thread.Sleep(2000);
        Main();
    }
    static void table()
    {
        Console.Clear();
        Console.WriteLine("Таблица умножения: ");
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine('\n');
        }
        Thread.Sleep(2000);
        Main();
    }
    static void ints()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Введите число, делители которого хотите узнать: ");
            int search = Convert.ToInt32(Console.ReadLine());
            if (search < 0)
            {
                Console.WriteLine("Нужно число больше 0");
            }
            else
            {
                Console.WriteLine("Делители:");
                for (int i = search; i > 0; i--)
                {
                    if (search % i == 0)
                    {
                        Console.Write($"{i}\t");
                    }
                }
                Thread.Sleep(2000);
                Main();
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); Thread.Sleep(1000); Main(); }

    }
}