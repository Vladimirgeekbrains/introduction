// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReverseWords(string str)
{
    // string result = string.Empty;
    string[] result = str.Split(' ');
    string temp = "";
    for (int i = 0; i < result.Length/2; i++)
    {
        temp = result[i];
        result[i] = result[result.Length - 1 - i];
        result[result.Length - 1 -i] = temp;
    }
    return string.Join(' ', result);
}

string str = "Hello world! How are you?";

Console.WriteLine(ReverseWords(str));