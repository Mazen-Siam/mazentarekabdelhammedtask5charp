using System;
using System.Collections.Generic;

namespace task5csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //try
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int result = a / b;
            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //} 
            #endregion

            #region Problem3
            //int? number = null;

            //int result = number ?? 10;
            //Console.WriteLine($"Result after ?? operator: {result}");

            //if (number.HasValue)
            //{
            //    Console.WriteLine($"Number has value: {number.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Number is null, so HasValue = false");
            //} 
            #endregion

            #region Problem4
            //int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            //try
            //{

            //    Console.WriteLine(numbers[10]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: Attempted to access an index outside the array bounds.");
            //    Console.WriteLine($"Exception details: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Program finished safely."); 
            #endregion


            #region Problem5
            //int[,] matrix = new int[3, 3];

            //for (int i = 0; i < matrix.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)                    {
            //        Console.Write($"Enter value for element [{i},{j}]: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of row {i}: {rowSum}");
            //}

            //for (int j = 0; j < matrix.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of column {j}: {colSum}");
            //} 
            #endregion

            #region Problem6
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2]; 
            //jaggedArray[1] = new int[4]; 
            //jaggedArray[2] = new int[3]; 

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nJagged Array Contents:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write("Row " + i + ": ");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //} 
            #endregion

            #region Problem7
            //string? userInput;

            //Console.Write("Enter your name (or press Enter to skip): ");
            //userInput = Console.ReadLine();

            //// Step 2: Assign conditionally
            //if (string.IsNullOrEmpty(userInput))
            //{
            //    userInput = null;
            //}

            //// Step 3: Use null-forgiveness operator
            //// Suppresses compiler warning when we know it's safe
            //string safeName = userInput!;

            //Console.WriteLine($"Hello, {safeName ?? "Guest"}!");

            #endregion

            #region Problem8
            //int num = 42;
            //object boxed = num;
            //Console.WriteLine($"Boxed value: {boxed}");

            //try
            //{
            //    int unboxed = (int)boxed;
            //    Console.WriteLine($"Unboxed value: {unboxed}");

            //    string wrongCast = (string)boxed; 
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("Error: Invalid cast during unboxing.");
            //    Console.WriteLine($"Exception details: {ex.Message}");
            //} 
            #endregion

            #region Problem11
            //int[]? numbers = null;

            //int? length = numbers?.Length; 
            //Console.WriteLine($"Array length: {length ?? 0}"); 
            #endregion

            #region Problem12
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //day = day?.Trim().ToLower();

            //int dayNumber = day switch
            //{
            //"monday"    => 1,
            //"tuesday"   => 2,
            //"wednesday" => 3,
            //"thursday"  => 4,
            //"friday"    => 5,
            //"saturday"  => 6,
            //"sunday"    => 7,



            //    _ => 0 
            //};

            //if (dayNumber == 0)
            //    Console.WriteLine("Invalid day entered.");
            //else
            //    Console.WriteLine($"{char.ToUpper(day[0]) + day.Substring(1)} corresponds to {dayNumber}"); 
            #endregion

            #region Problem13
            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;
            //    foreach (int num in numbers)
            //    {
            //        sum += num;
            //    }
            //    return sum;
            //}

            //static void Main()
            //{
            //    int result1 = SumArray(1, 2, 3, 4, 5);
            //    Console.WriteLine($"Sum of individual values: {result1}");

            //    int[] arr = { 10, 20, 30 };
            //    int result2 = SumArray(arr);
            //    Console.WriteLine($"Sum of array values: {result2}");
            //} 
            #endregion

            #region Problem14
            //Console.Write("Enter a positive integer: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n <= 0)
            //{
            //    Console.WriteLine("Please enter a positive integer.");
            //    return;
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i);
            //    if (i < n) Console.Write(", ");
            //} 
            #endregion

            #region Problem15
            //Console.Write("Enter an integer: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{n} x {i} = {n * i}");
            //} 
            #endregion

            #region Problem16
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n < 2)
            //{
            //    Console.WriteLine("No even numbers in the range.");
            //    return;
            //}

            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i);
            //    if (i < n && i + 2 <= n) Console.Write(", "); 
            //} 
            #endregion

            #region Problem17
            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine($"{baseNum}^{exponent} = {result}"); 
            #endregion

            #region Problem18
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //// Step 1: Convert to char array and reverse
            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars);

            //// Step 2: Create reversed string
            //string reversed = new string(chars);

            //// Step 3: Print result
            //Console.WriteLine($"Reversed string: {reversed}"); 
            #endregion

            #region Problem19
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //char[] digits = number.ToString().ToCharArray();
            //Array.Reverse(digits);

            //int reversed = int.Parse(new string(digits));
            //Console.WriteLine($"Reversed number: {reversed}"); 
            #endregion

            #region Problem20
            //Console.Write("Enter numbers separated by spaces: ");
            //string input = Console.ReadLine();
            //int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);

            //Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            //int maxDistance = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!firstIndex.ContainsKey(arr[i]))
            //    {
            //        firstIndex[arr[i]] = i;
            //    }
            //    else
            //    {
            //        int distance = i - firstIndex[arr[i]] - 1;
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //        }
            //    }
            //}

            //Console.WriteLine($"Longest distance between matching elements: {maxDistance}"); 
            #endregion

            #region Problem21
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //// Step 1: Split into words
            //string[] words = sentence.Split(' ');

            //// Step 2: Reverse order of words
            //Array.Reverse(words);

            //// Step 3: Print result in one line
            //Console.WriteLine(string.Join(" ", words)); 
            #endregion



        }
        #region Problem2
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //    {
        //        Console.WriteLine("Enter first number (positive integer): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

        //    do
        //    {
        //        Console.WriteLine("Enter second number (positive integer greater than 1): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;
        //    Console.WriteLine($"Result of {X} / {Y} = {Z}");


        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 2) 
        //        arr[2] = 90;
        //} 
        #endregion
        #region Problem10
        //static void PrintMessage(string message, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(message);
        //    }
        //    PrintMessage("Hello"); 
        //    PrintMessage("Welcome", 3); 
        //    PrintMessage(message: "Named Parameter Example", times: 2); 
        #endregion




        #region Problem9
        //static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;        // must initialize out parameters
        //    product = a * b;
        //}

        //static void Main()
        //{
        //    int x = 5, y = 3;
        //    int resultSum, resultProduct;

        //    // Step 2: Call method
        //    SumAndMultiply(x, y, out resultSum, out resultProduct);

        //    // Step 3: Print results
        //    Console.WriteLine($"Sum of {x} and {y} = {resultSum}");
        //    Console.WriteLine($"Product of {x} and {y} = {resultProduct}");
        //} 
        #endregion


    }
}
