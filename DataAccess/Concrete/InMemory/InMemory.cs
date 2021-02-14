using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemory : IProductDal
    {
        List<Product> _products;
        public InMemory()
        {
            _products = new List<Product>
            {

               new Product { Id = 1, BrandId = 1, ProductName = "Opel", ModelYear = 1997, DailyPrice = 150, Description =".." },
               new Product { Id = 2, BrandId = 2, ProductName = "Ford", ModelYear = 1997, DailyPrice = 250, Description ="..." },
               new Product { Id = 3, BrandId = 3, ProductName = "Hundai", ModelYear = 1997, DailyPrice = 350, Description ="...." },
               new Product { Id = 4, BrandId = 4, ProductName = "TOGG", ModelYear = 2022, DailyPrice = 750, Description ="....." },

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllById(int BrandId)
        {
            return _products.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderilen ürün id'sine sahip listedeki ürünü bulmamızı sağlar.
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }

}
