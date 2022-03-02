/* Задача 2: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. Пример: 44 5 78 -> 78 */

Console.WriteLine("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = value1;

if (value1 > max) max = value1;
if (value2 > max) max = value2;
if (value3 > max) max = value3;

Console.Write("Max = ");
Console.WriteLine(max); 