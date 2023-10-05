// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumbers (int num);
// {
//     int sum = 0;

//     for (int i = 1; i <= num; i++)
//     {
//         checked
//         {
//             sum += i; // sum = sum + i
//         }
//     }

//     return sum;
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("n = ");
//         var n = Convert.ToInt32(Console.ReadLine());
//         var sum = 0;
//         while(n > 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         Console.WriteLine(sum);
//     }
// }

Console.WriteLine("Введите целое положительное число:");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num = 1;

while (i > 0)
    {
        num = i % 10;
        i = i/10;
        sum = sum + num;
    }

Console.WriteLine($"Сумма всех цифр в числе равна: " + sum);
