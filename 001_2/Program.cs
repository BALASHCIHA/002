// Задача 2.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.Write("Введите число:");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число:");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();
// Console.Write("Введите число:");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число:");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число:");
// int n3 = Convert.ToInt32(Console.ReadLine());
// int max = n1;
// if (n2 > max)
//     max = n2;
// if (n3 > max)
//     max = n3;
// Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear();
// Console.Write("Введите число:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// if (x1 % 2 == 0)
//    Console.WriteLine("yes");
// else
//    Console.WriteLine("no");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Clear();
Console.Write("Введите число:");
int x1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < x1; i++)
if (x1 % 2 == 0)
   Console.WriteLine("yes");
else
   Console.WriteLine("no");
   

