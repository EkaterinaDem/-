/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

using static System.Console;
Clear();

int[] array = GetArray(10, -99, 99);
WriteLine($"[{String.Join(",", array)}]");
int SumOfUnevenIndex = sum(array);
WriteLine($"Сумма элементов нечетных позиций массива = {SumOfUnevenIndex}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

