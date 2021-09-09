using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStor.Data.Interfaces;
using BookStor.Data.Repositories;
using BookSwap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookSwap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book { Id = 1, Title = "The Girl on the Train", Author = "Haukins ,Paula", PublicationYear = 2016, CallNumber = "F DEFRT" },
        //    new Book { Id = 2, Title = "After You", Author = "Haukins ,Shukla", PublicationYear = 2017, CallNumber = "F DEFkT" },
        //    new Book { Id = 3, Title = "Me Before You", Author = "Moyes,Jojo", PublicationYear = 2016, CallNumber = "F HEFRT" },
        //    new Book { Id = 4, Title = "Alexander Hamilton", Author = "Chernow ,Ron", PublicationYear = 2018, CallNumber = "F BEFRT" },
        //    new Book { Id = 5, Title = "Before the Fall", Author = "Hawley ,Noah", PublicationYear = 2015, CallNumber = "F IEFRT" }
        //};
        private IBookRepository books = new BookRepository();
   
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            // var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);
            


            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}












        

