using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;

namespace Tahaluf.LMS.Core.Repository
{
    public interface IJWTRepository
    {
        ResponseLoginDTO Authentication(RequestLoginDTO login);
    }
}
