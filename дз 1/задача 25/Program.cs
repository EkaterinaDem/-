/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
using static System.Console;

Clear();
Write("ВВедите число: ");
int a = Convert.ToInt32(ReadLine());
Write("ВВедите степень: ");
int b = Convert.ToInt32(ReadLine());
int stepen = GetStepen(a, b);
Write($"{a} в степени {b} = {stepen}");


int GetStepen(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}

