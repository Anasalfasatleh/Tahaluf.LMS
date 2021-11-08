using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class ResponseBookDTO
    {
        public string CourseName { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
