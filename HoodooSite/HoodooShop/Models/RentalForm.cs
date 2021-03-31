using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoodooPrototype.Models
{
    public class RentalForm
    {
        [Key]
        public int FormID { get; set; }
        public string RenterFName { get; set; }
        public string RenterLName { get; set; }
        public string RenterStreetName { get; set; }
        public string RenterCity { get; set; }
        public string RenterState { get; set; }
        public string RenterZip { get; set; }
        public string RenterPhone { get; set; }
        public int RenterWeight { get; set; }
        public string RenterHeight { get; set; }
        public decimal ShoeSize { get; set; }
        public string ShoeType { get; set; }
        public DateTime RenterBirthdate { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public String RentalType { get; set; }
        public String RentalComment { get; set; }
        public DateTime DateSubmitted { get; set; }
        public AppUser ViewedBy { get; set; }
    }
}
