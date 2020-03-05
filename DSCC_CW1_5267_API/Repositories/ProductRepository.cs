using DSCC_CW1_5267_API.DataBaseContext;
using DSCC_CW1_5267_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DSCC_CW1_5267_API.Repositories
{
    public class ProductRepository : IProductRepository
    {
            private readonly Context _dbContext;

            public ProductRepository(Context dbContext)
            {
                _dbContext = dbContext;
            }

            public void DeleteProduct(int productId)
            {
                var product = _dbContext.Products.Find(productId);
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }

            public Product GetProductById(int productId)
            {
                var product = _dbContext.Products.Find(productId);
                return product;

            }

            public IEnumerable<Product> GetProducts()
            {
                return _dbContext.Products.ToList();
            }

            public void InsertProduct(Product product)
            {
                _dbContext.Add(product);
                _dbContext.SaveChanges();
            }

            public void UpdateProduct(Product product)
            {
                _dbContext.Entry(product).State =
               Microsoft.EntityFrameworkCore.EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }
    }

