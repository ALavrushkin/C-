// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a;
int b;
int c;
string? s= Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
if(a>b)
{
    if(a>c)
    {
        System.Console.WriteLine("Максимальное число a");
    }
    else
    System.Console.WriteLine("Максимальное число c");
}
else
{
    if(b>c)
    {
        System.Console.WriteLine("Максимальное число b");
    }
    else
    System.Console.WriteLine("Максимальное число c");
}