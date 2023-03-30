//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("input any number");
int number = Convert.ToInt32(Console.ReadLine());

void printnumbers(int n)
{
    if (n<=0) return;
    else
    {
        Console.Write(n+" ");
        printnumbers(n-1);
    }
}
printnumbers(number);
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
Console.WriteLine("input starting point(M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input ending point(N)");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfElements(int m, int n)
{
    int sum = 0;
    if (m > n) return 0;
    else
    {
        sum = m + SumOfElements(m + 1, n);
    }
    return sum;
}
int result = SumOfElements(m, n);
Console.WriteLine($"Result is {result}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3->A(m, n) = 9

Console.WriteLine("input X(please dont input too huge number)");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y(please dont input too huge number)");
int y = Convert.ToInt32(Console.ReadLine());

int AcermanFunction(int m, int n)
{
    if (m<0 || n<0) return 0;
    else if(m == 0)
    {
        return n + 1;
    }
    else if(m>0 && n == 0)
    {
        return AcermanFunction(m-1, 1);
    }
    else
    {
        return AcermanFunction(m-1, AcermanFunction(m, n-1));
    }
}
int Acerman = AcermanFunction(x, y);
Console.WriteLine($"A({x}, {y} = {Acerman})");
