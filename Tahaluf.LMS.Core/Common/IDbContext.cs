using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Tahaluf.LMS.Core.Common
{
    public class IDbContext 
    {
       public DbConnection Connection { get; }
    }
}
