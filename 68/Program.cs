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

int AckermannFunction(int start, int end)
{
    while (start != 0)
    {
        if (end == 0) end = 1;
        else end = AckermannFunction(start, end - 1);
        start = start - 1;
    }
    return end + 1;
}