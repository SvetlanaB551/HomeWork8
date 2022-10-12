//  Задача 54 Задайте двумерный массив.
// Напишите программу, которая упорядочит по возрастанию 
//элементы каждой строки двумерного массива.
void Ex54()
{
int x = 3;
int y = 5;
int min = 1;
int max = 9;
int[,] array = new int[x,y];

Console.Clear();
FillArrayRandomNumber(array, min, max);
Console.WriteLine("Массив");
PrintDoubleArray(array);
SortNumberInArrayLines(array);
Console.WriteLine();
PrintDoubleArray(array);

void FillArrayRandomNumber(int[,] array, int min = 0, int max = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortNumberInArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = j + 1; h < array.GetLength(1); h++)
            {
                if (array[i, j] > array[i, h])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, h];
                    array[i, h] = temp;
                }
            }
        }
    }
}
}
Ex54();

// Задача 56 Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

void Ex56()
{
int x = 3;
int y = 5;
int min = 1;
int max = 9;
int[,] array = new int[x,y];

Console.Clear();
FillArrayRandomNumber(array, min, max);
Console.WriteLine();
PrintDoubleArray(array);
Console.WriteLine("Строка с минимальной суммой элементов - " + SearchMinSumInLines(array));

void FillArrayRandomNumber(int[,] array, int min = 0, int max = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SearchMinSumInLines(int[,] array)
{
    int[] sumInLines = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInLines[i] += array[i, j];
        }
    }

    int index = 0;
    int minSum = sumInLines[index];

    for (int i = 1; i < sumInLines.Length; i++)
    {
        if (minSum > sumInLines[i])
        {
            index = i;
            minSum = sumInLines[i];
        }
    }

    return index + 1;
}
}
Ex56();

// Задача 58 Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.


void Ex58()
{
int x = 4;
int y = 4;
int min = 1;
int max= 10;
int[,] firstArray = new int[x, y];
int[,] secondArray = new int[x, y];
int[,] resultArray = new int[x, y];

Console.Clear();
FillArrayRandomNumber(firstArray, min, max);
Console.WriteLine("Первая матрица");
PrintDoubleArray(firstArray);
FillArrayRandomNumber(secondArray, min, max);
Console.WriteLine("Вторая матрица");
PrintDoubleArray(secondArray);
Console.WriteLine("Произведение двух матриц");
Array(firstArray, secondArray, resultArray);
PrintDoubleArray(resultArray);



void FillArrayRandomNumber(int[,] array, int min = 1, int max = 10)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max+ 1);
        }
    }
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Array(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
}
}
Ex58();