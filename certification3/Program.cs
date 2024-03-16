// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void CreateArray(int[] arr, int size, int min, int max)
{
    if (size == 0) return;
    Random rnd = new Random();
    arr[size - 1] = rnd.Next(min, max);
    CreateArray(arr, size - 1, min, max);
    return;
}
void ShowReversedArray(int[] arr, int size)
{
    if (size == 0) return;
    Console.Write($"{arr[size - 1]} ");
    ShowReversedArray(arr, size - 1);
    return;
}
void ShowArray(int[] arr, int size)
{
    if (size == 0) return;
    ShowArray(arr, size - 1);
    Console.Write($"{arr[size - 1]} ");
    return;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int min = -100;
int max = 100;


if (size < 1) Console.WriteLine("Размер массива меньше одного");
else
{
    int[] arr = new int[size];
    CreateArray(arr, size, min, max);
    Console.Write("[");
    ShowArray(arr, size);
    Console.Write("] -> ");
    ShowReversedArray(arr, size);
}

