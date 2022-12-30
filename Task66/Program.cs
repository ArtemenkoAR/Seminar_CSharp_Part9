// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("N");
int N = int.Parse(Console.ReadLine()!);

int Rec(int a, int b)
{
    while(a<1) a++;
    if (a<=b) return a+ Rec(a+1, b);
    else return 0;
}
Console.WriteLine(Rec(M,N));
