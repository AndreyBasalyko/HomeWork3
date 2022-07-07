Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z1 = Convert.ToInt32(Console.ReadLine());
void distance( double a, double b, double c, double a1, double b1, double c1)
{
double d = Math.Sqrt(Math.Pow((a1 - a), 2) + Math.Pow((b1 - b), 2) + Math.Pow((c1 - c), 2));
Console.WriteLine(d);
}
distance(x, y, z, x1, y1, z1);