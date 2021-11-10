using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;

namespace Tahaluf.LMS.Core.Services
{
    public interface IJWTService
    {
        string Auth(RequestLoginDTO loginDTO);
    }
}
