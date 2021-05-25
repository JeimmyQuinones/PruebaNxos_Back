using BackNexos.Domain.Models;
using BackNexos.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Mappers
{
    public class BookMapper
    {
        public static BookEntity MapperBookToBookEntity(Book model)
        {
            BookEntity data = new()
            {
                BookId =model.BookId,
                Title = model.Title,
                Year =model.Year,
                Genre =model.Genre,
                Numberpage=model.Numberpage,
                EditorialId=model.EditorialId,
                AuthorId =model.AuthorId
    };
            return data;
        }
        public static Book MapperBookEntityToBook(BookEntity model)
        {
            Book data = new()
            {
                BookId = model.BookId,
                Title = model.Title,
                Year = model.Year,
                Genre = model.Genre,
                Numberpage = model.Numberpage,
                EditorialId = model.EditorialId,
                AuthorId = model.AuthorId
            };
            return data;
        }
        public static BookList MapperBookEntityToBookList(BookEntity model)
        {
            BookList data = new()
            {
                BookId = model.BookId,
                Title = model.Title,
                Year = model.Year,
                Genre = model.Genre,
                Numberpage = model.Numberpage,
                EditorialId = model.EditorialId,
                AuthorId = model.AuthorId,
                AuthorNombre = "",
                EditorialNombre="",
                
                
            };
            return data;
        }
       
    }
}
