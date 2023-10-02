// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int LeviAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return LeviAckerman(m - 1, 1);
    }
    else
    {
        return LeviAckerman(m - 1, LeviAckerman(m, n - 1));
    }
}

int m = 3;
int n = 2;
Console.WriteLine($"A({m},{n}) = {LeviAckerman(m,n)}");