// Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.WriteLine("Некорректный ввод");
else
{
    int a = num;
    int count = 0;
    while (a > 9)
    {
        a /= 10;
        count++;
    }
    Console.Write($"{num} => {a}");

    int result = 1;
    a = num;
    for (int k = count; k > 0; k--)
    {
        result = 1;
        for (int i = 0; i < k; i++) result *= 10;

        a %= result;
        while (a > 9) a /= 10;

        Console.Write($",{a}");
        a = num;
    }
}
// Вывод проще, но в обратном порядке
// if (num< 10)
// {
//     Console.WriteLine(num);
// }
// else
// {
//     while(num>0)
//     {
//         int digit = num %10;
//         num /= 10;
//         if (num > 0)
//         {
//             Console.Write(digit + ",");
//         }
//         else
//         {
//             Console.WriteLine(digit);
//         }

//     }
// }