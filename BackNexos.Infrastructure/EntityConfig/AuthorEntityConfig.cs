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
    public class AuthorEntityConfig
    {
        public static void SetEntityBuilder( EntityTypeBuilder<AuthorEntity> entityBuilder)
        {
            entityBuilder.ToTable("Author");
            entityBuilder.HasKey(x => x.AuthorId);
            entityBuilder.Property(x => x.AuthorId).ValueGeneratedOnAdd();


            entityBuilder.Property(x => x.AuthorId).IsRequired();
            entityBuilder.Property(x => x.Birthdate).IsRequired();
            entityBuilder.Property(x => x.Email).IsRequired();
            entityBuilder.Property(x => x.Name).IsRequired();


        }
    }
}
