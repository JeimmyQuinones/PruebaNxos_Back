using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Entities
{
    public class BookEntity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Numberpage { get; set; }
        public int EditorialId { get; set; }
        public int AuthorId { get; set; }
        public virtual EditorialEntity Editorial { get; set; }
        public virtual AuthorEntity Author { get; set; }


    }
}
