// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = new Random().Next(1,5);
int b = new Random().Next(1,5);
int c = new Random().Next(1,5);
int[,] matrix1 = FillArray(a,b);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = FillArray(b,c);
PrintArray(matrix2);
Console.WriteLine();
int[,] resultMatrix=new int[a,c];
ProductMatrix(matrix1,matrix2,resultMatrix);
PrintArray(resultMatrix);

// Методы
int[,] FillArray(int r, int c) // Метод заполнения двумерного массива случайными числами
{
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

int[,] ProductMatrix(int[,] array1, int[,] array2, int[,] resultMatrix) // Метод умножения матриц
{
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<c; j++)
        {
            int vectorProduct = 0;
            for (int k=0; k<matrix1.GetLength(1); k++)
            {
                vectorProduct = vectorProduct + array1[i,k]*array2[k,j];
            }
            resultMatrix[i,j]=vectorProduct;
        }
    }
    return resultMatrix;
}