// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);
double min = numbers[0];
double max = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < min) min = numbers[i];
    else if (numbers[i] > max) max = numbers[i];
}
Console.Write(max - min);
void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1000)/10.0);
    }
}
void WriteArray(double[] array)
{
    for (int index = 0; index < array.Length; index++)
        continue;
    Console.Write("[" + String.Join(", ", array) + "] -> ");
}