using NewLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace NewLibrary.Actions
{
    class GetInfoBooks
    {
        public void GetInfoBook()
        {
            int _lastId = 0;
            try
            {
                Console.Clear();

                Console.WriteLine("Название книги?");
                string name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Автор? ");
                string author = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Год? ");
                int age = int.Parse(Console.ReadLine());
                Console.Clear();

                Book newBook = new Book(name, age, author, _lastId);
                Library.books.Add(newBook);
               
                Console.WriteLine($"Добавлена книга {name} под номером {_lastId}");
                _lastId++;

            }
            catch
            {
                Console.WriteLine("Попробуйте снова. Некорректный Ввод");
            }
            Console.Clear();
        }
    }
}
