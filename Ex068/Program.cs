// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Console.Write("Введите натуральное число m: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write($"Введите натуральное число n: ");
int numberN = int.Parse(Console.ReadLine());
int result = Ackerman(numberM, numberN);
Console.Write($"Значение функции Аккермана равно: {result}");