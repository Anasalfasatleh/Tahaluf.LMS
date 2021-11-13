using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.IServices;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IFileService _fileService;

        public CourseController(ICourseService courseService,IFileService fileService)
        {
            this._courseService = courseService;
            this._fileService = fileService;
        }

        [HttpPost]
        [Route("UploadImageToCoure")]
        public async Task<bool> UploadImageToCoure([FromForm] int id ,[FromForm] IFormFile image)
        {
            
            if(!_fileService.IsPicture(image.FileName))
            {
                return false;
            }

            if (_fileService.CheckPictureSizeInMB(image.Length, 2))
            {
                return false;
            }
            var imageName = _fileService.GenerateFileName(image.FileName);
            await _fileService.SavePic(image, imageName);

            _courseService.Addimage(id, imageName);
            return true; 
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
        [Route("DeleteCourse/{id}")]
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
