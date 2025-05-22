using NewLibrary.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewLibrary.Models
{
    class InputMainMenu
    {        
       
       
        public void InputMenu()
        {
            Library library = new();
           
            while(true)
            {
                Console.WriteLine("||MENU||");
                Console.WriteLine("1 - Добавить книгу.");
                Console.WriteLine("2 - Список книг.");
                Console.WriteLine("3 - Удаление книги.");
                Console.WriteLine("4 - Поиск по книгам");
                Console.WriteLine("5 - Редактировать Книгу");
                Console.WriteLine("6 - Выход");
                int inputChoice = int.Parse(Console.ReadLine());

                switch (inputChoice)
                {
                    case 1:

                        GetInfoBooks CreateBook = new();
                        CreateBook.GetInfoBook();
                        break;
                    case 2:
                        ShowAllBooks showAllBooks = new();
                        showAllBooks.ShowAllBook();                                                                            
                        break;                                                                           
                    case 3:
                        Deleatebooks deleatebooks = new();
                        deleatebooks.DeleteBook();
                        break;
                    case 4:
                        SearchBook searchBook = new();
                        searchBook.Search();
                        break;
                    case 5:

                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                
            }
               

        }
    }
}
