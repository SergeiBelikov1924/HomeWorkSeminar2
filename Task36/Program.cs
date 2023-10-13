// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

ArrayRandomNumbers(numbers);
Console.Write("[ ");
PrintArray(numbers);
Console.WriteLine("]");

int SumNumbersNotEvenIndex = 0;
for (int i = 1; i < numbers.Length; i += 2)
{
    SumNumbersNotEvenIndex += numbers [i];
}

Console.WriteLine($"Сумма элементов на нечётных позициях: {SumNumbersNotEvenIndex}");

void ArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}