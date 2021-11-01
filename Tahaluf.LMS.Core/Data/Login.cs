using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tahaluf.LMS.Models
{
    public class Login
    {

        [Key]
        public int LoginId { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z][a-zA-Z0-9-_]{3,32}",ErrorMessage ="Please enter a valid username")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",ErrorMessage ="Please enter a valid password")]
        public string Password { get; set; }

        [Required]
        public string RoleName { get; set; }

        public  ICollection<Teacher> Teachers { get; set; }
    }
}
