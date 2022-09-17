// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a;
int b;
string? s= Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(a>b)
{
    System.Console.WriteLine("а является максимальным числом");
}
else
{
    if(b>a)
    {
        System.Console.WriteLine("b является максимальным числом");
    }
    else System.Console.WriteLine("числа равны друг другу");
}