﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Funk(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
       return Funk(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
       return Funk(M - 1, Funk(M, N - 1));
    }
    else return Funk(M, N);
}
Console.WriteLine(Funk(3, 2));