using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Domain.Models
{
    public class Editorial
    {
        public int EditorialId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MaxbookRegister { get; set; }
    }
}
