Console.WriteLine("Введите пятизначное число");
string n = Console.ReadLine();
int len = n.Length;

if (len == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine(" Не палиндром");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}
