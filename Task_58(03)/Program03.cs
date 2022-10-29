// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] HaveSize()
{
    Console.WriteLine("\nУмножение двух матриц");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк и столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, m];
    return arr;
}

void FillingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void TypeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplicArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
}

int[,] massiv1 = HaveSize();
int[,] massiv2 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];
int[,] massiv3 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];

FillingArray(massiv1);
FillingArray(massiv2);
TypeArray(massiv1);
TypeArray(massiv2);
MultiplicArray(massiv1,massiv2,massiv3);
TypeArray(massiv3);    
