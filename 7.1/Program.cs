namespace _7._1;

internal class Program
{
    static void Main(string[] args)
    {
        //1- What is the difference between a namespace and an assembly?
        //namespace.
        //یک فضای نام برای سازماندهی کد و جلوگیری از تداخل نامگذاری استفاده می شود
        //به حفظ یک پایگاه کد تمیز و ساختار یافته کمک می کنند.


        //Assembly
        //اسمبلی یک واحد کد کامپایل شده است که شامل انواع و منابع است
        //یک اسمبلی می تواند یک کتابخانه پیوند پویا (DLL) یا یک فایل اجرایی (EXE) باشد.
        // هنگامی که یک پروژه  سی شارپ را کامپایل می کنید، یک اسمبلی به دی ال ال یا اگزه تبدیل میشه  


        //2-How do you reference another project in a .csproj file?
        //< ItemGroup >
        //    < !--Reference to another project-- >
        //    < ProjectReference Include = "..\Path\To\AnotherProject.csproj" />
        //    </ ItemGroup >



        //3- What is the benefit of a tool like ILSpy?
        //  یک مرورگر و دکامپایلر متن باز برای محیطدات نت  است که به توسعه‌دهندگان این امکان را 
        // به بررسی مازول های اماده رسیدیگ کنند



        //4-Which .NET type does the C# float alias represent?
        System.Single sample = 0;




        //5- When porting an application from .NET Framework to modern .NET, what tool should you run
        // before porting, and what tool could you run to perform much of the porting work?

        //API Portability Analyzer (APA):
        //NET Portability Analyzer:


        //6. What is the difference between framework-dependent and self-contained deployments of
        // .NET applications?


        //7. What is a RID?
        //شناسایی پلتفرم  مورد استفاده قرارا میگیرد 



        //8.What is the difference between the dotnet pack and dotnet publish commands?
        //dotnet pack برای ایجاد پکیج نوگت
        //publish  برای بردن روی هاست

        //9.What types of applications written for .NET Framework can be ported to modern.NET ?
        //Class Libraries:
        //Console Applications:
        //ASP.NET MVC and Web API Applications:
        //Windows Forms Applications:.
        //WPF
        ////ASP.NET Web Forms Applications:
        /////WCF
        ///



        //10.Can you use packages written for .NET Framework with modern.NET ?
        //خیر
    }


}
