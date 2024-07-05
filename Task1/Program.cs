// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void Main()

{
    int M = 5;
    int N = 10;

    PrintNumbers(M, N);
}

void PrintNumbers(int M, int N)
{
    if (M > N)
        return;

    Console.WriteLine(M);
    PrintNumbers(M + 1, N);
}

Main();