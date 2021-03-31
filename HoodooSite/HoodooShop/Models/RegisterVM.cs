using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HillsideShop.Models
{
    public class RegisterVM
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("ConfrimPassword")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


    }
}
