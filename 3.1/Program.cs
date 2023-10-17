using System.Collections;
using System.Linq.Expressions;
using System.Threading;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.What happens when you divide an int variable by 0 ?             System.DividedByZeroException


            //2. What happens when you divide a double variable by 0?
            double result1 = 5.0 / 0.0; // result is Double.PositiveInfinity
            double result2 = -5.0 / 0.0; // result is Double.NegativeInfinity
            double result3 = 0.0 / 0.0; // result is Double.NaN


            //3.What happens when you overflow an int variable, that is, set it to a value beyond its range?

            int maxInt = int.MaxValue; // 2,147,483,647
            int overflowed = maxInt + 1; // Overflow occurs, and overflowed becomes int.MinValue (-2,147,483,648)

            unchecked
            {
                int maxInt1 = int.MaxValue; // 2,147,483,647
                int overflowed1 = maxInt + 1; // Overflow occurs, and overflowed becomes int.MinValue (-2,147,483,648)
            }

            checked
            {
                int maxInt2 = int.MaxValue; // 2,147,483,647
                int overflowed2 = maxInt + 1; // This code will throw an OverflowException
            }


            //4. What is the difference between x = y++; and x = ++y;?
            //(Post - increment):
            //(Pre - increment):
            //x = y++; assigns the current value of y to x and then increments y.
            //x = ++y; increments y first and then assigns the updated value of y to x.


            //5. What is the difference between break, continue, and return when used inside a loop statement?
            //break   برای خروج پیش از موعد از حلقه استفاده می شود.
            //continue  پرش از روی یکی از خانه های حلقه
            //return خروج از حلقه و متد



            //6.What are the three parts of a for statement and which of them are required ?
            //for (Initialization;  Condition ;  Iteration )
            //{
            //    // Loop body
            //}


            //7.What is the difference between the = and == operators ?
            //  =  انتساب دادن مقدار
            //  == چک کردن برای مساوی بودن دو مقدار

            //8.   Does the following statement compile ?
            for (; ; );




            //9.What does the underscore _ represent in a switch expression ?
            int number = 42;

            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };



            // 10.What interface must an object “implement” to be enumerated over using the foreach statement?
            //IEnumerable , IEnumerable<T>


        }
    }
}