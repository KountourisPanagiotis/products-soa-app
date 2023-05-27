using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DAO.Exceptions
{
    internal class ProductIdNotFoundException : Exception
    {
        public ProductIdNotFoundException(string s) : base(s) { }
    }
}
