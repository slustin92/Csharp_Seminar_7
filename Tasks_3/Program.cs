
// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать        [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
// рекурсию, не использовать циклы.

int[] array = { 1, 2, 5, 0, 10, 34 };
int arr = array.Length - 1;

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        Console.Write($"{array[i]} ");
        PrintArray(array, i + 1);
        
    }
}

void recursion(int x)
{
    int i = 0;
    int[] revArray = new int[6];
    if (x >= 0)
    {
        revArray[i] = array[x];
        Console.Write($"{revArray[i]} ");
        i++;
        x--;
    }

    else
    {
        return;
    }
    recursion(x);
}
PrintArray(array);
Console.WriteLine();
recursion(arr);