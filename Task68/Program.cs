// Задача 68: Напишите программу вычисления функции Аккермана (Ackermann)
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Следующая частично итерационная реализация (из Википедии):
// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1
// -----------------------------
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
// ------------------------------

// Ackermann(n, m);

// while (n > 0);
// {
//     if (m = 0);
//     n = 1;
//     else if (m = Ackermann (n, m - 1));
//     n = m - 1;
// }
// return (m + 1);
// -----------------------------------
System.Console.WriteLine("Input natural number m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input natural number n: ");
int n = Convert.ToInt32(Console.ReadLine());

AckermannFunction(m, n);

int AckermannFunction(int m, int n)
{
    if (n == 0)
    {
       return (m + 1);
    }
    
    else if (m == 0 && n != 0)
    {
        return AckermannFunction(n - 1, 1);
    }

    else
    {
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    }

    Console.WriteLine($"{AckermannFunction(m, n)}");
}



// int result = FunctionAckermann(m, n);
// System.Console.WriteLine($" {result}");  

// int A = Convert.ToInt32(Console.ReadLine());

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
// ------------------------------------------------------
// int AkkermanFunc(int m, int n)
// 		{
// 			if(m == 0)
// 			{
// 				return n + 1;
// 			}
// 			if(m > 0 && n == 0)
// 			{
// 				return AkkermanFunc(m - 1, 1);
// 			}
// 			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// 		}
		
// 		Console.WriteLine(AkkermanFunc(3,2));
// 	}
// }
// ------------------------
// Реализация функции следующая:
// функция Аккермана
// static uint A(uint n, uint m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return A(n - 1, 1);
//     else
//       return A(n - 1, A(n, m - 1));
// }
// // Использование функции для малых значений n, m:
// uint res;
// res = A(1, 2); // res = 4
// res = A(0, 1); // res = 2
// res = A(0, 0); // res = 1
// res = A(2, 2); // res = 7