using static System.Console;

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

WriteLine("ВВедите первое число ");
int numberA = Convert.ToInt32(ReadLine());
WriteLine("ВВедите второе число ");
int numberB = Convert.ToInt32(ReadLine());
WriteLine("ВВедите третье число ");
int numberC = Convert.ToInt32(ReadLine());

if (numberA > numberB && numberA > numberC)
{
WriteLine($"Среди чисел {numberA}, {numberB}, {numberC} наибольшее {numberA}");
}
if (numberB > numberA && numberB > numberC)
{WriteLine($"Среди чисел {numberA}, {numberB}, {numberC} наибольшее {numberB}");}
if (numberC > numberB && numberC > numberA) 
{
WriteLine($"Среди чисел {numberA}, {numberB}, {numberC} наибольшее {numberC}");
}

