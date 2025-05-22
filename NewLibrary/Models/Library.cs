using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace NewLibrary.Models
{
    class Library
    {
        public static Collection<Book> books = new();

        private static int _lastId = 1;
       public static int ReturnUniqueId()
        {
           return _lastId++;
        }














    }
}
