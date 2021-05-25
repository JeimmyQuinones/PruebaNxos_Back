using BackNexos.Domain;
using BackNexos.Domain.Models;
using BackNexos.Infrastructure.Entities;
using BackNexos.Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Repositories
{
    public class Repository: IRepository
    {
        private readonly IDBContext _DBContext;
        public Repository (IDBContext DBContext)
        {
            _DBContext = DBContext;
        }
        #region Author
        public List<Author> AuthorGetAll()
        {
            try
            {
                var data = _DBContext.author.ToList();
                var list = new List<Author>();
                foreach (var item in data)
                {
                    list.Add(AuthorMapper.MapperAuthorEntityToAuthor(item));

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Author> AuthorGetAllbyname(string value)
        {
            try
            {
                var data = _DBContext.author.Where(x => x.Name.Contains(value)).ToList();
                var list = new List<Author>();
                foreach (var item in data)
                {
                    list.Add(AuthorMapper.MapperAuthorEntityToAuthor(item));

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Author AuthorGetById( int id)
        {
            try
            {
                var data = AuthorMapper.MapperAuthorEntityToAuthor(_DBContext.author.FirstOrDefault(x => x.AuthorId == id));
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       

        public async Task<Author> AuthorAdd (Author element)
        {
            try
            {
                var model = AuthorMapper.MapperAuthorToAuthorEntity(element);
                await _DBContext.author.AddAsync(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }catch(Exception e)
            {
                throw e;
            }
        }
        public async Task AuthorDeleteAsync (int id)
        {
            try
            {
                var data = _DBContext.author.FirstOrDefault(x => x.AuthorId == id);
                if (data != null)
                {
                     _DBContext.author.Remove(data);
                    await _DBContext.SaveChangesAsync();
                }
            }catch(Exception e)
            {
                throw e;
            }
            
        }
        public async Task<Author> AuthorUpdate(Author element)
        {
            try
            {
                var model = AuthorMapper.MapperAuthorToAuthorEntity(element);
                _DBContext.author.Update(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion

        #region Editorial
        public List<Editorial> EditorialGetAll()
        {
            try
            {
                var data = _DBContext.editorial.ToList();
                var list = new List<Editorial>();
                foreach (var item in data)
                {
                    list.Add(EditorialMapper.MapperEditorialEntityToEditorial(item));

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Editorial> EditorialGetvyName(string value)
        {
            try
            {
                var data = _DBContext.editorial.Where(x => x.Name.Contains(value)).ToList();
                var list = new List<Editorial>();
                foreach (var item in data)
                {
                    list.Add(EditorialMapper.MapperEditorialEntityToEditorial(item));

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Editorial EditorialGetById(int id)
        {
            try
            {
                var data = EditorialMapper.MapperEditorialEntityToEditorial(_DBContext.editorial.FirstOrDefault(x => x.EditorialId == id));
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Editorial> EditorialAdd(Editorial element)
        {
            try
            {
                var model = EditorialMapper.MapperEditorialToEditorialEntity(element);
                await _DBContext.editorial.AddAsync(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task EditorialDeleteAsync(int id)
        {
            try
            {
                var data = _DBContext.editorial.FirstOrDefault(x => x.EditorialId == id);
                if (data != null)
                {
                    _DBContext.editorial.Remove(data);
                    await _DBContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public async Task<Editorial> EditorialUpdate(Editorial element)
        {
            try
            {
                var model = EditorialMapper.MapperEditorialToEditorialEntity(element);
                _DBContext.editorial.Update(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion

        #region Book
        public List<Book> BookGetAll()
        {
            try
            {
                var data = _DBContext.book.ToList();
                var list = new List<Book>();
                foreach (var item in data)
                {
                    list.Add(BookMapper.MapperBookEntityToBook(item));

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<BookList> BookGetAllByAuthor(int id)
        {
            try
            {
                var data = _DBContext.book.Where(x => x.AuthorId == id).ToList();
                var autorl = _DBContext.author.ToList();
                var editoriall = _DBContext.editorial.ToList();
                var list = new List<BookList>();
                foreach (var item in data)
                {
                    var model = BookMapper.MapperBookEntityToBookList(item);
                    model.AuthorNombre = autorl.FirstOrDefault(x => x.AuthorId == model.AuthorId).Name;
                    model.EditorialNombre = editoriall.FirstOrDefault(x => x.EditorialId == model.EditorialId).Name;
                    list.Add(model);

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<BookList> BookGetAllByEditorailId(int id)
        {
            try
            {
                var data = _DBContext.book.Where(x => x.EditorialId == id).ToList();
                var autorl = _DBContext.author.ToList();
                var editoriall = _DBContext.editorial.ToList();
                var list = new List<BookList>();
                foreach (var item in data)
                {
                    var model = BookMapper.MapperBookEntityToBookList(item);
                    model.AuthorNombre = autorl.FirstOrDefault(x => x.AuthorId == model.AuthorId).Name;
                    model.EditorialNombre = editoriall.FirstOrDefault(x => x.EditorialId == model.EditorialId).Name;
                    list.Add(model);

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<BookList> BookGetAllByYear(int id)
        {
            try
            {
                var data = _DBContext.book.Where(x => x.Year == id).ToList();
                var autorl = _DBContext.author.ToList();
                var editoriall = _DBContext.editorial.ToList();
                var list = new List<BookList>();
                foreach (var item in data)
                {
                    var model = BookMapper.MapperBookEntityToBookList(item);
                    model.AuthorNombre = autorl.FirstOrDefault(x => x.AuthorId == model.AuthorId).Name;
                    model.EditorialNombre = editoriall.FirstOrDefault(x => x.EditorialId == model.EditorialId).Name;
                    list.Add(model);

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Book> BookGetAllEditorialId(int id)
        {
            try
            {
                var data = _DBContext.book.ToList();
                var list = new List<Book>();
                foreach (var item in data)
                {
                    if (item.EditorialId == id)
                    {
                        list.Add(BookMapper.MapperBookEntityToBook(item));
                    }

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<BookList> BookGetAllAuthorandEditorial()
        {
            try
            {
                var data = _DBContext.book.ToList();
                var autor = _DBContext.author.ToList();
                var editorial= _DBContext.editorial.ToList();
                var list = new List<BookList>();
                foreach (var item in data)
                {
                    var model = BookMapper.MapperBookEntityToBookList(item);
                    model.AuthorNombre = autor.FirstOrDefault(x => x.AuthorId == model.AuthorId).Name;
                    model.EditorialNombre = editorial.FirstOrDefault(x => x.EditorialId == model.EditorialId).Name;
                    list.Add(model);

                }
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Book BookGetById(int id)
        {
            try
            {
                var data = _DBContext.book.FirstOrDefault(x => x.BookId == id);
                if (data != null)
                {

                    var model = BookMapper.MapperBookEntityToBook(data);
                    return model;
                }
                return null;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Book> BookAdd(Book element)
        {
            try
            {
                var model = BookMapper.MapperBookToBookEntity(element);
                await _DBContext.book.AddAsync(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task BookDeleteAsync(int id)
        {
            try
            {
                var data = _DBContext.book.FirstOrDefault(x => x.BookId == id);
                if (data != null)
                {
                    _DBContext.book.Remove(data);
                    await _DBContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public async Task<Book> BookUpdate(Book element)
        {
            try
            {
                 var listeditorial = BookGetAllEditorialId(element.EditorialId);
                var editorial = EditorialGetById(element.EditorialId);
                if (editorial.MaxbookRegister != -1)
                {
                   
                    if (listeditorial.Count  >= editorial.MaxbookRegister)
                    {
                        return null;
                    }
                }
                var model = BookMapper.MapperBookToBookEntity(element);
                _DBContext.Update(model);
                await _DBContext.SaveChangesAsync();
                return element;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion
    }
}
