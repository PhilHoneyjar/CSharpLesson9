// Задайте значения M и N
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.Clear();

int M = GetNumber("Input M: ");
int N = GetNumber("Input N: ");
int temp = M;
if (M > N)
{
    M = N;
    N = temp;
}
System.Console.WriteLine($"Sum of integer elements from {M} to {N} is {SumNumber(M, N)}");

int GetNumber(string message) 
{
  System.Console.Write(message);
  return System.Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int start, int end)
{
    if (start == end) return start;
    return end + SumNumber(start, end - 1);
}