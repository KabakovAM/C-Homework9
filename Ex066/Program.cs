// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenNumbers(int m, int n)
{
    if (m == n)
        return m;
    return m + SumBetweenNumbers(m + 1, n);
}

Console.Write("Введите натуральное число: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write($"Введите натуральное число больше чем {numberM}: ");
int numberN = int.Parse(Console.ReadLine());
int result = SumBetweenNumbers(numberM, numberN);
Console.Write($"Cумма натуральных элементов в промежутке от {numberM} до {numberN} равна {result}");