using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
namespace NewLibrary
{
    class Library
    {
        private Collection<Book> books = new();
        private int _lastId { get; set; }

        public void GetInfoBook()
        {
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
                books.Add(newBook);
                

                Console.WriteLine($"Добавлена книга {name} под номером {_lastId}");
                _lastId++;
            }
            catch
            {
                Console.WriteLine("Попробуйте снова. Некорректный Ввод");
            }
            Console.Clear();
        }
        public void DeleteBook()
        {
            try
            {
                ShowAllBook();
                Console.WriteLine("Выберите Id книги для удаления. ");
                var theDealaterId = int.Parse(Console.ReadLine());

                foreach (var book in books)
                {
                    if (book.Id == theDealaterId)
                    {
                        books.Remove(book);
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

        public IEnumerable<Book> ShowAllBook()
        {
          if(books == null)
            {
              Console.WriteLine("Список пуст");
            }
           
            Console.WriteLine("|Список вашей Литературы|");
                foreach(Book book in books)
                {
                 Console.WriteLine(book);
                }
         return books;
            
        }
        

        




    }
}
