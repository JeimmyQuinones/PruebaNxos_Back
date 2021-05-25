using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Domain.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Numberpage { get; set; }
        public int EditorialId { get; set; }
        public int AuthorId { get; set; }
    }
    public class BookList:Book
    {
        public string EditorialNombre { get; set; }
        public string AuthorNombre { get; set; }
    }
}
