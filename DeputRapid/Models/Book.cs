using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;
using DeputRapid.Models.MyValidation;

namespace DeputRapid.Models
{
    public class Book
    {
        [Key, Column("Book_id")]
        public int BookId { get; set; }


        [MinLength(10, ErrorMessage = "Title cannot be less than 10"),
            MaxLength(200, ErrorMessage = "Title cannot be more than 200")]
        public string Title { get; set; }


        [MinLength(3, ErrorMessage = "Author cannot be less than 3 letters!"),
            MaxLength(50, ErrorMessage = "Author cannot be more than 50 letters!")]
        public string Author { get; set; }


        [MinLength(2, ErrorMessage = "Summary cannot be less than 2!"),
            MaxLength(5000, ErrorMessage = "Summary cannot be  more than 5000!")]
        public string Summary { get; set; }

        [PrimeNumberValidator]
        public int NoOfPages { get; set; }

        //one to many
        public int BookTypeId { get; set; }

        [ForeignKey("BookTypeId")]
        public virtual BookType BookType { get; set; }

        [NotMapped]
        public DateTime LoadedFromDatabase { get; set; }

        [Column("Publisher_id")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> BookTypesList { get; set; }
    }

}