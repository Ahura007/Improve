namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = UniqueNumber.UniqueNumbers(6);
            Console.WriteLine(result);
        }
    }

    public class UniqueNumber
    {
        public static string UniqueNumbers(int number)
        {
            var numbers = new List<int>
            {
                2,3,5,7,11,13,17,19,23
            };

            var result = string.Empty;

            foreach (var div in numbers)
            {
                int divRemain;
                do
                {
                    divRemain = number % div;
                    if (divRemain == 0)
                    {
                        number = number / div;
                        if (number == 1)
                        {
                            result += $"{div}";
                        }
                        else
                        {
                            result += $"{div} x ";
                        }
                    }
                } while (divRemain == 0);
            }
            return $"{result}";
        }
    }
}