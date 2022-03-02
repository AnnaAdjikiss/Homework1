/* Задача 3: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:     4 -> да;     -3 -> нет;      7 -> нет)*/

Console.WriteLine("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());

int ostatok = value % 2;
if (ostatok == 0)
{
    Console.WriteLine("Число " + value + " четное");
}
else
{
    Console.WriteLine("Число " + value + " нечетное");
}