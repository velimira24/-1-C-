int InputNumber2()
 {
 int num1;
string text;

while(true)
{
    Console.Write("Введите число:");
     text = Console.ReadLine();
    if(int.TryParse(text,out num1))
   {
        break;
   }
   System.Console.WriteLine("Не удалось распознать число.Попробуйте еще раз))");
 }
return num1;
 }