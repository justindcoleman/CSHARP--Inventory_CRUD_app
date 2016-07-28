using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week7WeekendHomework.Models
{
    public class ProductRepository
    {
        List<Product> products = new List<Product>();
        private int _nextId = 1;
        public ProductRepository()
        {
            new Product { Id = 1, Name = "Tomato", Category = "Groceries", Price = 1.5M, inStock = true };
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M, inStock = true };
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M, inStock = false };
            new Product { Id = 4, Name = "Dishwaster", Category = "Utilities", Price = 599.99M, inStock = false };
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            item.Id = _nextId++;
            products.Add(item);
            return item;
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
                throw new ArgumentNullException();

            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;

            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}