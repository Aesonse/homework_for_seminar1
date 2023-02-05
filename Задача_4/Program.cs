//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a == b & b == c)
{
    Console.Write("Данные числа равны");
}
else if (a > b & a > c)
{
    Console.Write($"Большее число: {a}");
}
else if (b > c)
{
    Console.Write($"Большее число: {b}");
}
else
{
    Console.Write($"Большее число: {c}");
}
