using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
     public class Member
    {
        [Key]
        public Guid MemberId { get; set; } = Guid.NewGuid();

        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? CompanyName {  get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}
