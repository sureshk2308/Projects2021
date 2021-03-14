using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Store.Data.Entity
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int BrandId { get; set; }
        
        public int TaxId { get; set; }


        [Column(TypeName = "decimal(7, 3)")]
        public decimal? TaxRate { get; set; }
        [DataType(DataType.Date)]
       // public DateTime? AuditTime { get; set; }
        public int CategoryStatus { get; set; }

        //public int BrandCategoryForienKey { get; set; }
        //public Brand Brand { get; set; }

        //public int TaxCategoryForienKey { get; set; }
        //public TaxMaster TaxMaster{get; set;}

        public ICollection<TaxMaster> TaxMasterList { get; set; }
        public ICollection<Brand> BrandList { get; set; }
        //public virtual ICollection<Product> ProductList { get; set; }
        //public CategoryImage CategoryImage { get; set; }

    }
}
