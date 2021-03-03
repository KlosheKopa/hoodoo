using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class Orders
    {
        [Key]
        public int OrderNumber { get; set; }
        public string CustomerID { get; set; }
        public string CustFName { get; set; }
        public string CustLName { get; set; }
        public DateTime DateOrdered { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderType { get; set; }
        public string TrackingNumber { get; set; }
        public string OrderStatus { get; set; }
        public DateTime DateRecieved { get; set; }
        public bool IsViewed { get; set; }
        public IList<string> FulfilledBy { get; set; }
    }
}
