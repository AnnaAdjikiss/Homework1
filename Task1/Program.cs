/* Задача 1: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее. Пример: a = 5; b = 7 -> max = 7 */

Console.WriteLine("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 == value2)
{
 Console.WriteLine("Введенные числа равны");   
}
else
{
    if (value1 > value2)
    {
    Console.WriteLine("Первое число является большим, второе - меньшим");  
    }
    else 
    {
    Console.WriteLine("Второе число является большим, первое - меньшим");   
    }
}