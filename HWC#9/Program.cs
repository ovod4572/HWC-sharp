void Task64()
{
    // Задача 64: 
    // Задайте значения M и N. Напишите рекурсивный метод, который выведет 
    // все натуральные числа кратные 3-ём в промежутке от M до N.
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    (m, n) = (n, m);
}
Console.Write($"M = {m}; N = {n}; -> ");
FindNatural(n, m);
Console.WriteLine();

void FindNatural(int n, int a = 0)
    {
        if (a < 1)
        {
            a = 0;
        }
        a++;
            if (a % 3 == 0)
            {
                Console.Write($"{a}, ");
            }    
                if (a >= n)
                {
                    return;
                }
        FindNatural(n, a);
    }
}

void Task66()
{
    // Задача 66: 
    // Задайте значения M и N. Напишите программу, которая найдёт 
    // сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (m > n)
{
    (m, n) = (n, m);
}
FindNatural(n, m);
Console.WriteLine($"M = {m}; N = {n}; -> {sum}");

void FindNatural(int n, int a = 0)
    {
        if (a < 1)
        {
            a = 0;
        }
        sum = sum + a;
        a++;
            if (a > n)
            {
                return;
            }
        FindNatural(n, a);
    }
}

void Task68()
{
    // Задача 68: 
    // Напишите программу вычисления функции Аккермана с 
    // помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

A(m,n);
Console.Write($"m = {m}, n = {n} -> A(m, n) = {A(m, n)}");
Console.WriteLine();

int A(int m, int n)
    {
        if (m == 0)
        {
            return 
            n + 1;
        }
        else 
            if (n == 0)
            {
                return 
                A(m - 1, 1);
            }
        else
        {
            return 
            A(m - 1, A(m, n - 1));
        }
    }
}



Task64();
//Task66();
//Task68();