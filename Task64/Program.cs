// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// четные числа в промежутке от M до N.
// M = 1; N = 5. -> "2,4"
// M = 4; N = 8. -> "4, 6, 8"

Console.WriteLine("M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("N");
int N = int.Parse(Console.ReadLine()!);

string Rec(int a, int b)
{
    while(a%2!=0) a++;
    if (a%2==0 && a<=b) return $"{a} "+ Rec(a+1, b);
    else return String.Empty;
}
Console.WriteLine(Natural(M,N));
Console.WriteLine(Rec(M,N));