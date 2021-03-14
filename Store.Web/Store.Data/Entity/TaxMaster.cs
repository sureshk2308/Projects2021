using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Data.Entity
{
    public class TaxMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxId { get; set; }
        [MaxLength(50)]
        [Required]
        public string TaxName { get; set; }

        [Column(TypeName = "decimal(7, 3)")]
        public decimal? TaxRate { get; set; }

        //public virtual ICollection<Product> ProductList { get; set; }
        //public virtual ICollection<Category> CategoryList { get; set; }

    }
}
