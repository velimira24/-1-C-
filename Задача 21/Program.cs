int[]point = new int[6];
Console.WriteLine ("Введите X1: ");
point[0]=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите Y1: ");
point[1]=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите Z1: ");
point[2]=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите X2: ");
point[3]=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите Y2: ");
point[4]=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите Z2: ");
point[5]=int.Parse(Console.ReadLine());

Console.WriteLine(MathF.Sqrt((float)(Math.Pow(point[3] - point[0],2) + Math.Pow(point[4] - point[1],2) + Math.Pow(point[5] - point[2],2))));
