// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int i = 1;
int N = 5;
Console.WriteLine("Введите число:");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}
    Console.WriteLine();
