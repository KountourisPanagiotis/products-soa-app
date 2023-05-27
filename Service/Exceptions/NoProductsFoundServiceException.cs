using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.Service.Exceptions
{
    internal class NoProductsFoundServiceException : Exception
    {
        public NoProductsFoundServiceException(string s)
        : base(s) { }
    }
}
