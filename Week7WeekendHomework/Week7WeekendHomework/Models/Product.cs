using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week7WeekendHomework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool inStock { get; set; }
    }
}