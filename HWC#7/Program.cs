
  
void Task47()
{
    // Задача 47: 
    // Задайте двумерный массив размером m×n, заполненный случайными 
    // вещественными числами, округлёнными до одного знака.
    // m = 3, n = 4.
    // 0,57  -2  -0,2
    // 1   -3,38 -9,9
    // 8    7,8  -7,19

Console.WriteLine("Задайте количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
void FillArray(double[,] numbers)
{ 
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
            numbers[i, j] = Convert.ToDouble(random.Next(-99, 100)/10.0);
        }
    }
}

void PrintArray(double[,] numbers)
{ 
    for (int i = 0; i < rows; i++)
    { 
        for (int j = 0; j < columns; j++)
        { 
            Console.Write(numbers[i, j] + " \t");
        }
        Console.WriteLine();
    }

}

FillArray(numbers);
Console.WriteLine();
PrintArray(numbers);

// Random random = new Random();
// int rows = random.Next(3, 4);
// int columns = random.Next(3, 4); 

// double[,] numbers = new double[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         numbers[i, j] = Convert.ToDouble(random.Next(-99, 100)/10.0);
//     }
// }
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write(numbers[i, j] + " \t");
//     }
//     Console.WriteLine();
}

    void Task50()
    {  
        // Напишите программу, которая на вход принимает индексы элемента в двумерном 
        // массиве, и возвращает значение этого элемента или же указание, что такого 
        // элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
    
    Console.WriteLine("Задайте количество строк двумерного массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте количество столбцов двумерного массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Random random = new Random();
    int[,] numbers = new int[rows, columns];
    
    FillArray(numbers);
    PrintArray(numbers);
      
    Console.WriteLine("Введите индекс элемента ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (a > rows | b > columns) 
        {
            Console.WriteLine($"{a}{b} -> такого числа в массиве нет");
        }
    else
        {
            int c = numbers[a, b];
            Console.WriteLine(c);
        }    
       
        void FillArray(int[,] numbers)
        { 
            Random random = new Random();
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                { 
                    numbers[i, j] = random.Next(1, 10);
                }
            }
        }

        void PrintArray(int[,] numbers)
        { 
            for (int i = 0; i < rows; i++)
            { 
                for (int j = 0; j < columns; j++)
                { 
                    Console.Write(numbers[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }
    }
        
        void Task52()
        {
            // Задача 52: 
            // Задайте двумерный массив из целых чисел. Найдите среднее 
            // арифметическое элементов в каждом столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
            
            Random random = new Random();
            int rows = random.Next(3, 4);
            int columns = random.Next(3, 4); 
            int[,] numbers = new int[rows, columns];

            
            FillArray(numbers);
            PrintArray(numbers);
            for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        double sum = 0;
                        for (int i = 0; i < numbers.GetLength(0); i++)
                        {
                            sum += numbers[i, j];
                        }
                        Console.Write($"{ sum / numbers.GetLength(0)} ");
                    }
            Console.WriteLine();

                           
                void FillArray(int[,] numbers)
                { 
                    Random random = new Random();
                    int rows = numbers.GetLength(0);
                    int columns = numbers.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        { 
                            numbers[i, j] = random.Next(1, 10);
                        }
                    }
                }
                    void PrintArray(int[,] numbers)
                    { 
                        for (int i = 0; i < rows; i++)
                        { 
                            for (int j = 0; j < columns; j++)
                            { 
                                Console.Write(numbers[i, j] + " \t");
                            }
                            Console.WriteLine();
                        }
                    }          
               
        }  
               
        
    

   

    
    


//Task47();
Task50();
//Task52();


