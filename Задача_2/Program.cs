//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write($"Большее число {a}, Меньшее число {b}");
}
else if (b > a)
{
    Console.Write($"Большее число {b}; Меньшее число {a}");
}
else 
{
    Console.Write("Данные числа равны");
}