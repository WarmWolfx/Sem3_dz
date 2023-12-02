// Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество чётных чисел в массиве.

int[] array = { 6, 7, 19, 34, 3, 1, 4, 7, 9, 1 };
Console.WriteLine("Массив: ");
PrintArray(array);
int count = 0;
for (int a = 0; a < array.Length; a++)
    if (array[a] % 2 == 0)
        count++;
Console.WriteLine($"Чётных чисел: {count}");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
    Console.WriteLine();
}
