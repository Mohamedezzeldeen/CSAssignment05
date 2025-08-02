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

            
        }
    }
}
