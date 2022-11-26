// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers, -99, 99);
WriteArray(numbers);
int summ = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0) summ = summ + numbers[i];
}
Console.Write(summ);
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
    Console.Write("[" + String.Join(", ", array) + "] -> ");
}