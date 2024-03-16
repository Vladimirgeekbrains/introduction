// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void ShowNumberInterval(int m, int n)
{
    Console.Write($"{m} ");
    if (m > n) m--;
    else if (n > m) m++;
    else return;
    ShowNumberInterval(m, n);
    return;
}

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumberInterval(m, n);