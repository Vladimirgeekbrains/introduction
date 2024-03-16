// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
      
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//      Console.WriteLine("First number is greater");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine("Second number is greater");
// }
// else
// {
//     Console.WriteLine("Numbers are equal");
// }

int[,] arr = new int[2,3] {
    {1, 2, 3},
    {4, 5, 6}
};
Console.WriteLine(arr[0,0] + " " + arr[1, 1]);
