using System;
namespace booksInventory
{
    public class Book
    {
        public int id { get; private set;  }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int id, string Title, string Author)
        {
            this.id = id;
            this.Title = Title;
            this.Author = Author;
        }
    }
}
