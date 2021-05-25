using BackNexos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackNexos.Api.Application
{
    public interface IService
    {
        List<Author> GetAuthors();
        Author GetAuthor(int id);
        Task<Author> AddAuthor(Author model);
        Task<Author> SaveAuthor(Author model);
        Task DeleteAuthor(int id);

        List<Editorial> GetEditorials();
        Editorial GetEditorial(int id);
        Task<Editorial> AddEditorial(Editorial model);
        Task<Editorial> SaveEditorial(Editorial model);
        Task DeleteEditorial(int id);

        List<BookList> GetBooks();
        List<Book> BookGetAllEditorialId(int id);
        Book GetBookById(int id);
        Task<Book> AddBook(Book model);
        Task<Book> SaveBook(Book model);
        Task DeleteBook(int id);
        List<BookList> BookSearch(string value);
    }
}
