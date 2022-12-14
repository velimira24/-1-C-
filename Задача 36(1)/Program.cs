int[] arr = Auto();

System.Console.WriteLine(string.Join(" | ", arr));

int[] Auto()
{
int[] arr = new int[4];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,100);
}
return arr;
}
int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];

    Console.WriteLine($"Сумма элементов cтоящих на нечётных позициях = {sum}");