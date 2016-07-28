using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7WeekendHomework.Models
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetInt(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }
}
