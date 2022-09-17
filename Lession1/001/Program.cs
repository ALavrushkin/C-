// Test
/*
Console.WriteLine("Hello, World!");
System.Console.WriteLine(11%3);

int MaxFromToNumbers=0;
double d=3.14;
System.Console.WriteLine(int.MaxValue);
System.Console.WriteLine(double.MaxValue);
string s="Hello"+"world";
char c='a';
*/


double a;
double b;
string s = Console.ReadLine(); // ввод данных
double a = Convert.ToDouble(s);

b = a * a; // обработка данных

  // вывод данных
System.Console.WriteLine("{0}^2={1}", a, b); // строка форматирования
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции


/*
string? s; // объявили переменную
s=Console.ReadLine(); // присвоили значение
System.Console.WriteLine(s);
*/