using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Models;
namespace NewLibrary.Actions
{
    class Deleatebooks
    {
        public void DeleteBook()
        {
            try
            {
                Console.WriteLine("Выберите Id книги для удаления. ");
                var theDealaterId = int.Parse(Console.ReadLine());

                foreach (var book in Library.books)
                {
                    if (Library.ReturnUniqueId() == theDealaterId)
                    {
                       Library.books.Remove(book);
                        Console.WriteLine($"Книга с номером {theDealaterId} удаленна");
                        return;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод Id");
            }
            Console.Clear();
        }
    }
} 
