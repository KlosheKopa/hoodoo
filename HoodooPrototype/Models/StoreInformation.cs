using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class StoreInformation
    {
        [Key]
        public int StoreInfoID { get; set; }
        public string Hours { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
    }
}
