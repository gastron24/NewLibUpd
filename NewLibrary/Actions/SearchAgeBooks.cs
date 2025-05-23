using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
namespace NewLibrary.Actions
{
    class SearchAgeBooks
    {
        
        public void SearchAgeBook()
        {
            Console.WriteLine("Введите год издания для поиска:");
            string ageForSearch = Console.ReadLine();

            if (!int.TryParse(ageForSearch, out int year))
            {
                Console.WriteLine("Год должен быть числом.");
                return;
            }
            var results = Library.books
                         .Where(b => b.Age == year)
                         .ToList();
            ShowResults(results);

            void ShowResults(List<Book> results)
            {
                Console.Clear();
                if (results.Count == 0)
                    Console.WriteLine("Книги не найдены");
                else
                {
                    Console.WriteLine("Найденные книги по году: ");
                    foreach(var book in results)
                        Console.WriteLine(book);
                }
            }
            


        }
    }
}
