//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] chr = {
    {'a', 'b', 'c'},
    {'a', 'b', 'c'},
    {'a', 'b', 'c'},
    };

string str = "";
// Другой способ задания пустой строки
//string str1 = string.Empty; 


for (int i = 0; i < chr.GetLength(0); i++)
{
    for (int j = 0; j < chr.GetLength(1); j++)
    {
        str += chr[i,j];
    }
}
Console.WriteLine(str);