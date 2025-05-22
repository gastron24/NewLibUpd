using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Models;
namespace NewLibrary.Actions
{
    class SearchNameBook
    {
        public void Search()
        {
            Console.Clear();
            Console.WriteLine("Введите название для поиска:");
            string nameForSearch = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nameForSearch))
            {
                Console.WriteLine("Вы не ввели название.");
                return;
            }
           
            var results = Library.books
                .Where(b => b.Name != null && b.Name.IndexOf(nameForSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("Книги с таким названием не найдены.");
            }
            else
            {
                Console.WriteLine("Найденные книги:");
                foreach (var book in results)
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }








    }
}
