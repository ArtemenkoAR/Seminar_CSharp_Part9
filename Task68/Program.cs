// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


Console.WriteLine("m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine()!);

int Ack(int a, int b)
{
  if (a == 0) return b + 1;
  else if (a>0 && b == 0) return Ack(a - 1, 1);
  else return Ack(a - 1, Ack(a, b - 1));
}

Console.WriteLine($"A(m,n) = {Ack(m,n)} ");