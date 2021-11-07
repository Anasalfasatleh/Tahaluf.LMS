using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;


        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

       

        [HttpGet]
        [ProducesResponseType(type: typeof(List<Course>), StatusCodes.Status200OK)]
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseService.GetAll();
        }

        [HttpPost]
        [Route("CreateCourse")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Create(Course course)
        {
            return _courseService.Create(course);
        }

        [HttpPut]
        [Route("UpdateCourse")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update(Course course)
        {
            
            return _courseService.Update(course); 
        }

        [HttpDelete]
        [Route("DeleteCourse")]
        [ProducesResponseType(type: typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete(int id)
        {
            return _courseService.Delete(id);
        }

        [HttpPost]
        [Route("GetCourseByName")]
        [ProducesResponseType(type: typeof(Course), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Course GetCourseByName(Course course)
        {
            return _courseService.GetCourseByName(course); 
        }

        [HttpPost]
        [Route("GetCourseByPrice")]
        [ProducesResponseType(type: typeof(Course), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Course> GetCourseByPrice(Course course)
        {
            return _courseService.GetCourseByPrice(course);
        }

        [HttpGet]
        [Route("GetCheapestCourse")]
        [ProducesResponseType(type: typeof(IEnumerable<Course>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Course> GetCheapestCourse()
        {
            return _courseService.GetCheapestCourse();
        }



    }
}
