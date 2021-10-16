using CRMWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMWeb.Repository
{
    public class BookRepository
    {

        public List<Models.BookModel> getAllBooks()
        {
            return DataSource();


        }

        public BookModel getBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchBooks(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel{Id = 1, Title = "MVC" , Author = "Asad" },
                new BookModel{Id = 2, Title = "Java" , Author = "Asad" },
                new BookModel{Id = 3, Title = "C#" , Author = "Khan" },
                new BookModel{Id = 4, Title = "ASP.NET" , Author = "Asd" },
                new BookModel{Id = 5, Title = "DSA" , Author = "Baba" }
            };
        }
    }
}
