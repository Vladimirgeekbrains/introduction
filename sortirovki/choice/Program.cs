//Сортировка выбором О(n^2)


int[] SortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if (array[indexMin] == array[i])
            continue;
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }

    return array;
}


void Input(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-30, 31); //[-30; 31)    [-30; 30]
    }

}

Console.Write("Ввведите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Input(arr);
Console.WriteLine($"Начальный массив: [{string.Join(", ", arr)}] ");
Console.WriteLine($"Конечный массив: [{ string.Join(", ", SortVibor(arr)) }] ");