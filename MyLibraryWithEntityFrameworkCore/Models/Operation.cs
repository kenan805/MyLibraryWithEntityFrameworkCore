using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryWithEntityFrameworkCore.Models
{
    public class Operation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Foreign Key
        public int StudentId { get; set; }
        public int BookId { get; set; }

        // Relational Property
        public virtual Student? Student { get; set; }
        public virtual Book? Book { get; set; }

    }
}
