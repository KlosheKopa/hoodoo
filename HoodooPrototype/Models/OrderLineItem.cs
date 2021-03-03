using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class OrderLineItem
    {
        [Key]
        public int LineItemID { get; set; }
        public int ProductID { get; set; }
        public int OrderNumber { get; set; }
    }
}
