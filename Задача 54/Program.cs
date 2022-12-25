// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArrayRandomNumbers(int[,] array)
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
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void SorttoLawer(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        int minPosition = j;
        for (int m = j+1; m < array.GetLength(1); m++)
        {
            if (array[i,m]< array[i,minPosition])
           minPosition = m;
            { 
               
        
            }
            
        }
         int temp = array[i,j];
        array[i,j] = array[i,minPosition];
        array[i,minPosition] = temp;
    }
        
    }
}

int[,]arr = new int[3,4];
FillArrayRandomNumbers(arr);
PrintArray(arr);
SorttoLawer(arr);
Console.WriteLine("Массив в порядке убывания: ");
PrintArray(arr);



