using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SuperRentals.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Mini Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Family Cars"
                }
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {



                new Product
                {
                    ProductID = 1,
                    ProductName = "Daihatsu COO is a mini MPV and is also known as Daihatsu Materia.",
                    Description = " It is known as Daihatsu Materia. It comes with the engine specifications of 1.3L and 1.5L. There is also a 4WD version. It is a 5 door car and provides comfortable seating for 5 people. The automatic transmission adds to a more enjoyable ride. Rent this care for $4000 a day .",
                    ImagePath= "Images/image1.jpg",
                    UnitPrice = 4000,
                    ProductNumber ="111",
                    CategoryID =1,
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Imported Mitsubishi Grandis offers high build quality and a variety of features.",
                    Description = "It has features like the auto key, power mirror, power steering, power window, rear spoiler, supplemental restraint system, and many others.Rent this car for $5000 a day",
                    ImagePath="Images/image2.jpg",
                    UnitPrice = 5000,
                    ProductNumber ="867",
                    CategoryID=2,
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Toyota Prius is one of the most popular hybrid cars in the world.",
                    Description = "It is the first mass-produced vehicle that first appeared in 1997. It has excellent fuel saving characteristics. It saves fuel cost by running on battery and emits low CO2 in the environment, thus saves the environment.Rent this car for $6000 a day",
                    ImagePath="Images/image3.jpg",
                    UnitPrice = 6000 ,
                     ProductNumber ="762",
                     CategoryID=1,
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Nissan Cube is a mini MPV manufactured by Nissan since 1998.",
                    Description = "It has an extended load carriage capacity than its stalemate Nissan March hatchback. The first generation of Nissan Cube appeared in 1998 and it has been improved over the generations! Rent this car for $4000 a day",
                    ImagePath="Images/image4.jpg",
                    UnitPrice = 4000,
                   ProductNumber ="112",
                   CategoryID=1,
                },

            };

           
               

            return products;
        }
    }
}
