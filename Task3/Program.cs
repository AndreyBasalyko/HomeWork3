Console.WriteLine("Введите число...");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
void Method(int count)
{
    while (count >= x)
    {
       int y = 3;
       double s = Math.Pow( x, y);
       Console.WriteLine(s);
       x++; 
    }
}
Method(n);