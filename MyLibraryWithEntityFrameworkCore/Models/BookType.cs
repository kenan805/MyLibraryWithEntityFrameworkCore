using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryWithEntityFrameworkCore.Models
{
    public class BookType : BaseEntity
    {
        public string? Name { get; set; }

        // Relational Property
        public virtual List<Book>? Books { get; set; }

    }
}
