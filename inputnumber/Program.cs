Ввод числа:

int InputNumber(string text)
 {
 int num1;

while(true)
{
    Console.Write(text);
     text = Console.ReadLine();
    if(int.TryParse(text,out num1))
   {
        break;
   }
   System.Console.WriteLine("Не удалось распознать число.Попробуйте еще раз))");
 }
return num1;
 }

Заполнение массива случайными числами:
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(leftRange,rightRange+1);
    
}


return array;
}

Напечатать массив:
void PrintArray (int[]array)
  {
    Console.WriteLine("[" + string.Join (", ", array) + "]");
  }

Пример рекурсии:
void func(int num)
 {
    if (num / 2!= 0)
    func(num/2);
    System.Console.Write(num%2);}

Копируем массив:

int[] array_copy = arr[];

int[] array_copy = arr[];//копируем массив как бы по ссылке, то есть, если вначале скопировать массив, а потом что-то в нем изменить, то изменятся числа в скопированном до этого массиве


Создать двумерный массив:

void FillArrayRandomNumbers2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Напечатать двумерный массив:
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
