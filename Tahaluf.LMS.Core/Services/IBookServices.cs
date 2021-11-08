using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IBookServices
    {
        bool Create(Book book);

        bool Update(Book book);

        bool Delete(int id);

        Book GetById(int id);

        IEnumerable<Book> GetAll();
        IEnumerable<ResponseFilterDTO> SearchBook(BookDTO bookDTO);
    }
}
