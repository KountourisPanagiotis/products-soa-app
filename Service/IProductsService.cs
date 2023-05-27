using ProductsSOAApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Service
{
    internal interface IProductsService
    {
        /// <summary>
        /// Adds a new <c>Product</c>.
        /// </summary>
        /// <param name="product">The <c>ProductDTO</c> object to add.</param>
        void AddProduct(ProductDTO product);

        /// <summary>
        /// Updates an existing <c>Product</c>.
        /// </summary>
        /// <param name="product">The <c>ProductDTO</c> object to update.</param>
        void UpdateProduct(ProductDTO product);

        /// <summary>
        /// Deletes a <c>Product</c> based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the <c>product</c> to delete.</param>
        void DeleteProduct(int id);

        /// <summary>
        /// Retrieves a <c>Product</c> based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the <c>Product</c> to retrieve.</param>
        /// <returns>The <c>ProductDTO</c> object corresponding to the provided ID.</returns>
        ProductDTO GetProductById(int id);

        /// <summary>
        /// Retrieves all products from the service.
        /// </summary>
        /// <returns>A dictionary containing product IDs and corresponding ProductDTO objects.</returns>
        Dictionary<int, ProductDTO> GetAllProducts();
    }
}
