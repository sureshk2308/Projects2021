using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store.Data.Entity
{
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductImageId { get; set; }
        public byte[] ProductImageData { get; set; }
      
        public int ProductForienKey { get; set; }
        public Product Product { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
    }
}
