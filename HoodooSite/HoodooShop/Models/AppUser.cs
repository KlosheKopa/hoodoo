using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HillsideShop.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name must be longer than a single character.")]
        [Required]
        public string FName { get; set; }
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Last Name must be longer than a single character.")]
        [Required]
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
