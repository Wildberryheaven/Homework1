// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение:

// Console.Clear();
// Console.Write("Введите первое число a: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число b: ");
// double b = Convert.ToDouble(Console.ReadLine());
// double max = a;
// if(a > b) {
//     Console.Write($"первое число a = {max} больше второго числа b = {b}");
// } else {
//     if(b > a) {
//         max = b;
//         Console.Write($"второе число b = {max} больше первого числа a = {a}");
//     } else 
//     Console.Write($"Числа одинаковые: a = b = {max}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:

// Console.Clear();
// Console.Write("Введите первое число a: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число b: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите третье число с: ");
// double c = Convert.ToDouble(Console.ReadLine());
// double max = a;
// if(a < b) {
//     max = b;
// }
// if(b < c) {
//     max = c;
// }
// Console.Write($"Максимальное из трёх введённых чисел = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Решение:

// Console.Clear();
// Console.Write("Введите любое целое число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0) {
//     Console.Write($"Число a = {a} является чётным");
// } else {
//     Console.Write($"Число a = {a} не является чётным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение:

// Console.Clear();
// Console.Write("Введите любое положительное целое число большее 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= a; i++) {
//     if(i % 2 == 0) {
//         Console.Write(i + " ");
//     }
// }