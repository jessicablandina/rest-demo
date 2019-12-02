using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rest_demo.Source.Models;

namespace rest_demo.Controllers
{
    [ApiController]
    [Route("api/library")]
    public class LibraryController : ControllerBase
    {
        private readonly ILogger<LibraryController> _logger;
        List<Author> authorsList = new List<Author>();
        List<Book> booksList = new List<Book>();    

        public LibraryController(ILogger<LibraryController> logger)
        {
            _logger = logger;
            Seed();
        }

        [HttpGet]
        public Book[] Get()
        {
            return booksList.ToArray();
        }

        [HttpGet]
        [Route("book/{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Book GetBook(int Id)
        {
            return booksList.Find(book => book.Id == Id);
        }

        [HttpGet]
        [Route("author/{Id:int}")]
        public Author GetAuthor(int Id)
        {
            return authorsList.Find(author => author.Id == Id);
        }

        public void Seed()
        {
            authorsList.Add(new Author(01, "Jess Blandina"));
            authorsList.Add(new Author(02, "Blan"));
            authorsList.Add(new Author(03, "JB"));

            booksList.Add(new Book(01, "Some Title", 1, 1964));
            booksList.Add(new Book(02, "A Second title", 2, 1884));
            booksList.Add(new Book(03, "Third book", 3, 1984));
        }
    }
}
