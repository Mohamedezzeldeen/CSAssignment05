using System.Xml.Linq;

namespace CSAssignment05
{
    internal class Program
    {
        #region Methods

        #region Q1.Functions
        //Q1.1By-Value
        #region Q1.1By-Value
        //public static void ChangeValue(int X , int Y) 
        //{
        //    int Glass = X;
        //    X = Y;
        //    Y = Glass;
        //}
        #endregion

        //Q1.2By-Reference
        #region Q1.2By-Reference
        //public static void ChangeValue(ref int X, ref int Y)
        //{
        //    int Glass = X;
        //    X = Y;
        //    Y = Glass;
        //}
        #endregion

        #endregion

        #region Q2.Functions

        //Q2.1By-Value
        #region Q2.1By-Value
        //public static int ArrayChange(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 100, 200, 300 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        //Q2.2By-Reference
        #region Q2.2By-Reference
        //public static int ArrayChange(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr = new int[] { 100, 200, 300 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        #endregion

        #region Q3.Functions
        //public static void SUMSUB(int Num1, int Num2, out int Sum, out int Sub ) 
        //{
        //    Sum = Num1 + Num2;
        //    Sub = Num1 - Num2;
        //}
        #endregion

        #region Q4.Functions
        //public static int Num(int Num0) 
        //{
        //    int FNum0 = Num0 / 10;
        //    int SNum0 = Num0 % 10;
        //    int Sum = FNum0 + SNum0;
        //    return Sum;
        //}
        #endregion

        #region Q5.Functions IsPrime

        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        #endregion

        #region Q6.Functions
        //public static void MinMaxArray(int[] Num,out int Min,out int Max) 
        //{
        //    Min = Num[0]; Max = Num[0];
        //    for (int i = 0; i < Num.Length; i++)
        //    {
        //        if (Num[i] > Max ) 
        //        {
        //            Max = Num[i];
        //        }
        //        if ( Num[i] < Min ) 
        //        {
        //            Min = Num[i];
        //        }
        //    }

        //}
        #endregion

        #region Q7.Function
        //public static int iterativeFun(int Num)
        //{
        //    int Box = 1;
        //    for (int i = Num; i >= 1; i--)
        //    {
        //        Box *= i;
        //    }
        //    return Box;
        //}
        #endregion

        #region Q8.Function
        //public static string ChangeChar(string Name, int Num, string NewChar)
        //{
        //    string Box = "";

        //    for (int i = 0; i < Name.Length; i++) 
        //    {
        //        if(i == Num) 
        //        {
        //            Box += NewChar;
        //        }
        //        else
        //        {
        //            Box += Name[i];
        //        }
                
        //    }
        //    return Box;
        //}
        #endregion

        #endregion

        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //1-value 
            //When we pass value type parameters by value, only a copy of the data is passed.
            //and Any changes inside the method don't affect the original variables.
            //Ex:
            //int A = 1;
            //int B = 2;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //ChangeValue(A,B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            //2-Reference
            // When we pass value type parameters by reference,
            // any changes inside the method affect the original variables.
            //Ex:
            //int A = 1;
            //int B = 2;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //ChangeValue(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //1.Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(ArrayChange(Numbers));
            //Console.WriteLine(Numbers.GetHashCode());
            //Console.WriteLine(Numbers[0]);

            //Here we find that The Original Array didn't Change

            //2.Reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(ArrayChange(ref Numbers));
            //Console.WriteLine(Numbers.GetHashCode());
            //Console.WriteLine(Numbers[0]);

            //Here we find that The Original Array Changed
            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter the first number: ");
            //int A = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int B = Convert.ToInt32(Console.ReadLine());
            //SUMSUB(B, A, out int sumResult, out int subResult);
            //Console.WriteLine(sumResult);
            //Console.WriteLine(subResult);



            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine(82/10);
            //Console.WriteLine(82%10);
            //Console.Write("Enter First Num : ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"The sum of the digits of the number {Number} is {Num(Number)} ");
            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //Console.Write("Enter Number : ");
            //bool Flag = int.TryParse(Console.ReadLine(), out int Num);
            //if (Flag) 
            //{
            //    if (IsPrime(Num))
            //    {
            //        Console.WriteLine("True");
            //    } else 
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Numbers = new int[] { 1, 2, 1 };
            //MinMaxArray(Numbers,out int MinNum,out int MaxNum);
            //Console.WriteLine(MinNum);
            //Console.WriteLine(MaxNum);
            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter Number : ");

            //bool Flag = int.TryParse(Console.ReadLine(), out int Num);

            //if (Flag) 
            //{
            //    Console.Clear();
            //    Console.WriteLine(iterativeFun(Num));
            //}



            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string Name;
            //int Number;
            //string Character;
            //bool Flag;
            //do
            //{
            //    Console.Write("Enter String : ");
            //    Name = Console.ReadLine();
            //    if (string.IsNullOrEmpty(Name)) 
            //    {
            //        Flag = false;
            //    }
            //    Console.Write("Enter Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //    Console.Write("Enter New char : ");
            //    Character = Console.ReadLine();
            //}
            //while (Character.Length > 1 || !Flag );

            //Console.WriteLine(ChangeChar(Name,Number,Character));
            #endregion
        }
    }
}
