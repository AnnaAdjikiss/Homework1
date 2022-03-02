/* Задача 4: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
Пример:     5 -> 2, 4;      8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите целое положительное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int n = 2;
while (n <= value)
{
    Console.Write (n + " ");
    n = n + 2;
}
