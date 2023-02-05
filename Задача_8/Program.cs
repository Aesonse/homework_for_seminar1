// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int n = 2;
while (n < N) 
{
    Console.Write($"{n}, ");
    n += 2;
}
Console.WriteLine(n + ".");