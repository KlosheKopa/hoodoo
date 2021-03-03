using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public Product ProdID { get; set; }
        public int ProdSize { get; set; }
        public int ProdQuantity { get; set; }
    }
}
