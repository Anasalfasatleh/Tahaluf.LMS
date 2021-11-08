using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BookController(IBookServices bookServices)
        {
            this._bookServices = bookServices;
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(Book book)
        {
            return _bookServices.Create(book);
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(Book book)
        {
            return _bookServices.Update(book);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _bookServices.Delete(id);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        [ProducesResponseType(type: typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Book GetById(int id)
        {
            return _bookServices.GetById(id);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(type: typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Book> GetAll()
        {
            return _bookServices.GetAll();
        }

        [HttpPost]
        [Route("SearchBook")]
        [ProducesResponseType(type: typeof(IEnumerable<ResponseBookDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<ResponseBookDTO> SearchBook(BookDTO bookDTO)
        {
            return _bookServices.SearchBook(bookDTO);
        }

    }
}
