// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumbers(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    Console.Write($"{m}, ");
    return PrintNumbers(m + 1, n);
}

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");


Console.WriteLine(PrintNumbers(m, n));

if (m > n)
{
    Console.WriteLine("Введены некорректные цифры: ");
}