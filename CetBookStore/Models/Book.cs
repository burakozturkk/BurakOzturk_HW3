using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength =3)]
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        public int? PageCount { get; set; }

        public string Authors { get; set; }
        public string Description  { get; set; }
        
        public Decimal Price { get; set; }

        public int PressYear { get; set; }
        public int StockCount { get; set; }

        
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public  Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
