// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] HaveSize()
{
    Console.WriteLine("\nКоличество строк и столбцов не должно быть равным! ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк массива!: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива!: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, n];
    if (m == n) HaveSize();
    return arr;
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

void DetectSum(int[,] arr, int[,] arrSum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            if (j == arr.GetLength(1) - 1)
            {
                arrSum[i, 0] = sum;
            }
        }
    }
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

void TestLine(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (arr[i, 0] < min)
        {
            min = arr[i, 0];
        }
    }
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if (min == arr[j, 0])
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов {j + 1}");
        }
    }
}

int[,] massiv = HaveSize();
FillingArray(massiv);
TypeArray(massiv);  
int[,] sumMassiv = new int[massiv.GetLength(0), 1];
DetectSum(massiv, sumMassiv); 
TestLine(sumMassiv);
