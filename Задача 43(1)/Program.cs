Console.WriteLine("Bведите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Заданные прямые пересекутся в точке с координатами X: {x}, Y: {y}");
