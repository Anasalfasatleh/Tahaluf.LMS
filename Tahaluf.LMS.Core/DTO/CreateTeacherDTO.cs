using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class CreateTeacherDTO
    {
       public string UserName { get; set; }
       public string Password { get; set; }
       public string RoleName { get; set; }
       public string TeacherName { get; set; }
       public string Email { get; set; }
       public double Salary { get; set; }
       public string PhoneNumber { get; set; }
    }
}
