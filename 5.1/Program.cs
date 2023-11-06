namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-What are the six combinations of access modifier keywords and what do they do?
            //public private protected internal protected internal private protected?


            //2.What is the difference between the static, const, and readonly keywords when applied to a type member ?

            //static
            // یک عضو استاتیک به خود نوع تعلق دارد، نه به نمونه خاصی از نوع.  یعنی بدون ایجاد نمونه میتوان به متدهای کلاس دسرتسی داشت 
            // فضای ذخیره سازی نیز کش سی پی یو میباید


            //Constant 
            // در زمان اعلان باید یک مقدار به آن اختصاص داده شود و این مقدار نمی تواند در طول زمان اجرا تغییر کند.
            //یک عضو فقط خواندنی برای فیلدهایی استفاده می‌شود که فقط می‌توانند در زمان اعلان یا در سازنده آن نوع، مقداری به آن اختصاص دهند.پس از آن، مقادیر آنها قابل تغییر نیست.





            //3.What does a constructor do?   مشخصه

            //4. Why should you apply the [Flags] attribute to an enum type when you want to store combined values?

            //ویژگی[Flags]
            //رای پوشش فیلدهای بیتی و انجام مقایسه بیتی استفاده می‌شود. از این ویژگی باید برای زمانیکه یک داده شمارشی می‌تواند چندین مقدار را به صورت همزمان داشته باشد، استفاده کرد.
            var c = Test.Test1 | Test.Test2 | Test.Test3 | Test.Test4 | Test.Test5;



            //5. Why is the partial keyword useful?
            //تفکیک کد 
            // توسعه مشارکتی 
            //  خوانایی و سازماندهی
            // تست واحد
            //  توسعه پذیری



            //6.What is a tuple ?
            //تاپل یک ساختار داده در سی شارپ است که به شما امکان می‌دهد تعداد ثابتی از عناصر را که هر کدام از انواع داده‌های بالقوه متفاوت هستند را با هم گروه‌بندی کنید.

            // تاپل ها مرتب هستند
            //تاپل ها معمولا تغییر ناپذیر هستند،
            //ناهمگن
            //  اندازه ثابت



            //7. What does the record keyword do?
            //در سی شارپ 9.0 به بعد،
            //از کلمه کلیدی رکورد برای تعریف انواع رکورد استفاده می شود که نوع جدیدی از نوع مرجع معرفی شده در زبانسی شارپ  است.
            //رکوردها برای ساده سازی ایجاد کلاس هایی طراحی شده اند که عمدتاً برای نگهداری و انتقال داده ها استفاده می شوند

            //رکوردها دارای معنای ارزشی هستند،
            //به این معنی که دو رکورد با مقادیر یکسان برابر در نظر گرفته می شوند..

            //Immutable


            //8. What does overloading mean?
            //static polymorphism
            //void Sum(int a)
            //void Sum(int a, int b)

            //9.What is the difference between a field and a property?

            //فیلد
            // به طور واضح داده را ذخیره میکند
            // حاوی هیچ منطق و بیزینسی نیستند

            //Properties 
            //یک ساختار با دسترسی بالا که از بالا به پایین به فیلدهه دسترسی دارند
            //کپسوله سازی
            // قابیلت پیاده سازی منطق


            //10.How do you make a method parameter optional ?
            MyMethod(requiredParam: 10);         // optionalParam defaults to 42
            MyMethod(requiredParam: 10, optionalParam: 20);
            void MyMethod(int requiredParam, int optionalParam = default)
            {
              
            }
        }



        [Flags]
        protected enum Test : int
        {
            Test1 = 0,
            Test2 = 1,
            Test3 = 2,
            Test4 = 3,
            Test5 = Test3 | Test4,
        }


  
    }
}