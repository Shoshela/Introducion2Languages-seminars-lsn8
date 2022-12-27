// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = FillArray();
PrintArray(matrix);
SortInAscendingOrder(matrix);
Console.WriteLine();
PrintArray(matrix);

// Методы
int[,] FillArray() // Метод заполнения двумерного массива случайными числами
{
    int r = new Random().Next(1,5);
    int c = new Random().Next(1,5);
    int[,] matrix = new int[r,c];
    for(int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
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

void SortInAscendingOrder(int[,] matrix) // Метод упорядочивания элементов двумерного массива по убыванию
{
    for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                // int maxPosition = i;
                for (int k=0; k<matrix.GetLength(1)-1; k++)
                {
                    if (matrix[i,k]<matrix[i,k+1])
                    {
                        int temporary = matrix[i,k+1];
                        matrix[i,k+1] = matrix[i,k];
                        matrix[i,k] = temporary;;
                    }
                }
            }
        }
}