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
    public class EditorialEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<EditorialEntity> entityBuilder)
        {
            entityBuilder.ToTable("Editorial");
            entityBuilder.HasKey(x => x.EditorialId);
            entityBuilder.Property(x => x.EditorialId).ValueGeneratedOnAdd();


            entityBuilder.Property(x => x.Adress).IsRequired();
            entityBuilder.Property(x => x.Email).IsRequired();
            entityBuilder.Property(x => x.MaxbookRegister).IsRequired();
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Phone).IsRequired();

        }
    }
}
