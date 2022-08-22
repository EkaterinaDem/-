/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using static System.Console;

Clear();
WriteLine("ВВедите 8 чисел: ");
int[] array = new int[8];


for (int i=0; i<array.Length; i++)
{
    array[i] = int.Parse(ReadLine());
}
WriteLine($"[{String.Join(",", array)}]");