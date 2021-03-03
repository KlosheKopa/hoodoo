using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class RentalPage
    {
        [Key]
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public string SectionType { get; set; }
        public string CustomerDesc { get; set; }
    }
}
