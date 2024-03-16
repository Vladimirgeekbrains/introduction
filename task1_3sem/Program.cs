//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] chr = {
    {'a', 'b', 'c'},
    {'a', 'b', 'c'},
    {'a', 'b', 'c'},
    };

string str = "";
// Другой способ задания пустой строки
//string str1 = string.Empty; 


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        str += chr[i,j];
    }
}
Console.WriteLine(str);