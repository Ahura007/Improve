using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _10._1;

internal class Program
{
    static void Main(string[] args)
    {
        //1. What type would you use for the property that represents a table, for example, the Products
        // property of a database context ?
        // DbSet

        //2.What type would you use for the property that represents a one - to - many relationship, for
        //example, the Products property of a Category entity ?
        //جواب پایین صفحه


        //3.What is the EF Core convention for primary keys?
        //جواب پایین صفحه.


        //4. When might you use an annotation attribute in an entity class?



        // 5.Why might you choose the Fluent API in preference to annotation attributes?
        //جداسازی مسائل poco
        //یکربندی‌های پیچیده
        //پیکربندی‌های پویا
        //پیکربندی‌های شرطی:
        //پیکربندی‌های سراسری
        //مهاجرت
        //کنواختی در دیتابیس‌های مختلف




        //6-6. What does a transaction isolation level of Serializable mean?
        //یک مجموعه از خصوصیات است که میزان جدایی عملیات درون یک تراکنش از تأثیرات تراکنش‌های همزمان دیگر را تعیین می‌کند
        //وقتی یک تراکنش به سطح ایزوله‌سازی 
        //Serializable تنظیم می‌شود، این به معنای وجود ویژگی‌های زیر است
        // Read and Write Locks همزماناً قفل‌های خواندن و نویسی بر روی داده‌هایی که به آنها دسترسی دارند را فراهم می‌کنند. این قفل‌ها جلوی دسترسی همزمان تراکنش‌های دیگر به همان داده‌ها را تا پایان تراکنش فعلی می‌گیرند
        //Consistent Snapshot:  هرگاه تراکنش یک قسمت از داده را خوانده است، این داده تا پایان تراکنش حتی اگر تراکنش‌های دیگر همزمان آن داده را تغییر دهند، تغییر نمی‌کند
        //Phantom Reads Prevention: چلوگیری از خواندن کل ردیف اطلاعاتی 

        //7. What does the DbContext.SaveChanges() method return?

        //If no changes were made in the context:  The method returns 0
        //If changes were made and successfully saved:
        //The method returns the total count of entities whose state was modified, added, or deleted.
        //If an error occurs during the save operation:
        // An exception is thrown, and the method does not return a value.


        //8.What is the difference between eager loading and explicit loading?
        //Eager Loading: لود کردند تمام زیر کلاس ها
        //Explicit Loading: لود کرد زیر کلاس   داده مورد نظر 


        //10. What benefit do you get from declaring entity navigation properties as virtual?
        //enables lazy loading, 
        //override navigation

    }

}

//2 3 4 
public class Category
{
    [Key]
    [Column(Order = 1)]
    public int CategoryId { get; set; }
    [Column(Order = 2)]
    [Required]
    public string CategoryName { get; set; }


 
    [Column("ProductCodeInDatabase" ,Order =3)]
    public int ProductCode { get; set; }

    // One-to-many relationship: One Category has many Products
    public ICollection<Product> Products { get; set; }
}

public class Product
{
    public int ProductId { get; set; }// Convention assumes this is the primary key
    public string ProductName { get; set; }

    // Foreign key to establish the relationship
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }

    // Navigation property for the Category
    public Category Category { get; set; }
}


 