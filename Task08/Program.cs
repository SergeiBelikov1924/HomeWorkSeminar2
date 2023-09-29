// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 

int n, b;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
b = 0;
while (n>b)
{
    b=b+1;
    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }    
}
