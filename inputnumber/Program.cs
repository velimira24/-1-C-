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

void PrintArray (int[]array)
                  {
                   Console.WriteLine("[" + string.Join (", ", array) + "]");
                  }
