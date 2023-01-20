// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// 2,3,7 -> max=7

Console.WriteLine("Введите целое число > ");
string? value1 = Console.ReadLine();
int a = Convert.ToInt32(value1);

Console.WriteLine("Введите целое число > ");
string? value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);

Console.WriteLine("Введите целое число > ");
string? value3 = Console.ReadLine();
int c = Convert.ToInt32(value3);

int max = a;
if (max < b)
{
    Console.WriteLine($"Максимальное число {b}");
}
if (max < c)
{
    Console.WriteLine($"Максимальное число {c}");
}