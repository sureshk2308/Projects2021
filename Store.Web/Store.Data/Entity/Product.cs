using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Data.Entity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductHSNCode { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string ProductDescription { get; set; }
        public string UOM { get; set; }

        public int TaxId { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? TaxRate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DiscountRate { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal? PurchaseRate { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal? SaleRate { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal? MRP { get; set; }
        public int MinOrderLevel { get; set; }
        public int OpeningStock { get; set; }
        public int ClosingStock { get; set; }
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public int ProductStatus { get; set; }
        public int OfferStatus { get; set; }


        //public int TaxProductForienKey { get; set; }
        //public TaxMaster TaxMaster { get; set; }
       

        //public int BrandProductForienKey { get; set; }
        //public Brand Brand { get; set; }

        //public int CategoryProductForienKey { get; set; }
        //public Category Category { get; set; }


        public ICollection<Brand> BrandList { get; set; }
        public ICollection<Category> CategoryList { get; set; }
        public ICollection<TaxMaster> TaxMasterList { get; set; }
        //public ProductImage ProductImage { get; set; }




    }
}
