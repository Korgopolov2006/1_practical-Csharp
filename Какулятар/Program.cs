// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выберите какое действие вы хотите выполнить:");
Console.WriteLine("1.Сложить два числа");
Console.WriteLine("2.Вычесть первое число из второго");
Console.WriteLine("3.Умножить первое число на второе");
Console.WriteLine("4.Разделить первое число на второе");
Console.WriteLine("5.Возвести в степень N первое число");
Console.WriteLine("6.Найти квадратный корень числа");
Console.WriteLine("7.Найти 1 процент из числа");
Console.WriteLine("8.Найти факториал из числа");
Console.WriteLine("9.Выйти из программы");


string input = Console.ReadLine();
int x = Convert.ToInt32(input);
do
{

    if (x == 1)
    {
        Console.WriteLine("Введите первое число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Введите второе число");
        string vtroe = Console.ReadLine();
        int vtoroecheslo = Convert.ToInt32(vtroe);
        Console.WriteLine("Результат:");
        Console.WriteLine(pervoecheslo + vtoroecheslo);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 2)
    {
        Console.WriteLine("Введите первое число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Введите второе число");
        string vtroe = Console.ReadLine();
        int vtoroecheslo = Convert.ToInt32(vtroe);
        Console.WriteLine("Результат:");
        Console.WriteLine(pervoecheslo - vtoroecheslo);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 3)
    {
        Console.WriteLine("Введите первое число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Введите второе число");
        string vtroe = Console.ReadLine();
        int vtoroecheslo = Convert.ToInt32(vtroe);
        Console.WriteLine("Результат:");
        Console.WriteLine(pervoecheslo * vtoroecheslo);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 4)
    {
        Console.WriteLine("Введите первое число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Введите второе число");
        string vtroe = Console.ReadLine();
        int vtoroecheslo = Convert.ToInt32(vtroe);
        Console.WriteLine("Результат:");
        Console.WriteLine(pervoecheslo / vtoroecheslo);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 5)
    {
        Console.WriteLine("Введите число, которое хотите возвести в степень");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Введите cтепень , в которую хотите возвести число");
        string vtroe = Console.ReadLine();
        int vtoroecheslo = Convert.ToInt32(vtroe);
        Console.WriteLine("Результат:");
        Console.WriteLine(Math.Pow(pervoecheslo,vtoroecheslo));
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 6)
    {
        Console.WriteLine("Введите число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("Квадратный корень заданного числа равен :");
        Console.WriteLine(Math.Sqrt(pervoecheslo));
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 7)
    {
        Console.WriteLine("Введите первое число");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        Console.WriteLine("1% от заданного числа:");
        Console.WriteLine(pervoecheslo/100);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 8)
    {
        Console.WriteLine("Введите число, фактариал которого выхотите узнать");
        string pervoe = Console.ReadLine();
        int pervoecheslo = Convert.ToInt32(pervoe);
        int factorial = 1;   
        for (int i = 2; i <= pervoecheslo; i++) 
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Результат:");
        Console.WriteLine(factorial);
        Console.WriteLine("Введите номер действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
} while (x != 9);
Console.WriteLine("Вы вышли из программы. Программа завершена.");


