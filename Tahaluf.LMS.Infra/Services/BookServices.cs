using System.Collections.Generic;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _bookRepository;

        public BookServices(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }
        public bool Create(Book book)
        {
            return _bookRepository.Create(book); ;
        }

        public bool Delete(int id)
        {
            return _bookRepository.Delete(id);

        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();

        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);

        }

        public bool Update(Book book)
        {
            return _bookRepository.Update(book);

        }
    }
}
