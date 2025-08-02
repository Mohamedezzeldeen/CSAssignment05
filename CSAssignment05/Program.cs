namespace CSAssignment05
{
    internal class Program
    {
        #region Methods

        #region Q1.Functions
        //Q1.1By-Value
        //public static void ChangeValue(int X , int Y) 
        //{
        //    int Glass = X;
        //    X = Y;
        //    Y = Glass;
        //}

        //Q1.2By-Reference
        //public static void ChangeValue(ref int X, ref int Y)
        //{
        //    int Glass = X;
        //    X = Y;
        //    Y = Glass;
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


        }
    }
}
