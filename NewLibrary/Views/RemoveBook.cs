using NewLibrary.Actions;
using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary.Views
{
    class RemoveBook
    {
        

        public void ReMoveBook(int Id)
        {
            var bookToremove = Library.books.FirstOrDefault(b => b.Id == Id);

            if(bookToremove != null)
            {
                Library.books.Remove(bookToremove);
                Console.WriteLine($"Книга с номером {Id}");
            }
            else
            {
                Console.WriteLine($"Книга с номером {Id} не найденна");
            }
        }

    }
}
