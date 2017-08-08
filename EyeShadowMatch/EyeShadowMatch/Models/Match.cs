using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EyeShadowMatch.Models
{
    public class Match
    {
        [Key, Column(Order = 0)]
        [ForeignKey("ProductShade")]
        public int ProductShadeId { get; set; }
        public ProductShade ProductShade { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Look")]
        public int LookId { get; set; }
        public Look Look { get; set; }
    }
}