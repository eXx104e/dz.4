class Program
{
    static int MaxValue(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    static void Swap(ref string str1, ref string str2)
    {
        (str1, str2) = (str2, str1);
        Console.WriteLine($"Теперь: строка_1 = {str1}, строка_2 = {str2}");
    }

    static bool Factorial(ref long number)
    {
        int temp_number = (int)number;
        number = 1;
        for (int i = 1; i <= temp_number; i++)
        {
            try
            {
                checked
                {
                    number *= i;
                }
            }
            catch
            {
                return false;
            }

        }
        return true;
    }

    static int Recursiya(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        else
        {
            return num * Recursiya(num - 1);
        }
    }

    static void NOD2()
    {
        int nod;
        Console.WriteLine("Введите первое число");
        int NUM1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int NUM2 = int.Parse(Console.ReadLine());
        while (NUM2 != NUM1)
        {
            if (NUM2 > NUM1)
            {
                NUM2 = NUM2 - NUM1;
            }
            else
            {
                NUM1 = NUM1 - NUM2;
            }
        }
        nod = NUM1;
        Console.WriteLine($"НОД: {nod}");

    }

    static void NOD3()
    {
        Console.WriteLine("Введите первое число");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        int num3 = int.Parse(Console.ReadLine());
        int NOD = Math.Min(num1, Math.Min(num2, num3));
        for (; NOD > 1; NOD--)
        {
            if (num1 % NOD == 0 && num2 % NOD == 0 && num3 % NOD == 0)
            {
                break;
            }
        }
        Console.WriteLine($"NOD: {NOD}");
    }

    static void Fibonachi()
    {
        Console.WriteLine("Введите порядковый номер числа ряда фиббоначи");
        int num = int.Parse(Console.ReadLine());
        if (num > 48)
        {
            Console.WriteLine("Вы вышли за предел возможности программы");
        }
        else if (num < 0)
        {
            Console.WriteLine("числа под таким номером не существует");
        }
        else
        {
            int num_1 = 1;
            int num_2 = 1;
            int sum;
            int j = 2;
            while (j <= num)
            {
                sum = num_1 + num_2;
                num_1 = num_2;
                num_2 = sum;
                j++;
            }
            Console.WriteLine($"Под номером {num} в ряде Фибоначчи стоит число {num_1}");
        }
    }

    static void Main(String[] args)
    {

        Console.WriteLine("Задание 1. Вывести максимальное значение");
        Console.WriteLine();
        Console.WriteLine($"Максимальное значение: {MaxValue(123, 91)}");
        Console.Clear();


        Console.WriteLine("Задание 2. Поменять местами значения");
        Console.WriteLine();
        string str1 = "Привет";
        string str2 = "Пока";
        Console.WriteLine($"В начале: строка_1 = {str1}, строка_2 = {str2}");
        Swap(ref str1, ref str2);
        Console.Clear();


        Console.WriteLine("Задание 3. Вычислить факториал");
        Console.WriteLine();
        long number = 15;
        Console.WriteLine(Factorial(ref number));
        Console.WriteLine(number);
        Console.Clear();


        Console.WriteLine("Задание 4. Рекурсия");
        Console.WriteLine();
        int number1 = 11;
        Console.WriteLine($"Факториал {number1} равен:{Recursiya(number1)}");
        Console.Clear();


        NOD2();
        Console.Clear();


        NOD3();
        Console.Clear();


        Fibonachi();
        Console.Clear();
    }
}