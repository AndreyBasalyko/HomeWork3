Console.WriteLine("Введите число...");
int number = Convert.ToInt32(Console.ReadLine());
int x = 100;
int y = 1000;
int fp = number / x;
int sp = number % y;
string d = Convert.ToString(sp);
char[] r = d.ToCharArray();
Array.Reverse(r);
string s = new String(r);
int a = Convert.ToInt32(s);
if (a == fp)
{
    Console.Write(number);
    Console.WriteLine(" -> Да");
}
else
{ 
   Console.Write(number);
   Console.WriteLine(" -> Нет");
}