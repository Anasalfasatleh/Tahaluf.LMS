using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class CourseCRUD_DTO
    {
        public string OpertionType { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public double Price { get; set; }
    }
}
