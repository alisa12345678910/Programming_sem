// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите a ");
// int a=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите b ");
// int b=Convert.ToInt32 ( Console.ReadLine());
// if (a > b) Console.WriteLine($"Число {a} больше числа {b}");
// else Console.WriteLine ($"Число {b} больше числа {a}");

// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите a ");
// int a=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите b ");
// int b=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите c ");
// int c=Convert.ToInt32 ( Console.ReadLine());
// int max = Math.Max(a, Math.Max(b, c));
// Console.WriteLine($"Число {max} максимальное");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число ");
// int a=Convert.ToInt32 ( Console.ReadLine());
// if (a % 2 == 0) Console.WriteLine($"Число {a} четное ");
// else Console.WriteLine ($"Число {a} нечетное ");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// int count = 1;
// while (count <= x)
// {
//     if (count % 2 == 0) 
//     {
//         Console.Write(count+" ");
//         count = count +1;
//     }
//     else
//     {
//        count = count +1; 
//     }
// }



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число ");
int x=Convert.ToInt32 ( Console.ReadLine());
x.
Console.WriteLine("Второе число равно {x}")