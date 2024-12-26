namespace Assignment_06
{
    internal class Program
    {

        #region Functions


        //public static void SumAndSub(int num1, int num2, int num3, int num4 , out int sum , out int sub)
        //{
        //     sum = num1 + num2;
        //     sub = num3 - num4;
        //}

        //static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    if (array.Length == 0)
        //    {
        //        throw new ArgumentException("Array cannot be empty.");
        //    }

        //    min = array[0];
        //    max = array[0];

        //    foreach (int number in array)
        //    {
        //        if (number < min)
        //            min = number;

        //        if (number > max)
        //            max = number;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region 01 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /* In Passing by Value in Reference Type it passed the Address of data 
             * that give the function access of data 
             * In passing by value it be (Input)
             * In Passing by Reference it passed the real variable and give it anothe name in function
             * function have acces the data 
             * In passing by Reference it be (Input OutPut)
             
             */

            #endregion

            #region 02 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int sum, sub;
            //SumAndSub(10, 20, 50, 30, out sum, out sub);
            //Console.WriteLine($"Sum: {sum}, Subtraction: {sub}");
            #endregion

            #region  03 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = { 15, 3, 42, 7, 23 };
            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");
            #endregion
        }
    }
}
