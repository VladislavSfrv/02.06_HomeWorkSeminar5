// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[size + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max-min) + min;
        arr[i] = Math.Round(num, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
}

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
        if(arr[i]<min) min = arr[i];
    }
    diff = max - min;
    return diff;
}

double[] array = CreateRandomArray(10, 5, 10);
PrintArray(array);
double result = Math.Round(Difference(array), 2);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом равна - {result}");