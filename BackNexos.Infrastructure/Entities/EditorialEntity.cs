using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackNexos.Infrastructure.Entities
{
    public class EditorialEntity
    {
        public int EditorialId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MaxbookRegister { get; set; }

    }
}
