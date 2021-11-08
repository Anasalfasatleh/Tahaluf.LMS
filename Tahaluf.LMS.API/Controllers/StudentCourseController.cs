using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {

        private readonly IStudentCourseServices _studentCourse;

        public StudentCourseController(IStudentCourseServices studentCourse)
        {
            this._studentCourse = studentCourse;
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(StudentCourse studentCourse)
        {
            return _studentCourse.Create(studentCourse);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _studentCourse.Delete(id);

        }


        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(type: typeof(IEnumerable<StudentCourse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<StudentCourse> GetAll()
        {
            return _studentCourse.GetAll();

        }


        [HttpGet]
        [Route("GetById/{id}")]
        [ProducesResponseType(type: typeof(StudentCourse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public StudentCourse GetById(int id)
        {
            return _studentCourse.GetById(id);

        }

        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(StudentCourse studentCourse)
        {
            return _studentCourse.Update(studentCourse);

        }
    }
}
