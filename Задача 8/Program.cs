Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int rest =0;
while (rest<num1-1)
{

    rest = rest + 2;
Console.Write(rest);
Console.Write(',');
}