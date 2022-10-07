class Program
{
    static void Equation(double a, double b, double c)
    {
        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Корней нет");
        }
        else if (D == 0)
        {
            Console.WriteLine($"Уравнение имеет одни корень: {-b / (2 * a)}");
        }
        else
        {
            Console.WriteLine($"Уравнение имеет два корня: {(-b + Math.Pow(D, 0.5)) / (2 * a)} и {(-b - Math.Pow(D, 0.5)) / (2 * a)}");
        }
    }

    static int IndexOf(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    static int[] BubbleSort(int[] mass)
    {
        for (int i = 0; i < mass.Length - 1; i++)
        {
            for (int j = 0; j < mass.Length - i - 1; j++)
            {
                if (mass[j] > mass[j + 1])
                {
                    (mass[j + 1], mass[j]) = (mass[j], mass[j + 1]);
                }
            }
        }
        return mass;
    }

    static int MassiveOperations(ref uint prois, out double average, params uint[] mass)
    {
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            sum += mass[i];
            prois *= mass[i];
        }
        average = Math.Round(sum / mass.Length, 2);
        Console.WriteLine($"Среднее значение массива: {average}");
        Console.WriteLine($"Произведение массива: {prois}");
        Console.WriteLine($"Сумма массива");
        return (int)sum;
    }

    struct GrandFather
    {
        public string name;
        public byte level_angry;
        public string[] frasi;
        public byte fingali;
        enum Level_angry
        {
            Под_водкой, Бабка_не_посолила_суп, Не_уступили_место, Бабка_не_отпустила_на_рыбалку, Дали_на_1р_меньше_сдачи
        }
        public GrandFather(string name, byte Level_angry, string[] frasi, byte fingali)
        {
            this.name = name;
            this.level_angry = Level_angry;
            this.frasi = frasi;
            this.fingali = fingali;
        }
    }

    static byte Fingali(GrandFather grandFather, params string[] words)
    {
        byte fingali = 0;
        foreach (string n in grandFather.frasi)
        {
            if (n == "На палкой по лбу" || n == "Бездельники" || n == "Проститутки" || n == "Наркоманы" || n == "Оболтусы" || n == "Гады" || n == "Сталина на тебя нет")
            {
                fingali++;
            }
        }
        return fingali;
    }

    static int[] FastSort(ref int[] massive)
    {
        int len_mass = massive.Length;
        for (int i = 0; i < len_mass; i++)
        {
            (massive[i], massive[IndexOf(massive, massive[i..len_mass].Min())]) = (massive[IndexOf(massive, massive[i..len_mass].Min())], massive[i]);
        }
        return massive;
    }


    static void Main(String[] args)
    {
        Console.WriteLine("Задание 1. Метод для решения квадр. уравнения");
        Console.WriteLine();
        Console.WriteLine("Введите через пробел: коэффициент при x^2, x и свободный член");
        double[] abc = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Equation(abc[0], abc[1], abc[2]);
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Задание 2. Поменять 2 числа массива из 20");
        Console.WriteLine();
        Random rnd = new Random();
        int[] massive = new int[] {rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000),
            rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000),
            rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000), rnd.Next(10000),
            rnd.Next(10000), rnd.Next(10000), rnd.Next(10000)};
        Console.WriteLine(String.Join(" ", massive));
        Console.WriteLine("Введите через пробел 2 числа, которые поменяются местами");
        ushort[] numbers = Console.ReadLine().Split(" ").Select(ushort.Parse).ToArray();
        (massive[IndexOf(massive, numbers[0])], massive[IndexOf(massive, numbers[1])]) = (massive[IndexOf(massive, numbers[1])], massive[IndexOf(massive, numbers[0])]);
        Console.WriteLine();
        Console.WriteLine(String.Join(" ", massive));
        Console.Clear();


        Console.WriteLine("Задание 3. Сортировка пузырьком");
        Console.WriteLine();
        int[] Massive = new int[] { 231, 31111, 4678, 21, 5357, 211, 780, 2421, 2 };
        Console.WriteLine($"Изначальный массив: {string.Join(" ", Massive)}");
        Console.WriteLine($"Отсортированный массив: {string.Join(" ", BubbleSort(Massive))}");
        Console.Clear();


        Console.WriteLine("Задание 4. Работа с params");
        Console.WriteLine();
        uint[] massiv = new uint[] { 32, 23, 46, 22, 68, 12, 32, 11, 67 };
        uint prois = 1;
        double average;
        Console.WriteLine(MassiveOperations(ref prois, out average, massiv));
        Console.Clear();


        Console.WriteLine("Задание 5. Взаимодействие с консолью");
        Console.WriteLine();
        Console.WriteLine("Введите целое число от 0 до 9");
        int num = int.Parse(Console.ReadLine());
        string[] numberss = new string[]
                {"###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###",
                 " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###",
                 " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###",
                 "## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ",
                 "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###",
                 "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ",
                 " ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###",
                 "###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ",
                 "###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###",
                 "###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###"};
        try
        {
            if (num < 0 || num > 9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неправильное число");
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(numberss[num]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число");
        }
        string word = Console.ReadLine();
        if (word == "exit" || word == "закрыть")
        {
            Environment.Exit(0);
        }
        Console.Clear();


        Console.WriteLine("Задание 6. Создать деда");
        Console.WriteLine();
        string[] ded1 = new string[] { "Сталина на тебя нет", "Проститутки", "Гады" };
        GrandFather grandFather1 = new GrandFather("Михалыч", 0, ded1, 0);
        string[] ded2 = new string[] { "Наркоманы", "На палкой по лбу" };
        GrandFather grandFather2 = new GrandFather("Васильич", 4, ded2, 0);
        string[] ded3 = new string[] { "Бездельники" };
        GrandFather grandFather3 = new GrandFather("Петрович", 3, ded3, 0);
        string[] ded4 = new string[] { "Катись отсюда", "Щас вам руки повырываю", "А вот в наше время такого не было", "Бездельники" };
        GrandFather grandFather4 = new GrandFather("Степаныч", 1, ded4, 0);
        string[] ded5 = new string[] { "Эх, в СССР было лучше", "Оболтусы", "Проститутки", "Сталина на тебя нет", "Тьфу на вас" };
        GrandFather grandFather5 = new GrandFather("Иваныч", 2, ded5, 0);
        string[] spisok_babki = new string[] { "Бездельники", "Проститутки", "Наркоманы", "Оболтусы", "Гады", "Сталина на тебя нет" };
        Console.WriteLine();
        Console.WriteLine($"У {grandFather1.name}а - {Fingali(grandFather1, spisok_babki)} фингалов");
        Console.WriteLine($"У {grandFather2.name}а - {Fingali(grandFather2, spisok_babki)} фингалов");
        Console.WriteLine($"У {grandFather3.name}а - {Fingali(grandFather3, spisok_babki)} фингалов");
        Console.WriteLine($"У {grandFather4.name}а - {Fingali(grandFather4, spisok_babki)} фингалов");
        Console.WriteLine($"У {grandFather5.name}а - {Fingali(grandFather5, spisok_babki)} фингалов");
        Console.Clear();


        Console.WriteLine("Задание 7. Быстрая сортировка");
        int[] MASSIVE = new int[] { 1, 32, 121, 3, 10, 129, 18, 9, 4, 165, 1024, 234, 34, 60, 649, 800, 29, 100, 2, 78 };
        Console.WriteLine($"Изначальный массив: {String.Join(" ", MASSIVE)}");
        Console.WriteLine($"Отсортированный массив: {String.Join(" ", FastSort(ref MASSIVE))}");
        Console.Clear();
    }
}