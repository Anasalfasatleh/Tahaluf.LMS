using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.LMS.Core.DTO
{
    public class UploadImageDTO
    {
        public int id { get; set; }
        public IFormFile image { get; set; }
    }
}
