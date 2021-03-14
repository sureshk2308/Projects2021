using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Store.Data.Entity
{
    public class CategoryImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryImageId { get; set; }
        public byte[] CategoryImageData { get; set; }  
        
        public int CategoryId { get; set; }
        //public Category Category { get; set; }

        public virtual ICollection<Category> CategoryList { get; set; }
    }
}
