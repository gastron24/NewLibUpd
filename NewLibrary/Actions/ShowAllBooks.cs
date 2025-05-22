using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Views;
namespace NewLibrary.Actions
{
    public class ShowAllBooks
    {
        ReturnBook returnBook = new ReturnBook();
        public void ShowAllBook()
        {
            Console.WriteLine("Список Литературы: ");

            var libraryAllBook = from book in Library.books                                 
                                 select book;            
            returnBook.ReturnAllBook();
            


        }
        
        

        
    }
}
