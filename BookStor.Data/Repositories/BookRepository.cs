using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStor.Data.Interfaces;
using BookSwap.Models;

namespace BookStor.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "The Girl on the Train", Author = "Haukins ,Paula", PublicationYear = 2016, CallNumber = "F DEFRT" },
            new Book { Id = 2, Title = "After You", Author = "Haukins ,Shukla", PublicationYear = 2017, CallNumber = "F DEFkT" },
            new Book { Id = 3, Title = "Me Before You", Author = "Moyes,Jojo", PublicationYear = 2016, CallNumber = "F HEFRT" },
            new Book { Id = 4, Title = "Alexander Hamilton", Author = "Chernow ,Ron", PublicationYear = 2018, CallNumber = "F BEFRT" },
            new Book { Id = 5, Title = "Before the Fall", Author = "Hawley ,Noah", PublicationYear = 2015, CallNumber = "F IEFRT" }
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);

        }
    }
}
