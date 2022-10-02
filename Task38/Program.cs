// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRnd(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 2, MidpointRounding.ToZero);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}. ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double FindMax(double[] array, double max)
{
    max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double FindMin(double[] array, double min)
{
    min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double[] arr = CreateArrayRnd(5, 1, 10);
PrintArray(arr);
double max = FindMax(arr, arr[0]);
double min = FindMin(arr, arr[0]);
Console.WriteLine($"Разница между {max} и {min} = {max - min} ");
