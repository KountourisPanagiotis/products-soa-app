using ProductsSOAApp.DAO.Exceptions;
using ProductsSOAApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DAO
{
    internal class ProductsDAOImpl : IProductsDAO
    {
        private static readonly Dictionary<int, Product> products = new();
        public static Dictionary<int, Product> Products { get { return new Dictionary<int, Product>(products); } }

        
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ErrorInAddingProductException("Product cannot be null.");
            }

            if (products.ContainsKey(product.Id))
            {
                throw new ProductAlreadyExistsException($"Product with id {product.Id} already exists");
            }

            products[product.Id] = product;
        }

        public void DeleteProduct(int id)
        {
            if (!products.ContainsKey(id))
            {
                throw new ProductIdNotFoundException($"Product with id=[{id}] does not exist in the database");
            }
            products.Remove(id);
        }

        public Dictionary<int, Product> GetAllProducts()
        {
            return new Dictionary<int, Product>(products);
        }

        public Product GetProductById(int id)
        {
            if (!products.ContainsKey(id))
            {
                throw new ProductIdNotFoundException($"Product with id=[{id}] does not exist in the database");
            }

            return products[id];
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ErrorInUpdatingProductException("Product cannot be null.");
            }

            if (!products.ContainsKey(product.Id))
            {
                throw new ProductIdNotFoundException($"Product with id=[{product.Id}] does not exist in the database");
            }

            products[product.Id] = product;
        }
    }
}
