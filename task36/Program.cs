// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfOddIndexNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int SumOfOddIndexNumbersForEach(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] array = FillRandMassive(10,1,50);
PrintArray(array);
System.Console.WriteLine("Метод перебора с шагом 2. Sum =" + SumOfOddIndexNumbers(array));
System.Console.WriteLine("Метод перебора всех эллементов.  Sum =" + SumOfOddIndexNumbersForEach(array));