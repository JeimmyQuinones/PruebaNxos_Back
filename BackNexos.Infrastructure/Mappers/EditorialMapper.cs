using BackNexos.Domain.Models;
using BackNexos.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Mappers
{
    public class EditorialMapper
    {
        public static EditorialEntity MapperEditorialToEditorialEntity(Editorial model)
        {
            EditorialEntity data = new()
            {
                EditorialId=model.EditorialId,
                Name =model.Name,
                Adress = model.Adress,
                Phone = model.Phone,
                Email=model.Email,
                MaxbookRegister =model.MaxbookRegister
    };
            return data;
        }
        public static Editorial MapperEditorialEntityToEditorial(EditorialEntity model)
        {
            Editorial data = new()
            {
                EditorialId = model.EditorialId,
                Name = model.Name,
                Adress = model.Adress,
                Phone = model.Phone,
                Email = model.Email,
                MaxbookRegister = model.MaxbookRegister
            };
            return data;
        }
    }
}
