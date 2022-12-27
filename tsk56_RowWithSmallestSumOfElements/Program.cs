// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = FillArray();
PrintArray(matrix);

int minSumLineElements = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLineElements = i;
  }
}

Console.WriteLine($"{minSumLineElements+1} - the row with the smallest sum ({sumLine}) of elements");

// Методы
int[,] FillArray() // Метод заполнения двумерного массива случайными числами
{
    int rows = new Random().Next(1,5);
    int colomns = rows;
    int[,] matrix = new int[rows,colomns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }        
    }
    return matrix;
}

void PrintArray(int[,] matrix) // Метод печати двумерного массива
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumLineElements(int[,] array, int i) // Метод подсчета элементов строки
{
  int sumLine = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}