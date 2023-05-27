using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Service.Exceptions
{
    internal class ProductAlreadyExistsServiceException : Exception
    {
        public ProductAlreadyExistsServiceException(string s)

        : base(s) { }
    }
}
