using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
using NewLibrary.Models;
using NewLibrary.Views;
namespace NewLibrary.Actions
{
    class Deleatebooks
    {
        public void DeleteBook()
        {
            try
            {
                ShowAllBooks viewLibraryBook = new();
                viewLibraryBook.ShowAllBook();
                Console.Clear();
                Console.WriteLine("Введите Id книги для Удаления");
               int theDeleter =  int.Parse(Console.ReadLine());

                RemoveBook removeBook = new();
                removeBook.ReMoveBook(theDeleter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка некорректный ввод");
                Console.WriteLine(ex);
            }
            Console.Clear();   

            
        }
    }
} 
