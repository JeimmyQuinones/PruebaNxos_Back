using BackNexos.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.EntityConfig
{
    public class BookEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookEntity> entityBuilder)
        {
            entityBuilder.ToTable("Book");
            entityBuilder.HasKey(x => x.BookId);
            entityBuilder.Property(x => x.BookId).ValueGeneratedOnAdd();

            entityBuilder.Property(x => x.Genre).IsRequired();
            entityBuilder.Property(x => x.Numberpage).IsRequired();
            entityBuilder.Property(x => x.Title).IsRequired();
            entityBuilder.Property(x => x.Year).IsRequired();

            entityBuilder.HasOne(x => x.Author).WithMany().HasForeignKey(x=>x.AuthorId);
            entityBuilder.HasOne(x => x.Editorial).WithMany().HasForeignKey(x => x.EditorialId);



        }
    }
}
