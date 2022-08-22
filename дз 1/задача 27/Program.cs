/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


using static System.Console;

Clear();
Write("ВВедите число: ");
int a = Convert.ToInt32(ReadLine());
int sum = SumOfNumbers(a);
WriteLine($"Сумма цифр числа = {sum}");


int SumOfNumbers(int a)
{
    int counter = Convert.ToString(a).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = a - a % 10;
      result = result + (a - advance);
      a = a / 10;
    }   
    return result;
}
