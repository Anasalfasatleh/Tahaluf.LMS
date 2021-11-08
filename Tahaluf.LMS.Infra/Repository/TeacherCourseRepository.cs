using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class TeacherCourseRepository : ITeacherCourseRepository
    {
        private readonly IDbContext _dbContext;

        public TeacherCourseRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public bool Create(TeacherCourse teacherCourse)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherId", teacherCourse.TeacherId, DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseId", teacherCourse.CourseId, DbType.Int32, ParameterDirection.Input);



            try
            {
                var result = _dbContext.Connection.Execute("TeacherCourseInsert", p, commandType: CommandType.StoredProcedure);
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
            p.Add("@TeacherCourseId", id, dbType: DbType.Int32, ParameterDirection.Input);
            try
            {
                var result = _dbContext.Connection.Execute("TeacherCourseDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<TeacherCourse> GetAll()
        {
            var result = _dbContext.Connection.Query<TeacherCourse>("GetAllTeacherCourses", commandType: CommandType.StoredProcedure);
            return result;
        }

        public TeacherCourse GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherCourseId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<TeacherCourse>("TeacherCourseSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(TeacherCourse teacherCourse)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherCourseId", teacherCourse.TeacherCourseId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@TeacherId", teacherCourse.TeacherId, DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseId", teacherCourse.CourseId, DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("TeacherCourseUpdate", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
