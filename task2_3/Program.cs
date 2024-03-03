Console.WriteLine("Введите целое двузначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10 || num > 99) Console.WriteLine("Некорректный ввод!");
else
{
    int FirstDigit = num / 10;
    int LastDigit = num % 10;
    //Было замечено, что первое число может быть нулём
    if (FirstDigit > LastDigit) Console.WriteLine("Первая цифра больше");
    else if (FirstDigit < LastDigit) Console.WriteLine("Последняя цифра больше");
    else Console.WriteLine("Цифры одинаковы");
}
