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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherServices _teacherServices;

        public TeacherController(ITeacherServices teacherServices)
        {
            this._teacherServices = teacherServices;
        }


        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(Teacher teacher)
        {
            return _teacherServices.Create(teacher);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _teacherServices.Delete(id);

        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(type: typeof(IEnumerable<Teacher>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Teacher> GetAll()
        {
            return _teacherServices.GetAll();

        }

        [HttpGet]
        [Route("GetByEmail")]
        [ProducesResponseType(type: typeof(Teacher), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Teacher GetByEmail(Teacher teacher)
        {
            return _teacherServices.GetByEmail(teacher);

        }

        [HttpGet]
        [Route("GetById/{id}")]
        [ProducesResponseType(type: typeof(Teacher), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Teacher GetById(int id)
        {
            return _teacherServices.GetById(id);

        }

        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(Teacher teacher)
        {
            return _teacherServices.Update(teacher);

        }
    }
}
