using BackNexos.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure
{
    public class DBInitializer
    {
        public static void Initializer(DBContext context)
        {
            context.Database.EnsureCreated();
            if (context.author.Any()&& context.book.Any() && context.editorial.Any())
            {
                return;
            }
            if (!context.author.Any())
            {
                var Author = new AuthorEntity[]
                {
                    new AuthorEntity {AuthorId=0,
                                        Name ="annie",
                                        Birthdate=new DateTime(1998,04,08),
                                        Town = "bogota",
                                        Email = "annie@gamil.com"},
                    new AuthorEntity {AuthorId=0,
                                        Name ="tokio",
                                        Birthdate=new DateTime(2000,06,12),
                                        Town = "cartagena",
                                        Email = "tokio@gamil.com"},
                };
                foreach (var item in Author)
                {
                    context.author.Add(item);
                }
                context.SaveChanges();
            }
            if (!context.editorial.Any())
            {
                var Editorial = new EditorialEntity[]
                {
                    new EditorialEntity {EditorialId=0,
                Name ="Casa Tomada",
                Adress = "Calle 9",
                Phone = "+578 4184567",
                Email= "casatomada@gmail.com",
                MaxbookRegister =3},
                    new EditorialEntity{EditorialId=0,
                Name ="Ronda",
                Adress = "Carrera 56",
                Phone = "+45 456783",
                Email= "ronda@gmail.com",
                MaxbookRegister =-1}
                };
                foreach (var item in Editorial)
                {
                    context.editorial.Add(item);
                }
                context.SaveChanges();
            }
            if (!context.book.Any())
            {
                var Book = new BookEntity[]
                {
                    new BookEntity {BookId =0,
                Title = "La caja morada",
                Year =2019,
                Genre ="Acción",
                Numberpage=190,
                EditorialId=1,
                AuthorId =1},
                    new BookEntity{BookId =0,
                Title = "It el tenebroso",
                Year =1999,
                Genre ="Terror",
                Numberpage=1234,
                EditorialId=1,
                AuthorId =2}
                };
                foreach (var item in Book)
                {
                    context.book.Add(item);
                }
                context.SaveChanges();
            }


        }
    }
}
