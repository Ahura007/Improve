namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;

             
            Console.WriteLine($"My name is {name} and I am {age} years old.");

            string formattedString = string.Format("My name is {0} and I am {1} years old.", name, age);
            Console.WriteLine(formattedString);

            string text1 = "123";
            Console.WriteLine(text1.PadLeft(5, '0'));



            string text2 = "Hello";
            Console.WriteLine(text2.PadLeft(10));  
            Console.WriteLine(text2.PadRight(10)); 
            Console.WriteLine(text2.PadLeft(10).PadRight(15));  


            int x = 5;
            double y = 3.14;
            Console.WriteLine("The value of x is: {0}, and the value of y is: {1:F2}", x, y);
        }
    }
}