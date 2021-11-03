using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IBookServices
    {
        bool Create(Book book);

        bool Update(Book book);

        bool Delete(Book book);

        Book GetById(Book book);

        IEnumerable<Book> GetAll();
    }
}
