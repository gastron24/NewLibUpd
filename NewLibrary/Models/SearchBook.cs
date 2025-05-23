using NewLibrary.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary;
namespace NewLibrary.Models
{
    class SearchBook
    {



        public void Search()
        {
            Console.WriteLine("Выберите тип поиска: ");
            Console.WriteLine("1 - Поиск по Названию");
            Console.WriteLine("2 - Поиск по автору");
            Console.WriteLine("3 - Поиск по году издания");

            int inputSearchType = int.Parse(Console.ReadLine()); 

            switch(inputSearchType)
            {
                case 1:
                    SearchNameBooks serchForName = new();
                    serchForName.Search();
                    break;
                case 2:
                    SearchAuthorBooks searchForAuthor = new();
                    searchForAuthor.Search();
                    break;
                case 3:
                    SearchAgeBooks searchForAge = new();
                    searchForAge.SearchAgeBook();
                    break;
            }

            
            
        }
    }
}
