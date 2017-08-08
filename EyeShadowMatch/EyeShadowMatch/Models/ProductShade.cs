using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EyeShadowMatch.Models
{
    public class ProductShade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductShadeId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("Shade")]
        public int ShadeId { get; set; }

        public Shade Shade { get; set; }
    }
}