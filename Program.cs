using ProductsSOAApp.DAO;
using ProductsSOAApp.DTO;
using ProductsSOAApp.Service;

namespace ProductsSOAApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCodingFactoryLogo();

            // Create a mock DAO instance
            IProductsDAO dao = new ProductsDAOImpl();

            // Create an instance of the service implementation
            IProductsService productService = new ProductsServiceImpl(dao);

            // Add a product
            Console.WriteLine("\u001b[33m---ADDING A PRODUCT---\u001b[0m");
            ProductDTO productToAdd = new ProductDTO
            {
                Id = 1,
                Name = "Sample Product",
                Price = 9.99m,
                Description = "This is a sample product."
            };

            productService.AddProduct(productToAdd);
            Console.WriteLine($"Product: [{productService.GetProductById(productToAdd.Id)}] added successfully.");

            // Update the product
            Console.WriteLine("\u001b[33m---UPDATING A PRODUCT---\u001b[0m");
            ProductDTO productToUpdate = new ProductDTO
            {
                Id = 1,
                Name = "Updated Product",
                Price = 14.99m,
                Description = "This is an updated product."
            };

            productService.UpdateProduct(productToUpdate);
            Console.WriteLine($"Product [{productToUpdate}] updated successfully.");

            // Add multiple products
            Console.WriteLine("\u001b[33m---ADDING MULTIPLE PRODUCTS---\u001b[0m");
            for (int i = 2; i <= 7; i++)
            {
                ProductDTO newProductToAdd = new ProductDTO
                {
                    Id = i,
                    Name = $"Product {i}",
                    Price = i * 10.0m,
                    Description = $"This is product {i}."
                };

                productService.AddProduct(newProductToAdd);
                Console.WriteLine($"Product [{productService.GetProductById(newProductToAdd.Id)}] added successfully.");
            }

            // Get a product by ID
            Console.WriteLine("\u001b[33m---GETTING PRODUCT BY ID---\u001b[0m");
            int productId = 4;
            ProductDTO retrievedProduct = productService.GetProductById(productId);
            Console.WriteLine($"Retrieved Product with ID {productId} and it's details are: {retrievedProduct}");

            // Get all products
            Console.WriteLine("\u001b[33m---GETTING ALL PRODUCTS---\u001b[0m");
            Dictionary<int, ProductDTO> allProducts = productService.GetAllProducts();
            Console.WriteLine("Retrieving All Products:");
            foreach (var entry in allProducts)
            {
                Console.WriteLine($"ID: {entry.Key}, " +
                    $"Name: {entry.Value.Name}, Value: {entry.Value.Price}, Description: {entry.Value.Description}");
            }

            // Delete the product
            Console.WriteLine("\u001b[33m---DELETING A PRODUCT---\u001b[0m");
            productService.DeleteProduct(productId);
            Console.WriteLine($"Deleting Product with id {productId} deleted successfully.");

            // Get all products
            Console.WriteLine("\u001b[33m---GETTING ALL PRODUCTS AFTER DELETION---\u001b[0m");
            Console.WriteLine("Retrieving All Products:");
            Dictionary<int, ProductDTO> allProductsAfterDel = productService.GetAllProducts();
            foreach (var entry in allProductsAfterDel)
            {
                Console.WriteLine($"ID: {entry.Key}, " +
                    $"Name: {entry.Value.Name}, Value: {entry.Value.Price}, Description: {entry.Value.Description}");
            }
        }

        public static void PrintCodingFactoryLogo()
        {
            string asciiArt = "\u001b[33m" + @"
   _____ ____  _____ _____ _   _  _____   ______      _____ _______ ____  _______     __
  / ____/ __ \|  __ \_   _| \ | |/ ____| |  ____/\   / ____|__   __/ __ \|  __ \ \   / /
 | |   | |  | | |  | || | |  \| | |  __  | |__ /  \ | |       | | | |  | | |__) \ \_/ / 
 | |   | |  | | |  | || | | . ` | | |_ | |  __/ /\ \| |       | | | |  | |  _  / \   /  
 | |___| |__| | |__| || |_| |\  | |__| | | | / ____ \ |____   | | | |__| | | \ \  | |   
  \_____\____/|_____/_____|_|_\_|\_____|_|_|/_/____\_\_____|  |_|  \____/|_|  \_\ |_|   
   |  __ \|  __ \ / __ \|  __ \| |  | |/ ____|__   __/ ____|                            
   | |__) | |__) | |  | | |  | | |  | | |       | | | (___                              
   |  ___/|  _  /| |  | | |  | | |  | | |       | |  \___ \                             
   | |    | | \ \| |__| | |__| | |__| | |____   | |  ____) |                            
   |_|    |_|  \_\\____/|_____/ \____/ \_____|  |_| |_____/                             
                                                                                        
                                                                                        " + "\u001b[0m";
            Console.WriteLine(asciiArt);

        }
    }
}