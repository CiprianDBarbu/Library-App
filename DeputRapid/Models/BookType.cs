using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeputRapid.Models
{
    public class BookType
    {
        [Key]
        public int BookTypeId { get; set; }


        [MinLength(2, ErrorMessage = "Book type name cannot be lass than 2 letters!"),
            MaxLength(20, ErrorMessage = "Book type name cannot be more than 20 letters!")]
        public string Name { get; set; }

        //many to one
        public virtual ICollection<Book> Books { get; set; }
    }
}