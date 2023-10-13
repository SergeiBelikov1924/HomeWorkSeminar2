// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите размер массива:");

double[] CreateArreyRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //double nRound = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}
