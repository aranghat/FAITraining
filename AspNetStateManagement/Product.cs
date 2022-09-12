using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetStateManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class ProductRepository
    {
        static List<Product> products = new List<Product>();
        static ProductRepository()
        {
            products.Add(new Product { Id = 1001, Name = "Coffee" });
            products.Add(new Product { Id = 1002, Name = "Tea" });
            products.Add(new Product { Id = 1003, Name = "Juice" });
            products.Add(new Product { Id = 1004, Name = "Green Tea" });
        }

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static Product FindById(int id)
        {
            return products.FirstOrDefault(d => d.Id == id);
        }

    }

}