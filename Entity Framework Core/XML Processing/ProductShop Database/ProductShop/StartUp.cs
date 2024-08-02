using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using ProductShop.Utilities;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext context = new ProductShopContext();

            //string usersXml = File.ReadAllText("../../../Datasets/categories-products.xml");
            Console.WriteLine(GetProductsInRange(context));
        }


        //Problem 1
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {

            var usersDtos = XmlHelper.DeserializeCollection<ImportUsersDTO>(inputXml, "Users");

            ICollection<User> validUsers = new HashSet<User>();
            foreach (var dto in usersDtos)
            {
                if (string.IsNullOrEmpty(dto.FirstName) || string.IsNullOrEmpty(dto.LastName) || dto.Age == 0)
                {
                    continue;
                }

                User user = new User()
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Age = dto.Age
                };

                validUsers.Add(user);
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            return $"Successfully imported {validUsers.Count}";
        }




        //Problem 2
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var productsDtos = XmlHelper.DeserializeCollection<ImportProductsDTO>(inputXml, "Products");

            ICollection<Product> validProducts = new HashSet<Product>();
            foreach (var dto in productsDtos)
            {
                if (string.IsNullOrEmpty(dto.Name) || dto.SellerId == 0 || dto.BuyerId == 0 || dto.Price == 0)
                {
                    continue;
                }


                Product product = new Product()
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    SellerId = dto.SellerId,
                };

                product.BuyerId = dto.BuyerId ?? 0;

                validProducts.Add(product);
            }


            context.Products.AddRange(validProducts);
            context.SaveChanges();

            return $"Successfully imported {validProducts.Count}";
        }




        //Problem 3
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var categoriesDtos = XmlHelper.DeserializeCollection<ImportCategoriesDTO>(inputXml, "Categories");

            ICollection<Category> validCategories = new HashSet<Category>();

            foreach (var dto in categoriesDtos)
            {
                if(string.IsNullOrEmpty(dto.Name))
                {
                    continue;
                }

                Category category = new Category()
                {
                    Name = dto.Name
                };

                validCategories.Add(category);
            }

            context.Categories.AddRange(validCategories);
            context.SaveChanges();
            return $"Successfully imported {validCategories.Count}";
        }



        //Problem 4
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var categoriesProducts =
                XmlHelper.DeserializeCollection<ImportCategoriesProductsDTO>(inputXml, "CategoryProducts");

            var validCategoriesProducts = new HashSet<CategoryProduct>();

            foreach (var dto in categoriesProducts)
            {
                if (context.Products.Any(p => p.Id == dto.ProductId) &&
                    context.Categories.Any(c => c.Id == dto.CategoryId))
                {

                    CategoryProduct cp = new CategoryProduct()
                    {
                        CategoryId = dto.CategoryId,
                        ProductId = dto.ProductId
                    };

                    validCategoriesProducts.Add(cp);
                }

            }

            context.CategoryProducts.AddRange(validCategoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {validCategoriesProducts.Count}";
        }





        //Problem 5
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Take(10)
                .Select(p => new ProductsInRangeDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    BuyerName = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .ToArray();


            return XmlHelper.SerializeCollection(products, "Products");
        }




        //Problem 6
        public static string GetSoldProducts(ProductShopContext context)
        {
            SoldProductsDTO[] products = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Take(5)
                .Select(u => new SoldProductsDTO()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold.Select(p => new ProductDTO()
                        {
                            Name = p.Name,
                            Price = p.Price,
                        })
                        .ToArray()
                })
                .ToArray();

            return XmlHelper.SerializeCollection(products, "Users");
        }




        //Problem 7
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            CategoriesByProductsDTO[] categories = context.Categories
                .Select(c => new CategoriesByProductsDTO()
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            return XmlHelper.SerializeCollection(categories, "Categories");
        }





        //Problem 8
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            UserInfo[] users = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new UserInfo()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProducts()
                    {
                        Count = u.ProductsSold.Count,
                        Products = u.ProductsSold.Select(p => new SoldProductInfo()
                            {
                                Name = p.Name,
                                Price = p.Price
                            })
                            .OrderByDescending(p => p.Price)
                            .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            GetUserAndProductsDTO getUsers = new GetUserAndProductsDTO()
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = users
            };

            return XmlHelper.SerializeCollection(getUsers, "Users");
        }

    }
}