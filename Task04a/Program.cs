// Задача 4:
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int nA;
int nB;
int nC;
Console.WriteLine("Введите первое число: ",nA);
nA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ",nB);
nB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ",nC);
nC = Convert.ToInt32(Console.ReadLine());

if ((nA>nB) && (nA>nC))
{
    Console.WriteLine("Наибольшее число:",nA);
}
else if ((nB>nA) && (nB>nC))
{
    Console.WriteLine("Наибольшее число:",nB);
}
else if (((nC>nA) && (nC>nB)));
{
    Console.WriteLine("Наибольшее число:",nC);
}