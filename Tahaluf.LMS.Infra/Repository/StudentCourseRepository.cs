using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private readonly IDbContext _dbContext;

        public StudentCourseRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public bool Create(StudentCourse studentCourse)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", studentCourse.CourseId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@StudentId", studentCourse.StudentId, dbType: DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("StudentCourseInsert", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@StudentCourseId", id, dbType: DbType.Int32, ParameterDirection.Input);
            try
            {
                var result = _dbContext.Connection.Execute("StudentCourseDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<StudentCourse> GetAll()
        {
            var result = _dbContext.Connection.Query<StudentCourse>("GetAllStudentCourses", commandType: CommandType.StoredProcedure);
            return result;
        }

        public StudentCourse GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@StudentCourseId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<StudentCourse>("StudentCourseSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(StudentCourse studentCourse)
        {
            var p = new DynamicParameters();
            p.Add("@LoginId", studentCourse.StudentCourseId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseId", studentCourse.CourseId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@StudentId", studentCourse.StudentId, dbType: DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("StudentCourseUpdate", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public IEnumerable<StudentCoursesResponseDTO> StudentCourses()
        {
            var result = _dbContext.Connection.Query<StudentCoursesResponseDTO>("GetStudentAndCourses"
                , commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
