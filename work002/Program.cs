// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumFromMtoN(int M, int N)
{
    int Sum = 0;
    for (int i = M; i <= N; i++)
    {
        Sum = Sum + i;
    }
    return Sum;
}

int M = GetNumber("M");
int N = GetNumber("N");

int Sum = SumFromMtoN(M,N);
Console.WriteLine(Sum);


