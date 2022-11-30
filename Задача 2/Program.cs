Console. WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console. WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1; 
int min =num2;
if (num2>max) max =num2;min =num1;
Console. Write ("max = ");
Console.WriteLine(max);
Console.Write ("min = ");
Console.WriteLine(min);
