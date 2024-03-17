// Задайте произвольную строку. Выясните, является ли она палиндромом.


bool IsPalindrome(string str)
{
    bool flag = true;
    for (int i = 0; i < str.Length/2; i++)
    {
        if (str[i] != str[str.Length - 1 - i]) flag = false;
    }
    return flag;
}

string notPalindrome = "adsdes,f";
string palindrome = "Abc.,!,.cbA";


if (IsPalindrome(notPalindrome)) Console.WriteLine("String is palindrome!");
else Console.WriteLine("String is not palindrome!");


if (IsPalindrome(palindrome)) Console.WriteLine("String is palindrome!");
else Console.WriteLine("String is not palindrome!");