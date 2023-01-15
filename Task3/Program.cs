// Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится
// ли оно на 2 без остатка)
// 4-> да 
// -3 -> нет

Console.WriteLine("Ведите целое число > ");
string? value = Console.ReadLine();
int a = Convert.ToInt32(value);
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} не явялется четным");
}