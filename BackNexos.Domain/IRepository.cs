using BackNexos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackNexos.Domain
{
    public interface IRepository
    {
        #region Author
        Task<Author> AuthorAdd(Author element);
        Task AuthorDeleteAsync(int id);
        Task<Author> AuthorUpdate(Author element);
        List<Author> AuthorGetAll();
        Author AuthorGetById(int id);

        #endregion

        #region Editorial
        Task<Editorial> EditorialAdd(Editorial element);
        Task EditorialDeleteAsync(int id);
        Task<Editorial> EditorialUpdate(Editorial element);
        List<Editorial> EditorialGetAll();
        Editorial EditorialGetById(int id);

        #endregion

        #region Book
        Task<Book> BookAdd(Book element);
        Task BookDeleteAsync(int id);
        Task<Book> BookUpdate(Book element);
        List<Book> BookGetAll();
        Book BookGetById(int id);
        List<BookList> BookGetAllAuthorandEditorial();
        List<Book> BookGetAllEditorialId(int id);
        List<BookList> BookGetAllByYear(int id);
        List<BookList> BookGetAllByEditorailId(int id);
        List<BookList> BookGetAllByAuthor(int id);
        List<Editorial> EditorialGetvyName(string value);
        List<Author> AuthorGetAllbyname(string value);

        #endregion
    }
}
