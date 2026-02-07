using System;

namespace task4csharp
{
    internal class Program
    {
        enum DayOfWeek
        {
            Saturday=1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
           
            
        }

        static void Main(string[] args)
        {
            #region Problem1
            //int[]arr1 = new int[3];
            //int[]arr2 = {10,20,30};
            //int[]arr3 = new int[] { 1, 2, 3 };
            //    arr1[0] = 100;
            //    arr1[1] = 200;
            //    arr1[2] = 300;
            //    Console.WriteLine(arr1[0]);
            //    Console.WriteLine(arr1[1]);
            //    Console.WriteLine(arr1[2]);

            //    arr1[3] = 400;
            //    Console.WriteLine(arr1[3]); 
            #endregion

            #region Problem2
            //int[] arr1 = {10,20,30};
            //int[] arr2 = {40,50,60};
            ////arr2 = arr1;
            ////Console.WriteLine(arr1[2]);
            ////Console.WriteLine(arr2[2]);
            ////Console.WriteLine(arr1.GetHashCode());
            ////Console.WriteLine(arr2.GetHashCode());


            //arr2 = (int[])arr1.Clone();
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode()); 
            #endregion

            #region Problem3
            //int[,] Grades = new int[3, 3];
            //for (int i = 0; i< Grades.GetLength(0);i++)
            //{
            //    Console.WriteLine($"for student {i + 1}");
            //    for (int j = 0; j < Grades.GetLength(1);j++)
            //    {
            //        Console.WriteLine($"for subject {j + 1}");
            //        bool flag = int.TryParse(Console.ReadLine(),out Grades[i,j]);
            //    }
            //}
            //Console.WriteLine("\n Students Grades");
            //for (int i = 0; i < Grades.GetLength(0);i++)
            //{
            //    Console.WriteLine($"Student {i + 1}:");
            //    for(int j = 0;j < Grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine(Grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem4
            //int[] arr = { 6, 8, 34, 8, 9, 3, 2, 9, 10 };
            //int[] arr2 = { 3, 5, 7, 9, 8, 4, 1 ,100};
            //Array.Sort(arr);
            //Console.WriteLine("Sort:");
            //foreach (int i in arr) 
            //{
            // Console.WriteLine(i); 
            //    Console.WriteLine();
            //}
            //Array.Reverse(arr);
            //Console.WriteLine("Reverse");
            //foreach (int i in arr)
            //{
            // Console.WriteLine(i);
            //    Console.WriteLine();
            //}
            //int index = Array.IndexOf(arr, 9);
            //Console.WriteLine("Indexof");
            //Console.WriteLine(index);

            //Array.Copy(arr, arr2, 2);
            //Console.WriteLine("Copy");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}

            //Array.Clear(arr,2,3);
            //Console.WriteLine("Clear");
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem5
            //int[] arr = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("for");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("foreach");
            //foreach(int x in arr)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("while");
            //int y = arr.Length -1;
            //while (y>=0)
            //{
            //    Console.WriteLine(arr[y]);
            //    y--;
            //}
            //Console.WriteLine(); 
            #endregion

            #region Problem6
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Positive Odd Number");
            //    flag = int.TryParse( Console.ReadLine(),out num);
            //}
            //while (flag == false || num %2 ==1 || num <0);

            #endregion

            #region Problem7
            //int[,] matrix =
            //    {
            //{1, 2, 3},
            //{4, 5, 6},
            //{7, 8, 9}
            //     };
            //Console.WriteLine("Matrix:");
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + "\t"); 
            //    }
            //    Console.WriteLine(); } 
            #endregion

            #region Problem8
            ////Console.WriteLine("Enter a month number");
            ////int month = int.Parse(Console.ReadLine());
            ////if (month == 1) Console.WriteLine("January");
            ////else if (month == 2) Console.WriteLine("Febuary");
            ////else if (month == 3) Console.WriteLine("March");
            ////else if (month == 4) Console.WriteLine("April");
            ////else if (month == 5) Console.WriteLine("May");
            ////else if (month == 6) Console.WriteLine("June");
            ////else if (month == 7) Console.WriteLine("July");
            ////else if (month == 8) Console.WriteLine("August");
            ////else if (month == 9) Console.WriteLine("September");
            ////else if (month == 10) Console.WriteLine("October");
            ////else if (month == 11) Console.WriteLine("November");
            ////else if (month == 12) Console.WriteLine("December");
            ////else Console.WriteLine("Invalid month number");

            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number!"); break;
            //} 
            #endregion

            #region Problem9
            //int[] arr = { 1, 5, 7, 6, 4 };

            //Console.WriteLine("Sort");
            //Array.Sort(arr);
            //foreach(int i in arr) Console.WriteLine(i); 
            #endregion

            #region Problem10
            //int[] arr= {1,2,3,4,5};
            //int sumfor = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sumfor += arr[i];
            //}
            //Console.WriteLine("Sum of for =" + sumfor);

            //int sumforeach = 0;
            //foreach (int i in arr)
            //{
            // sumforeach += i;
            //}
            //Console.WriteLine("Sum of foreach ="+ sumforeach); 
            #endregion


            #region Part2Problem2
            //Console.Write("Enter a number (1-7): ");
            //string input = Console.ReadLine();


            //if (int.TryParse(input, out int number) && number >= 1 && number <= 7)
            //{

            //    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), number.ToString());
            //    Console.WriteLine("The day is: " + day);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            //} 
            #endregion

            #region Part2problem3
            // it says invalid number 
            #endregion





        }
    }
}
