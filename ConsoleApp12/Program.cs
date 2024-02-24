internal class Program
{
    private static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Введите номер задачи 1 до 4");
            switch (Console.ReadLine())
            {
                case "1":
                    TaskOne();
                  
                break;
                case "2":
                    TaskTwo();
                break;

                case "3":
                    TaskThree();
                break;
                case "4":
                    TaskFour();
                    break;
                default:
                    Environment.Exit(0);
                break;
            }
        }
    }
    public static void TaskOne()
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());

        // Проверка кратности 7 и 23
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine($"a={a}  => Да");
        }
        else
        {
            Console.WriteLine($"a={a}  => Нет");
        }
    }
    public static void TaskTwo()
    {
        // Ввод координат точки
        Console.Write("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        // Проверка на ненулевые значения координат
        if (x == 0 || y == 0)
        {
            Console.WriteLine("Координаты не могут быть равны нулю.");
            return;
        }

        // Определение номера координатной четверти
        int quadrant;
        if (x > 0 && y > 0)
        {
            quadrant = 1;
        }
        else if (x < 0 && y > 0)
        {
            quadrant = 2;
        }
        else if (x < 0 && y < 0)
        {
            quadrant = 3;
        }
        else
        {
            quadrant = 4;
        }

        Console.WriteLine($"{x}, {y}  =>  {quadrant}");
    }
    public static void TaskThree()
    {
        // Ввод числа
        Console.Write("Введите целое число от 10 до 99: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка на корректность введенного числа
        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число не принадлежит заданному диапазону.");
            return;
        }

        // Определение наибольшей цифры
        int maxDigit = number % 10; // Последняя цифра числа
        int firstDigit = number / 10; // Первая цифра числа

        if (firstDigit > maxDigit)
        {
            maxDigit = firstDigit;
        }

        Console.WriteLine($"{number}  => {maxDigit}");
    }
    public static void TaskFour()
    {
        Console.Write("Введите натуральное число N: ");
        int number = int.Parse(Console.ReadLine());

        // Вывод цифр числа через запятую
       
        string numberString = number.ToString(); // Преобразуем число в строку

        // Перебираем каждый символ в строке числа
        for (int i = 0; i < numberString.Length; i++)
        {
            Console.Write(numberString[i]); // Выводим текущий символ

            // Если текущий символ не последний, выводим запятую
            if (i < numberString.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
    }
}