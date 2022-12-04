// Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// Выполнить с помощью рекурсии

Console.Clear();

int N = GetNumber("Input N: ");
int E = 1;
System.Console.WriteLine(PrintNumber(N, E));

int GetNumber(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

string PrintNumber(int start, int end)
{
    if (start == end) return $"{start}";
    if (start > end) return $"{start}, " + PrintNumber(start - 1, end);
    return ($"{start}, " + PrintNumber(start + 1, end));
}