void Task25()
{
    // Задача 25: Используя определение степени числа, напишите цикл, 
    // который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    
    Console.WriteLine("введите число A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int b = Convert.ToInt32(Console.ReadLine());
    //double back = Math.Pow(a, b);
    int back = 1;
    for (int i = 1; i <= b; i++)
    {
        back = back * a;
    }
    Console.WriteLine($"{a} в степени {b} -> {back}");
}

    void Task27()
    {
        // Задача 27: Напишите программу, которая принимает на вход число и 
        // выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12

        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int num = Math.Abs(number);
        int sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine($"Сумма цифр = {sum}");
    }

            void Task29()
            {
                // Задача 29: Напишите программу, которая задаёт массив из 8 
                // случайных целых чисел и выводит отсортированный по модулю массив.
                // -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
                // 6, 1, -33 -> [1, 6, -33]
                
                int[] Array = {-2,1,7,5,19};
                void PrintArray()
                {
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write(Array[i] + "  ");
                    }
                    Console.WriteLine();
                }
                PrintArray();
                for (int i = 1; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i; j++)
                    {
                        if (Math.Abs(Array[j]) > Math.Abs(Array[j+1]))
                        {
                            int temp = Array[j];
                            Array[j] = Array[j+1];
                            Array [j+1] = temp;
                        }
                    }
                }
                 PrintArray();
            }
           


//Task25();
//Task27();
Task29();