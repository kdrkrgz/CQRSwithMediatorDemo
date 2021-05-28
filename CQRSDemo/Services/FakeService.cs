using CQRSDemo.CQRS.Queries.Response;
using CQRSDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Services
{
    public class FakeService
    {
        public List<Book> Books {get;set; }
        public FakeService()
        {
            Books = GetAllBooks();
        }

        public static List<Book> GetAllBooks()
        {
            var books = new List<Book>
            {
                new Book{ BookId= Guid.NewGuid(), LibraryId = 1, Name = "Harry Petersburg", AuthorName = "Dostoyevski", Quantity = 50 },
                new Book{ BookId= Guid.NewGuid(), LibraryId = 1, Name = "Exception", AuthorName = "Fartin Mowler", Quantity = 70 },
                new Book{ BookId= Guid.NewGuid(), LibraryId = 1, Name = "Anna Karenina 1", AuthorName = "Tolstoy", Quantity = 50 },
                new Book{ BookId= Guid.NewGuid(), LibraryId = 1, Name = "Anna Karenina 2", AuthorName = "Tolstoy", Quantity = 50 },
                new Book{ BookId= Guid.NewGuid(), LibraryId = 1, Name = "Anna Karenina 3", AuthorName = "Tolstoy", Quantity = 50 }
            };
            return books;
        }

        public void Delete(Guid bookId)
        {
            var book = Books.FirstOrDefault(x => x.BookId == bookId);
            if (book != null)
                Books.Remove(book);
        }

        public Book GetByName(string name)
        {
            return Books.FirstOrDefault(n => n.Name.ToUpper().Contains(name.ToUpper()));
        }

        public void Add(Book book)
        {
            Books.Add(book);
        }
    }
}
