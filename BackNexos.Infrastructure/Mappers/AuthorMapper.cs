using BackNexos.Domain.Models;
using BackNexos.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Mappers
{
    public class AuthorMapper
    {
        public static AuthorEntity MapperAuthorToAuthorEntity (Author model)
        {
            AuthorEntity data = new()
            {
                AuthorId = model.AuthorId,
                Name = model.Name,
                Birthdate=model.Birthdate,
                Town =model.Town,
                Email =model.Email
         };
            return data;
        }
        public static Author MapperAuthorEntityToAuthor(AuthorEntity model)
        {
            Author data = new()
            {
                AuthorId = model.AuthorId,
                Name = model.Name,
                Birthdate = model.Birthdate,
                Town = model.Town,
                Email = model.Email
            };
            return data;
        }

    }
}
