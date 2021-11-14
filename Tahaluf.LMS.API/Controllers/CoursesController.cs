using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.Data;
using Tahaluf.LMS.Core.Services;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesServices _coursesServices;

        public CoursesController(ICoursesServices coursesServices)
        {
            this._coursesServices = coursesServices;
        }

        [HttpPost]
        [Route("CreateCourse")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(Courses course)
        {
            return _coursesServices.Create(course);
        }

        [HttpPut]
        [Route("UpdateCourse")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(Courses course)
        {
            return _coursesServices.Update(course);
        }

        [HttpDelete]
        [Route("DeleteCourse/{id}")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _coursesServices.Delete(id);
        }

        [HttpGet]
        [Route("GetAllCourses")]
        [ProducesResponseType(type: typeof(List<Courses>), StatusCodes.Status200OK)]
        public IEnumerable<Courses> GetAllCourses()
        {
            return _coursesServices.GetAll();
        }
    }
}
