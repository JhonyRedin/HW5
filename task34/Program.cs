// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillRandMassive(int size, int lRange, int rRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(lRange, rRange);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("Массив: [" + string.Join(",", arr) + "]");
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = FillRandMassive(10, 100, 1000);
PrintArray(array);
System.Console.WriteLine("Кол-во чётных элементов:" + CountEvenNumbers(array));