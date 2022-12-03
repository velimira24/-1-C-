Console.WriteLine("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());
if (num > 999 || num < 100)
{
    Console.WriteLine("Это число не трехзначное");
}
else
{
    Console.WriteLine((num / 10)% 10);
}