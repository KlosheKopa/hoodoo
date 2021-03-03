using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class Product
    {
        [Key]
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }

        //public List<Image> ProdImage { get; set; }

        public decimal ProdPrice { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastModified { get; set; }
        public AppUser AddedBy { get; set; }
        public AppUser ModifiedBy { get; set; }
    }
}
