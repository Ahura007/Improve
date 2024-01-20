using System.IO;
using System.IO.Compression;

namespace _9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.What is the difference between using the File class and the FileInfo class?

            //class File 
            // یک کلاس استاتیک برای و با مدیریت کم  تک عملیاتی و بدون ارایه جزییات  

            // FileInfo 
            // کار روی یک فایل مشخض با قابلیت چندین عملیات همزمان و ارایه جزییات کافی


            //2.What is the difference between the ReadByte method and the Read method of a stream ?


            // ReadByte  خواندن یک بایت در واحد زمان
            // Read خواندن چندین بایت در واحد زمان

            // ReadByte  بایتی   بازگشت از نوع مقادیر 
            // Read   بازشگت از نوع تعداد کل خانه های خوانده شد

            // ReadByte برای خواتد هر واحد بایت مناسب انجام عملیات مجزا  
            // Read  کارایی بهتر در بافر و درنتیجه بهبود در عملیات سنگین



            //3. When would you use the StringReader, TextReader, and StreamReader classes?

            //StringReader   کلاسی که طراحی شده برای خواندن در استرینگ به صورت کاراکتر به کاراکتر یا خط به خط
            //TextReader  یک کلاس ابسترکت برای خواند کاراکتر به کاراکتر ار تکست و قابلیت سوییچ و پیاده ساری الگوریتم های دیگه به ما میدهد
            //StreamReader    برای خواندن متن از فایل طراحی شده است 


            //4. What does the DeflateStream type do?
            // برای فشرده سازی و ازاد سازی دیتاها استفاده میشود 
            // معمولا پسوند های zlib gzip zip دارند

            using var inputFile = File.OpenRead("input.txt");
            using var compressedFile = File.Create("compressed.deflate");
            using var deflateStream = new DeflateStream(compressedFile, CompressionMode.Compress);
            inputFile.CopyTo(deflateStream);


            using var compressedFile1 = File.OpenRead("compressed.deflate");
            using var outputFile1 = File.Create("output.txt");
            using var deflateStream1 = new DeflateStream(compressedFile1, CompressionMode.Decompress);
            deflateStream1.CopyTo(outputFile1);

 


            //7. What is the best serialization format to choose for minimizing space requirements?
            //MessagePack
            //Protocol Buffers (protobuf)
            //BSON (Binary JSON):

            //8.What is the best serialization format to choose for cross - platform compatibility ? 
            //JSON 
            //XML 
            //YAML 




            //9. Why is it bad to use a string value like "\Code\Chapter01" to represent a path, and what
            // should you do instead?

            //تفاوت پلتفرم ها 
            //خوانایی کمتر کد
            // هر چه هارد کد بیشتر باشه قابلیت حمل کد کمتر 

            //string path = Path.Combine("Code", "Chapter01");
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Code", "Chapter01");


            //10.Where can you find information about NuGet packages and their dependencies?
            //https://www.nuget.org/
            //Visual Studio Package Manager:
            //Package Manager Console Commands: //Get-Package -Name YourPackageName -ListAvailable
            //dotnet CLI: //dotnet list package



        }
    }
}
