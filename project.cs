Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double Y1= Auto(k1,b1);
double Y2= Auto(k2,b2);

double Auto(double k, double b)
{
double y = k * x + b;
return y;
}


Console.WriteLine($"две прямые пересекутся в точке с координатами {Y1}, {Y2}");