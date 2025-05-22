using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Models;
namespace NewLibrary.Views
{
    class ReturnBook
    {
        

        public void ReturnAllBook()
        {
            foreach (var book in Library.books)
                Console.WriteLine(book);

        }

    }
}
