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
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            { 
                for (int j = 0; j < columns; j++)
                { 
                    Console.Write(numbers[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }        

void SortArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        
        for (int i = 0; i < rows; i++)
            {
            for (int j = 0; j < columns; j++)
            {            
                for (int k = 0; k < columns - j - 1; k++)
                {
                    if (numbers[i, k] < numbers[i, k+1]) //поменять знак при возрастании
                    {
                        (numbers[i, k], numbers[i, k+1]) = (numbers[i, k+1], numbers[i, k]);
                    }
                }
            }
        }
    }

int SumInRow(int[,] numbers, int i)
{
    int columns = numbers.GetLength(1);
    int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[i, j];
        }
        return sum;
}

void Task54()
{
        // Задача 54: 
        // Задайте двумерный массив. Напишите программу, которая упорядочит 
        //по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2

    // Console.WriteLine("Задайте количество строк двумерного массива:");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Задайте количество столбцов двумерного массива:");
    // int columns = Convert.ToInt32(Console.ReadLine());
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);
    
    Console.WriteLine();
    PrintArray(numbers);
}

void Task56()
{
        // Задача 56: 
        // Задайте прямоугольный двумерный массив. Напишите программу, 
        // которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер 
        // строки с наименьшей суммой элементов: 1 строка
    
    // Console.WriteLine("Задайте количество строк двумерного массива:");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Задайте количество столбцов двумерного массива:");
    // int columns = Convert.ToInt32(Console.ReadLine());
    int rows = 4;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);

    int sumMin =  SumInRow(numbers, 0);
    int indexMin = 0;
    
    Console.WriteLine($"Сумма {indexMin + 1} строки равна {sumMin}");

    for (int i = 1; i < rows; i++)
    {
        int sum = SumInRow(numbers, i);
        Console.WriteLine($"Сумма {i+1} строки равна {sum}");
        
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"min -> {sumMin}   stroke -> {indexMin + 1}");
}  

void Task58()
{
        // Задача 58: 
        // Напишите программу, которая заполнит спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

    // Console.WriteLine("Задайте количество строк двумерного массива:");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Задайте количество столбцов двумерного массива:");
    // int columns = Convert.ToInt32(Console.ReadLine());
    int rows = 10;
    int columns = 7;
    int[,] numbers = new int[rows, columns];
    
    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;

    int changeIndexRow = 0;
    int changeIndexColumn = 1;

    int steps = columns;
    int turn = 0;

    while(index < numbers.Length)
    {
        numbers[currentRow, currentColumn] = index + 1;
        index++;
        steps--;
        if (steps == 0)
        {
            // if (turn % 2 == 0)
            // {
            //     steps = rows - 1 - turn/2;
            // }
            // else
            // {
            //     steps = columns - 1 - turn/2;
            // }
            steps = rows*((turn+1)%2) + columns*(turn%2) - 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;
        }
        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    PrintArray(numbers);
}

//Task54();
//Task56();
Task58();