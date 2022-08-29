/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

using static System.Console;
using System.Linq;

Clear();


WriteLine("ВВедите M чисел: ");
int[] array = new int[m];

int count = 0;
for (int i=0; i<array.Length; i++)
{
    array[i] = int.Parse(ReadLine());
}

if (i>0)
{
    count = count+1;
}

WriteLine($"Количество положительных элементов: {count}");
