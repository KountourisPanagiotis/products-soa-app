using ProductsSOAApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductsSOAApp.DAO
{
    public interface IProductsDAO
    {
        /// <summary>
        /// Retrieves all products from the data source.
        /// </summary>
        /// <returns>A dictionary containing product IDs and corresponding Product objects.</returns>
        Dictionary<int, Product> GetAllProducts();

        /// <summary>
        /// Retrieves a product from the data source based on the provided ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The ID of the product to retrieve.</returns>
        Product GetProductById(int id);

        /// <summary>
        /// Adds a new product to the data source.
        /// </summary>
        /// <param name="product">The Product object to add.</param>
        void AddProduct(Product product);

        /// <summary>
        /// Updates an existing product in the data source.
        /// </summary>
        /// <param name="product">The Product object to update.</param>
        void UpdateProduct(Product product);

        /// <summary>
        /// Deletes a product from the data source based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        void DeleteProduct(int id);
    }
}
