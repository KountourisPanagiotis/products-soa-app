using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }

        public Product() { }

        public Product(int id, string? name, decimal? price, string? description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Product otherProduct = (Product)obj;
            return Id == otherProduct.Id
                && Name == otherProduct.Name
                && Price == otherProduct.Price
                && Description == otherProduct.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Price, Description);
        }

        public override string? ToString()
        {
            return $"Id= {Id}, Name= {Name}, Price= {Price}, Description= {Description}";
        }
    }
}
