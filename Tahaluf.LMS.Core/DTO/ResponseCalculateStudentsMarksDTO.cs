using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class ResponseCalculateStudentsMarksDTO
    {
        public int MaxMark { get; set; }
        public int MinMark { get; set; }
        public int CountMark { get; set; }
        public double AvgMark { get; set; }

    }
}
