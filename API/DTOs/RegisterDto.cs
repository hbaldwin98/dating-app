using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string knownAs { get; set; }
        [Required] public string gender { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string city { get; set; }
        [Required] public string country { get; set; }

        [Required] 
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}