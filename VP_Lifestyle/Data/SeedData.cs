using VP_Lifestyle.Models;
using Microsoft.EntityFrameworkCore;

namespace VP_Lifestyle.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            LifestyleDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetService<LifestyleDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            if(!context.Categories.Any())
            {
                context.Categories.AddRange(
                       new Category { CategoryName ="Breakfast", CategoryDescription="Popular"},
                       new Category { CategoryName ="Launch", CategoryDescription="Special"},
                       new Category { CategoryName ="Dinner", CategoryDescription="Lovely"}
                    );
            }
            context.SaveChanges();
             
            if(!context.Products.Any())
            {

                context.Products.AddRange(
                    new Product
                    {   //1
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-1.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //2
                        CategoryID = 1, ProductName = "Beef burger", ProductCode = "menu-2.jpg",
                        Price = (decimal)200, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //3
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-3.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //4
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-4.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //5
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-5.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //6
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-6.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //7
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-7.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //8
                        CategoryID = 1, ProductName = "Chicken Burger", ProductCode = "menu-8.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //9
                        CategoryID = 2, ProductName = "Chicken Burger", Price = (decimal)115.00, ProductCode = "menu-1.jpg",
                        ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //10
                        CategoryID = 2, ProductName = "Chicken Burger", Price = (decimal)115.00, ProductCode = "menu-2.jpg",
                        ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //11
                        CategoryID = 2, ProductName = "Chicken Burger", Price = (decimal)115.00, ProductCode = "menu-3.jpg",
                        ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam" },
                    new Product
                    {   //12
                        CategoryID = 2, ProductName = "Chicken Burger", ProductCode = "menu-4.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //13
                        CategoryID = 2, ProductName = "Chicken Burger", ProductCode = "menu-5.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //14
                        CategoryID = 2, ProductName = "Chicken Burger", ProductCode = "menu-6.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //15
                        CategoryID = 2, ProductName = "Chicken Burger", ProductCode = "menu-7.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //16
                        CategoryID = 2, ProductName = "Chicken Burger", ProductCode = "menu-8.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //17
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode = "menu-1.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //18
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-2.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //19
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-3.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //20
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-4.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {  //21
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-5.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {  //22
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-6.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {  //23
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-7.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    },
                    new Product
                    {   //24
                        CategoryID = 3, ProductName = "Chicken Burger",ProductCode= "menu-8.jpg",
                        Price = (decimal)115.00, ProductDescription = "Ipsum ipsum clita erat amet dolor justo diam"
                    }
                    );

            }
            context.SaveChanges();
        }
    }
}
