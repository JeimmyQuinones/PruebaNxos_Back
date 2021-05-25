using BackNexos.Domain;
using BackNexos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackNexos.Api.Application
{
    public class Service: IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public Author GetAuthor(int id)
        {
            try
            {
                return _repository.AuthorGetById(id);
            }catch(Exception e)
            {
                return null;
            }
            
        }
        public List<Author> GetAuthors()
        {
            try
            {
                return _repository.AuthorGetAll();
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public async Task<Author> AddAuthor(Author model)
        {
            try
            {
                return await _repository.AuthorAdd(model);
            }
            catch (Exception e)
            {
                return null;
            }  
        }
        public async Task<Author> SaveAuthor(Author model)
        {
            try
            {
                return await _repository.AuthorUpdate(model);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public async Task DeleteAuthor(int id)
        {
            try
            {
                await _repository.AuthorDeleteAsync(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Editorial GetEditorial(int id)
        {
            try
            {
                return _repository.EditorialGetById(id);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public List<Editorial> GetEditorials()
        {
            try
            {
                return _repository.EditorialGetAll();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public async Task<Editorial> AddEditorial(Editorial model)
        {
            try
            {
                return await _repository.EditorialAdd(model);
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<Editorial> SaveEditorial(Editorial model)
        {
            try
            {
                return await _repository.EditorialUpdate(model);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public async Task DeleteEditorial(int id)
        {
            await _repository.EditorialDeleteAsync(id);
        }

        public List<BookList> GetBooks()
        {
            try
            {
                return _repository.BookGetAllAuthorandEditorial();
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public Book GetBookById(int id)
        {
            try
            {
                return _repository.BookGetById(id);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public async Task<Book> AddBook(Book model)
        {
            try
            {
                return await _repository.BookAdd(model);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public async Task<Book> SaveBook(Book model)
        {
            try
            {
                return await _repository.BookUpdate(model);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public async Task DeleteBook(int id)
        {
            await _repository.BookDeleteAsync(id);
        }
        public List<Book> BookGetAllEditorialId(int id)
        {

            try
            {
                return _repository.BookGetAllEditorialId(id);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public List<BookList> BookSearch(string value)
        {
            try
            {
                var year = Convert.ToInt32(value);
                return (_repository.BookGetAllByYear(year));  
            }
            catch (System.FormatException e)
            {
                var autor = _repository.AuthorGetAllbyname(value);
                var editorial = _repository.EditorialGetvyName(value);
                var list = new List<BookList>();
                foreach (var item in autor)
                {
                    var library = _repository.BookGetAllByAuthor(item.AuthorId);
                    if (library.Count > 0)
                    {
                        foreach (var i in library)
                        {
                            list.Add(i);
                        }
                    }
                }
                foreach (var item in editorial)
                {
                    var library = _repository.BookGetAllByEditorailId(item.EditorialId);
                    if (library.Count > 0)
                    {
                        foreach (var i in library)
                        {
                            list.Add(i);
                        }
                    }
                }
                return( list.Distinct().ToList() );
            }catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
