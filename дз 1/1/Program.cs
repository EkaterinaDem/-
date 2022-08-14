using static System.Console;

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

WriteLine("ВВедите первое число ");
int numberA = Convert.ToInt32(ReadLine());
WriteLine("ВВедите второе число ");
int numberB = Convert.ToInt32(ReadLine());
if (numberA > numberB)
{
    WriteLine($"{numberA} больше {numberB}");
}
else {
    WriteLine("Второе число больше первого");
}