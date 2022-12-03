Console.WriteLine("Введите число: ");
int num = int.Parse (Console.ReadLine());
string chr = Convert.ToString(num);
if (num > 99)
{
   System.Console.WriteLine(chr[2]); 
}
else
{ System.Console.WriteLine("третьей цифры нет");
}