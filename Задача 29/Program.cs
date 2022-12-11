int[] arr = Auto();

System.Console.WriteLine(string.Join(" | ", arr));

int[] Auto()
{
int[] arr = new int[8];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,100);
}
return arr;
}
