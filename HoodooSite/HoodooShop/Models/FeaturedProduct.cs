using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class FeaturedProduct
    {
        [Key]
        public int FeaturedID { get; set; }
        public Product ProductID { get; set; }
        public bool HasCustomDesc { get; set; }
        public string CustomerDesc { get; set; }
    }
}
