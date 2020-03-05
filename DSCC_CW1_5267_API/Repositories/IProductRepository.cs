using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSCC_CW1_5267_API.Models;

namespace DSCC_CW1_5267_API.Repositories
{
   public interface IProductRepository
    {

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);

        Product GetProductById(int Id);

        IEnumerable<Product> GetProducts();
    }
}
