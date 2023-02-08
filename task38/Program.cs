// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] FillRandMassive(int size, int lRange, int rRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(lRange, rRange) + rand.NextDouble(), 3);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("Массив: [" + string.Join(" | ", arr) + "]");
}

void MinAndMaxElementFounder(double[] arr, out double max, out double min)
{
    min = arr [1];
    max = arr [1];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
}


double[] array = FillRandMassive(10, 1, 50);
PrintArray(array);
MinAndMaxElementFounder(array, out double max, out double min);
Console.WriteLine($"max= {max},  min = {min}");
double diff = max - min;
Console.WriteLine("Разница между max и min элементами массива = " + diff);
