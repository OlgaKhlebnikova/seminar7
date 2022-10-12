Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if (Task == 1)
{
    Task1();
}
else if (Task == 2)
{
    Task2();
}
else if (Task == 3)
{
    Task3();
}


// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task1()
{
    Console.WriteLine("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами. ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Random num1 = new Random();
    double namber1 = Math.Round(num1.NextDouble(), 2);

    Random num2 = new Random();
    double namber2 = Math.Round(num2.NextDouble(), 2);

    Console.WriteLine($"Массив будет состоять из случайных вещественных чисел между {namber1} и {namber2}");
    Console.WriteLine();
    double min, max;
    if (namber1 < namber2)
    {
        min = namber1;
        max = namber2;
    }
    else
    {
        min = namber2;
        max = namber1;
    }

    double[,] array = FillArray(rowCount, columnCount, min, max);
    PrintArray(array);

    double[,] FillArray(int rows, int columns, double min, double max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}

void Task2()
{
    Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    double[,] array = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    ArithmeticMean(array);

    double[,] FillArray(int rows, int columns, int min, int max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }

    void ArithmeticMean(double[,] array)
    {

        double sum = 0;
        double average = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = 0;
            average = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                {
                    sum = sum + array[i, j];
                    average = sum / array.GetLength(0);
                }

            }



            Console.WriteLine($"Среднее арифметическое столбца {j + 1}({j})  равно {average}");


        }


    }
}



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void Task3()
{
    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = Convert.ToInt32(Console.ReadLine());

    
    string? userString = " ";
    Console.WriteLine("Введите через запятую позиции элемента, который хотите найти в массиве");
    userString = Console.ReadLine();

    //Console.WriteLine("Пользователь ввел строку: " + userString);

    string?[] Num = userString.Split(',');

    int[] numbers = Num.Select(int.Parse).ToArray();
    Console.WriteLine($"Позиция в строке {numbers[0]} в столбце {numbers[1]}");

    double[,] array = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine();

    PrintArray(array);
    Console.WriteLine();   

    SearchPositions(array);
    Console.WriteLine();

    double[,] FillArray(int rows, int columns, int min, int max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }

    

    void SearchPositions(double[,] array)
    {
        if (numbers[0] > array.GetLength(0) || numbers[1] > array.GetLength(0))
        {
            Console.WriteLine($"Такого числа в массиве нет");
        }
        else if (numbers[0] < 0 || numbers[1] < 0)
        {
            Console.WriteLine($"Введите положительные числа");
        }
        
        for (int i = 0; i < array.GetLength(0); i++)        
        {             
            for (int j = 0; j < array.GetLength(1); j++)
            {   
                if ( i == numbers[0] && j == numbers[1])
                {                       
                    Console.WriteLine($" Число в массиве  {array [i,j]}");                       
                }               
               
            }                     
        }
              
        
    }
}









