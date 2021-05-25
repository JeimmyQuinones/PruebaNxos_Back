using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Entities
{
    public class AuthorEntity
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Town { get; set; }
        public string Email { get; set; }
    }
}
