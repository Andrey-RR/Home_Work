// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите числа");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberB > max)
{
    max = numberB;
    min = numberA;
}
else
{
    min = numberB;
    max = numberA;
}
Console.Write("большее число ");
Console.WriteLine(max);
Console.Write("меньшее число ");
Console.WriteLine(min);