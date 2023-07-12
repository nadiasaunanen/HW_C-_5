// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * 1000;
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
double result = max - min;
Console.WriteLine($"Максимальное значение массива {max}, Минимальное значение массива {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");






