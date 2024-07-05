// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int arraySize = 10;
    int[] array = new int[arraySize];

    FillArrayWithRecursive(array, arraySize, new Random());

    Console.WriteLine("Generated array:");
    PrintArray(array);

    Console.WriteLine("Array in reverse order:");
    PrintArrayReverse(array, array.Length - 1);
}

void FillArrayWithRecursive(int[] array, int size, Random rand, int index = 0)
{
    if (index >= size)
        return;

    array[index] = rand.Next(1, 101);
    FillArrayWithRecursive(array, size, rand, index + 1);
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
        return;

    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);
}
Main();