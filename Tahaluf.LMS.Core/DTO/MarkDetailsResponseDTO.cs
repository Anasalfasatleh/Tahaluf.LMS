using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class MarkDetailsResponseDTO
    { 
        public double Sum { get; set; }
        public double AverageOfMarks { get; set; }
        public double CountOfMarks { get; set; }
        public double MaxMark { get; set; }
        public double MinMark { get; set; }
    }
}
