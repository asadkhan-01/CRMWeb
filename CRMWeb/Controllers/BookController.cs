using CRMWeb.Models;
using CRMWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMWeb.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult getAllBooks()
        {
            var view =  _bookRepository.getAllBooks();
            return View(view);
        }

        public BookModel getBook(int id)
        {
            return _bookRepository.getBookById(id);
        }

        public List<BookModel> searchBooks(string title, string author)
        {
            return _bookRepository.searchBooks(title, author);
        }

    }
}
