using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DAO.Exceptions
{
    internal class ProductAlreadyExistsException : Exception
    {
        public ProductAlreadyExistsException(string s)

    : base(s) { }
    }
}
