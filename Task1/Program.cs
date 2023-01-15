// Напишите программу, которая на вход принимает два числа и выдает, какое число большее,
//  а какое меньшее
// a=5 b=7 -> max=7, min=5
// a=-9 b=-3 -> max=-3, min=-9

Console.WriteLine("Введите целое число > ");

string? value1 = Console.ReadLine();
int a = Convert.ToInt32(value1);

Console.WriteLine("Введите целое число > ");

string? value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);

if (a > b) 
{
    Console.WriteLine($"Число {a} является максимальным, число {b} является минимальным");
}

else
{
    Console.WriteLine($"Число {a} является минимальным, число {b} является максимальным");
}


