using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupFoodFinds.Models
{
    public class Company
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? MiddleInitial { get; set; }
        [Required]
        public string? StallName { get; set; }
        public string? StallNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetAddress { get; set; }

    }
}
