using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
 

        [HttpGet]
        [ProducesResponseType(type: typeof(List<Course>), StatusCodes.Status200OK)]
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookServices.GetAll();
        }

        [HttpPost]
        [Route("SearchBook")]
        [ProducesResponseType(type: typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Book> SearchBook(BookDTO bookDTO)
        {
            return _bookServices.SearchBook(bookDTO);
        }
    }
}
