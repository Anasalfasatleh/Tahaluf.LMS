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
    public class BookRepository : IBookRepository
    {
        private readonly IDbContext _dbContext;

        public BookRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<ResponseBookDTO> SearchBook(BookDTO bookDTO)
        {
            var p = new DynamicParameters();
            p.Add("@BookName"   , bookDTO.BookName       , DbType.String    , ParameterDirection.Input);
            p.Add("@CourseName" , bookDTO.CourseName     , DbType.String    , ParameterDirection.Input);
            p.Add("@DateFrom"   , bookDTO.DateFrom       , DbType.Date      , ParameterDirection.Input);
            p.Add("@DateTo"     , bookDTO.DateTo         , DbType.Date      , ParameterDirection.Input);

            var result = _dbContext.Connection.Query<ResponseBookDTO>("SearchBook", p,
                commandType: CommandType.StoredProcedure);
            return result;
        }
        public bool Create(Book book)
        {
            var p = new DynamicParameters();
            p.Add("@BookName", book.BookName, DbType.String, ParameterDirection.Input);
            p.Add("@Price", book.Price, DbType.Double, ParameterDirection.Input);
            p.Add("@PublishDate", book.PublishDate, DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", book.EndDate, DbType.DateTime, ParameterDirection.Input);
            p.Add("@CourseId", book.CourseId, DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("BookInsert", p, commandType: CommandType.StoredProcedure);
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
            p.Add("@BookId", id, dbType: DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("BookDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public IEnumerable<Book> GetAll()
        {
            var result = _dbContext.Connection.Query<Book>("GetAllBooks", commandType: CommandType.StoredProcedure);
            return result;
        }

        public Book GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@BookId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Book>("BookSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(Book book)
        {
            var p = new DynamicParameters();
            p.Add("@BookId", book.BookId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@BookName", book.BookName, DbType.String, ParameterDirection.Input);
            p.Add("@Price", book.Price, DbType.Double, ParameterDirection.Input);
            p.Add("@PublishDate", book.PublishDate, DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", book.EndDate, DbType.DateTime, ParameterDirection.Input);
            p.Add("@CourseId", book.CourseId, DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("BookUpdate", p, commandType: CommandType.StoredProcedure);
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
