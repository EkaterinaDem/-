﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using static System.Console;

Clear();
int [] array = GetArray(4, 100, 1000);
WriteLine($"[{String.Join(",", array)}]");
int CountOfEven = findEven(array);
WriteLine ($"Количество четных элементов массива = {CountOfEven}");

int [] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i=0; i<size;i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int findEven (int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    if (array[i]%2==0)
    {
        count+=1;
    }
    return count;
}