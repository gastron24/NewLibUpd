using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
namespace NewLibrary
{
    class UserMenu
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
                Console.WriteLine("4 - Выход из программы");

                int inputChoice = int.Parse(Console.ReadLine());

                switch (inputChoice)
                {
                    case 1:

                        library.GetInfoBook();
                        break;
                    case 2:
                        library.ShowAllBook();                                                             ///ЗАТЫК library.ShowAllBook() - значение отличное.
                        break;                                                                           ///по этому через затычку new(дабы дописать :(   )
                    case 3:
                        library.DeleteBook();
                        break;
                    case 4:
                        Environment.Exit(0);                                                              /// исправил вынес создание library за класс.                    
                        break;
                }
                
            }
               

        }
    }
}
