using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hostel
{
    public class Apply
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]

        public string StudentRegistration { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(12)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Number")]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string Road { get; set; }
        
    }
}