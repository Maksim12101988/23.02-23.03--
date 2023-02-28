// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int a, b;
Console.WriteLine("Введите два числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число " + a + " больше чем второе " + b);
}
else
{
    Console.WriteLine("Второе число " + b + " больше чем первое " + a);
}
Console.ReadLine();