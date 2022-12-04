// Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n

Console.Clear();

int m = GetNumber("Input m (m >= 0): ");
int n = GetNumber("Input n (n >= 0): ");
System.Console.WriteLine($"Ackermann Function from ({m}, {n}) is {AckermannFunction(m, n)}");

int GetNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = AckermannFunction(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}