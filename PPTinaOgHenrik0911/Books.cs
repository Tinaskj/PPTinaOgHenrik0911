using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTinaOgHenrik0911
{
    internal class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public bool IsAvailable { get; set; }


        public Books(int bookId, string title, string author, int pages, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Pages = pages;
            IsAvailable = isAvailable;
        }

        public void ShowListOfBooks()
        {
            Console.WriteLine($"BookId: {BookId}\nTitle: {Title}\nAuthor: {Author}\nPages: {Pages}\nIs the book available: \n");
        }

        //public bool IsBookAvaiable()
        //{

        //}
    }
}
