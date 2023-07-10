// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4 
//8 -> 2, 4, 6, 8

Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());

int firsteven = 2;               // решил определить первое чётное как начальное

if (N < 2) 

{
Console.Write("нет чисел");
}

else
{
     while (firsteven < N+1)
     

    {
    Console.Write(firsteven + " ");
    firsteven = firsteven + 2;
    }
}