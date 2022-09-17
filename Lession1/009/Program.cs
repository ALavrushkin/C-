// Вывести на экран четные числа от 1 до N

int i=1;
int N=50;
while (i<=N)
{
    if(i%2==0)
    {
       System.Console.Write($"{i} ");
    }
    i=i+1;
}

// 2 вариант
/*
int i=2;
int N=20;
while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
*/