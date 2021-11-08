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
    public class TeacherCourseController : ControllerBase
    {

        private readonly ITeacherCourseServices _teacherCourseServices;

        public TeacherCourseController(ITeacherCourseServices teacherRepository)
        {
            this._teacherCourseServices = teacherRepository;
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(TeacherCourse teacherCourse)
        {
            return _teacherCourseServices.Create(teacherCourse);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _teacherCourseServices.Delete(id);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(type: typeof(IEnumerable<TeacherCourse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<TeacherCourse> GetAll()
        {
            return _teacherCourseServices.GetAll();
        }



        [HttpGet]
        [Route("GetById/{id}")]
        [ProducesResponseType(type: typeof(TeacherCourse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public TeacherCourse GetById(int id)
        {
            return _teacherCourseServices.GetById(id);
        }

        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(TeacherCourse teacherCourse)
        {
            return _teacherCourseServices.Update(teacherCourse);
        }
    }
}
