using System.Security;
using System.Text;

namespace _8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. What is the maximum number of characters that can be stored in a string variable?
            var maxLenghtOfstring = int.MaxValue;

            //2. When and why should you use a SecureString type?
            // رشته ها تغییر ناپذیر هستند و جای مناسبی برای نگهداری اطلاعات مهم نیست


            using var securePwd = new SecureString();
            var password = "password".ToCharArray();
            foreach (var item in password)
            {
                securePwd.AppendChar(item);
            }


            //3.When is it appropriate to use a StringBuilder class?
            //StringBuilder رشته از نوغ اغغیر پذیر است اگه میخاهدی پردازش روش رشته انجام بشه با استرینگ بیلدر انجام بشه


            //4. When should you use a LinkedList<T> class?
            //  هر گاه بخواهیم خانه فعلی به عنصر قبلی و بعدی دسترسی داشته باشه
            //تا عملیات درج و حذف به راختی انجام یشه
            // انعطاف پذیری
            // مدیریت و کارایی بهتر حافظه در سناریو های پویا

            //5. When should you use a SortedDictionary<T> class rather than a SortedList<T> class?

            //اگه قرار دیتا مدام حذف و اضافه انجم بشه دیکشنری بهتر تا لیست
            // برای دسترسی تصادفی به ایمدکس نیاز نداره و فقط کلید کافیه  که بسته با نیاز 
            // از نظر مصرف حافظه هم سورت لیسن بهتره.

            //6. In a regular expression, what does $ mean ?
            // line or the end of the input string

            //7. In a regular expression, how can you represent digits?
            // pattern: "\d"  pattern: "[0-9]"

            //8.Why should you not use the official standard for email addresses to create a regular expression
            //    to validate a user’s email address ?

            // سهولت در تشخیص دیتاهای نا معتبر
            // سرعت مطلوب

            //9.What characters are output when the following code runs?

            var city = "Aberdeen";
            var citySpan = city.AsSpan()[^5..^0];
            var result  = citySpan.ToString();


            //10. How could you check that a web service is available before calling it?
            //Ping the Server:
            //HTTP HEAD Request:
            //HTTP GET Request:

        }
    }
}
