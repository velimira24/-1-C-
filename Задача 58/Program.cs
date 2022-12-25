void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк в массивах: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массивах: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
int[,] array2 = new int[n,m];
int[,] resultArray = new int[n, m];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();

FillArrayRandom(array2);
PrintArray(array2);

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * array2[k, j];
        }
    }
}

PrintArray(resultArray);