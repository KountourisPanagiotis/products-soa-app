using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Service.Exceptions
{
    internal class ProductDoesNotExistServiceException : Exception
    {
        public ProductDoesNotExistServiceException(string s)
        : base(s) { }
    }
}
