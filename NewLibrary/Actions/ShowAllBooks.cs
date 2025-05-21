using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
namespace NewLibrary.Actions
{
    public class ShowAllBooks
    {
        public void ShowAllBook()
        {
            Console.WriteLine("Список Литературы: ");

            var libraryAllBook = from book in Library.books
                                 orderby book ascending
                                 select book;

            foreach (var book in libraryAllBook)
                Console.WriteLine(book);


        }
        
        

        
    }
}
