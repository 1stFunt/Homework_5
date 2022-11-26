// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers, 100, 999);
WriteArray(numbers);
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) continue;
        count++;
    }
    Console.Write(count);
}
Count(numbers);
void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}
void WriteArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        continue;
    Console.Write("[" + String.Join(", ", numbers) + "] -> ");
}