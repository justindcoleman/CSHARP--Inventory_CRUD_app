﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week7WeekendHomework.Models;

namespace Week7WeekendHomework.Controllers
{
    public class ValuesController : ApiController
    {
        static readonly ProductRepository repository = new ProductRepository();

        // GET api/values
        public IEnumerable<Product> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if (item == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return item;
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

        // POST api/values
        public Product PostProduct(Product item)
        {
            item = repository.Add(item);
            return item;
        }

        // PUT api/values/5
        public void PutProduct(int id, Product item)
        {
            item.Id = id;
            if (!repository.Update(item))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/values/5
        public void DeleteProduct(int id)
        {
            Product item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }
    }
}
