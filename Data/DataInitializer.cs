using XtendersProject.Models;
using System;
using System.Linq;

namespace XtendersProject.Data
{
    public class DataInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();


            if (!context.Products.Any())
            {

                var product = new Product();
                context.Products.Add(product);
                context.SaveChanges();
            }
           
        }
    }
}
