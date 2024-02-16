using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupFoodFinds.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? MiddleInitial { get; set; }

        public string? StudentNumber { get; set; }
        public string? CollegeDept { get; set; }
        public string? Program { get; set; }
        public string? YearAndSection { get; set; }
        public string? StallNumber { get; set; }
        public string? StallName { get; set; }
        public string? StreetAddress { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company? Company { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
