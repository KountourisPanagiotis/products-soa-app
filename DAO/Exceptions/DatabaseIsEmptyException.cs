using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSOAApp.DAO.Exceptions
{
    internal class DatabaseIsEmptyException : Exception
    {
        public DatabaseIsEmptyException(string s)

            : base(s) { }
    }
}
