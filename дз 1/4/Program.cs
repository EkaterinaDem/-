using static System.Console;

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Clear();
Write("ВВедите число: ");
int N = Convert.ToInt32(ReadLine());
int a = 1;
while (a <=N)
{
    if (a%2 == 0)
    {
    WriteLine($"{a}");
    }
    a++;
}

