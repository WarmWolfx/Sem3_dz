// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 2.2, 0.4, 9.11, 7.2, 78.98 };
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " | ");
}
double min = Int32.MaxValue;
double max = Int32.MinValue;
Console.WriteLine();

for (int a = 0; a < array.Length; a++)
{
    if (array[a] > max)
    {
        max = array[a];
    }
    if (array[a] < min)
    {
        min = array[a];
    }
}
double result = max - min;
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Разница между минимальным и максимальным значением = {result}");
