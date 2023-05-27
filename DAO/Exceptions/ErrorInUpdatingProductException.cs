using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DAO.Exceptions
{
    internal class ErrorInUpdatingProductException : Exception
    {
        public ErrorInUpdatingProductException(string s)
      : base(s) { }
    }
}
