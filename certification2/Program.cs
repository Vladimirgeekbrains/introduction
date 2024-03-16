// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Asc(int n, int m)
{
    if (n < 0 || m < 0) return -1;
    if (n == 0) return m + 1;
    else if (m == 0) return Asc(n - 1, 1);
    return Asc(n - 1, Asc(n, m - 1));
}


Console.WriteLine("Введите неотрицательное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число M:");
int m = Convert.ToInt32(Console.ReadLine());
int asc = Asc(n, m);
if (asc < 0) Console.WriteLine("Ошибка, отрицательные числа!");
else  Console.Write(asc);
