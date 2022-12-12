Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(n > 0)
{
    result = result + n % 10;
    n = n / 10;

}
System.Console.WriteLine($"Сумма цифр в веденном числе = {result}");