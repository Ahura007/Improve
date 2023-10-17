namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var num1 = 120 + "";
            var num2 = 0 + ""; ;

            try
            {
                var a = byte.Parse(num1);
                var b = byte.Parse(num2);

                int answer = a / b;

                Console.WriteLine($"{answer}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}