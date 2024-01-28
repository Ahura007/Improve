using System;

namespace _11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. What are the two required parts of LINQ?
            //LINQ Query Syntax:
            //LINQ Method Syntax (Extension Methods):


            //2. Which LINQ extension method would you use to return a subset of properties from a type?
            // var result = people.Select(person => new { person.Id, person.Name });


            //3. Which LINQ extension method would you use to filter a sequence?
            // numbers.Where(x => x % 2 == 0);


            //4. List five LINQ extension methods that perform aggregation
            //int count = collection.Count();
            //int sum = numbers.Sum();
            //double average = numbers.Average();
            //int minValue = numbers.Min();
            //int maxValue = numbers.Max();


            //5. What is the difference between the Select and SelectMany extension methods?
            //var result = collection.SelectMany(item => item.SubCollection);


            //6. What is the difference between IEnumerable<T> and IQueryable<T>? How do you switch
            // between them?

            //IEnumerable
            //بالاتریم کلاس پایه
            // فیلتر در سی شارپ انجام میشه 
            // به درد کار با دادها درون حتفظه میخوره 
            //IQueryable
            //فیلتر در سطح دیتا بیس انحام میشه



            //7. What does the last type parameter T in generic Func delegates like Func<T1, T2, T> represent?
            // Func < T1, T2, ..., TResult >
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(3, 5);



            //8. What is the benefit of a LINQ extension method that ends with OrDefault?

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            int firstOrDefault = numbers.FirstOrDefault(); // Returns 1
            int firstOrDefaultEmpty = Enumerable.Empty<int>().FirstOrDefault(); // Returns 0 (default for int)

            //FirstOrDefault null if result not found
            //First throw exception


            //9. Why is query comprehension syntax optional?

            var queryComprehension = from number in numbers
                where number % 2 == 0
                orderby number
                select number;

       
            var methodSyntax = numbers.Where(number => number % 2 == 0)
                .OrderBy(number => number);

            // 10.How can you create your own LINQ extension methods?
            var filteredNumbers = numbers.Filter(x => x % 2 == 0);

        }
    }
}


public static class MyLinqExtensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var item in source)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}