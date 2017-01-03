using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISMOOPHierarchy.Classes
{
    public class Reader
    {
        protected string surname;
        protected string name;
        protected string book = "";
        protected bool black_list = false;
        public Reader(string surn, string n)
        {
            surname = surn;
            name = n;
        }
        public bool BlackList
        {
            get { return black_list; }
            set { black_list = value; }
        }
        public void RequestBook()
        {
            int c = 0;
            string[] books = File.ReadAllLines(@"books.txt");
            Console.Write("Введите название книги - ");
            string title = Console.ReadLine();
            foreach (string b in books)
            {
                if (title == b)
                {
                    c++;
                }
            }
            if (c > 0)
            {
                Console.WriteLine("Книга есть в наличии. Хотите ли получить ее?(д/н)");
                string z = Console.ReadLine();
                if (z == "l" || z == "д")
                {
                    Console.WriteLine("Заберите книгу '{0}' у библиотекаря", title);
                    book = title;
                }
                if (z == "y" || z == "н")
                {
                    Console.WriteLine("Выход!");
                    
                }
                
            }
            else
            {
                Console.WriteLine("Книги нет в наличии!");
            }

        }
        public string IsHaveBook
        {
            get { if (book != "" && book != " ")
                    return book;
                else
                    return "У даного читателя нет книг"; }
        }
    }
}
