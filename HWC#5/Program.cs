void FillArray(int[] numbers,
                    int minValye = 0,
                    int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValye, maxValue);
    }
}
    void PrintArray(int[] numbers)
    {
        int size = numbers.Length;
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
        Console.WriteLine();
    }
        void FillArrayDouble(double[] numbers,
                        double minValye = 0,
                        double maxValue = 9)
        {
            maxValue++;
            double size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                double value = random.NextDouble() * 200 - 100; // (-100, 100)
                numbers[i] = Math.Round(value, 2);
            }
        }
            void PrintArrayDouble(double[] numbers)
            {
                double size = numbers.Length;
                Console.WriteLine("Вывод массива: ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(numbers[i] + "   ");
                }
                Console.WriteLine();
            }



void Task34()
{
// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0) count++;

    }
    Console.WriteLine("Kоличество чётных чисел в массиве: " + count);

}
    void Task36()
    {
    // Задача 36. 
    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов с нечётными индексами.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

        int size = 4;
        int[] numbers = new int[size];
        FillArray(numbers, -99, 100);
        PrintArray(numbers);

        int sum = 0;
        for (int i = 1; i < size; i += 2) // for (int i = 0; i < size; i ++);
        {
            sum += numbers[i]; // sum = sum + numbers[i];
        }
        Console.WriteLine("Сумма элементов с нечётными индексами в массиве: " + sum);
    }

        void Task38()
        {
        // Задача 38:
        // Задайте массив вещественных чисел. Найдите разницу между 
        // максимальным и минимальным элементов массива.
        //[3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95
            
            Console.WriteLine("Введите размер массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            if ( size > 0)
            {
                double[] numbers = new double[size];
                FillArrayDouble(numbers);
                PrintArrayDouble(numbers);
                
                double min = numbers[0];
                double max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    if (numbers[i] < min)
                        {
                            min = numbers[i];
                        }
                }
                //double result = Math.Round(max - min, 2);
                Console.WriteLine($"max = {max}, min = {min}, difference = {max-min}");
            }
            else
                {
                    Console.WriteLine("Ошибка ввода");
                }     
        
        }


//Task34();
//Task36();
Task38();