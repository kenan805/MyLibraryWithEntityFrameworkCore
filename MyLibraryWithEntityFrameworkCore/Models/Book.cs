using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryWithEntityFrameworkCore.Models
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public int PageCount { get; set; }


        // Foreign Key
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }
        // Relational Property
        public virtual Author? Author { get; set; }
        public virtual BookType? BookType { get; set; }
        public virtual List<Operation>? Operations { get; set; }
    }
}
