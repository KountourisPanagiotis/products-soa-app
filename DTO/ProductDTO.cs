using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DTO
{
    internal class ProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }

        public ProductDTO() { }
        public ProductDTO(int id, string? name, decimal? price, string? description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public override string? ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Description: {Description}";
        }
    }
}
