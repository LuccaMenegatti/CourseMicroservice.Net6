using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff5",
                    Name = "Iphone X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff6",
                    Name = "Sansung 10",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-2.png",
                    Price = 750.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff7",
                    Name = "Moto G30",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-3.png",
                    Price = 500.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff8",
                    Name = "Acer Nitro 5",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-4.png",
                    Price = 2500.00M,
                    Category = "Notbook"
                },
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff9",
                    Name = "Macbook",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-5.png",
                    Price = 7500.00M,
                    Category = "Notbook"
                },
                new Product()
                {
                    Id= "602d2149e773f2a3990b47ff0",
                    Name = "Air Frier",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                    " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                    "pariatur. Excepteur sint occaecat cupidatat non proident," +
                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-6.png",
                    Price = 300.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
}
