using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Models;
namespace NewLibrary.Actions
{
    class SearchAuthorBooks
    {

        public void Search()
        {
            Console.Clear();
            Console.WriteLine("Введите Имя автора для поиска:");

            string author = Console.ReadLine();
            var results = Library.books
               .Where(b => b.Author != null &&
                           b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0)
               .ToList();

            SnowResults(results);


            void SnowResults(List<Book> results)
            {
                Console.Clear();
                if(results.Count == 0)
                {
                    Console.WriteLine("Книга не найденна");
                }
                else
                {
                    Console.WriteLine("Найденные книги (По Автору)");
                    foreach(var book in results)
                    {
                        Console.WriteLine(book);
                    }
                }
            }

        }
    }
}
