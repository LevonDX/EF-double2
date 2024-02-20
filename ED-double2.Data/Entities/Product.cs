using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_double2.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } // navigation property
    }
}