using ProductsSOAApp.DAO;
using ProductsSOAApp.DTO;
using ProductsSOAApp.Model;
using ProductsSOAApp.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Service
{
    internal class ProductsServiceImpl : IProductsService
    {
        readonly IProductsDAO dao;

        public ProductsServiceImpl(IProductsDAO dao)
        {
            this.dao = dao;
        }

        public void AddProduct(ProductDTO productToInsert)
        {
            if (productToInsert == null)
            {
                throw new ProductCannotBeNullServiceException("Product cannot be null.");
            }

            if (dao.GetAllProducts().ContainsKey(productToInsert.Id))
            {
                throw new ProductAlreadyExistsServiceException($"Product with ID {productToInsert.Id} already exist.");
            }

                Product product = MapProduct(productToInsert);
                dao.AddProduct(product);
        }

        public void UpdateProduct(ProductDTO productToUpdate)
        {
            if (productToUpdate == null)
            {
                throw new ProductCannotBeNullServiceException("Product cannot be null.");
                
            }

            if (!dao.GetAllProducts().ContainsKey(productToUpdate.Id))
            {
                throw new ProductDoesNotExistServiceException($"Product with ID {productToUpdate.Id} does not exist.");
            }
            Product product = MapProduct(productToUpdate);
            dao.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            if (!dao.GetAllProducts().ContainsKey(id))
            {
                throw new ProductDoesNotExistServiceException($"Product with ID {id} does not exist.");
            }

            dao.DeleteProduct(id);
        }

        public ProductDTO GetProductById(int id)
        {
            if (!dao.GetAllProducts().ContainsKey(id))
            {
                throw new ProductDoesNotExistServiceException($"Product with ID {id} does not exist.");
            }

            Product product = dao.GetProductById(id);

            ProductDTO productDTO = new ProductDTO();
            productDTO.Id = product.Id;
            productDTO.Name = product.Name;
            productDTO.Price = product.Price;
            productDTO.Description = product.Description;

            return productDTO;
        }

        public Dictionary<int, ProductDTO> GetAllProducts()
        {
            Dictionary<int, ProductDTO> products = new Dictionary<int, ProductDTO>();

            Dictionary<int, Product> allProducts = dao.GetAllProducts();

            if (allProducts == null || allProducts.Count == 0)
            {
                throw new NoProductsFoundServiceException("No products found.");
            }

            foreach (var entry in allProducts)
            {
                int productId = entry.Key;
                Product product = entry.Value;

                ProductDTO productDTO = MapProductDTO(product);
                products.Add(productId, productDTO);
            }

            return products;
        }

        private Product MapProduct(ProductDTO productDTO)
        {
            return new Product(productDTO.Id, productDTO.Name, productDTO.Price, productDTO.Description);
        }

        private ProductDTO MapProductDTO(Product product)
        {
            return new ProductDTO(product.Id, product.Name, product.Price, product.Description);
        }
    }
}
