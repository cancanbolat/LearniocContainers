using System.Collections.Generic;
using iocContainers.Models;

namespace iocContainers.Repository
{
    public interface IProduct
    {
         IEnumerable<Product> GetAllProduct();
         Product GetProductById(int id);
         Product AddProduct(Product item);
         bool UpdateProduct(Product item);
         bool DeleteProduct(int id);
    }
}