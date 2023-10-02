// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Nto1(int nam)
{
    if(nam == 0)
    {
        return;
    }
    Console.Write($"{nam}, ");
    nam = nam -1;
    Nto1(nam);
}

int nam = GetNumber("");

Nto1(nam);

