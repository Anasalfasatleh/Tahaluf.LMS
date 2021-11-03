using System.Collections.Generic;


namespace Tahaluf.LMS.Core.Repository
{
    public interface ICRUDRepository<T>
    {
        bool Create(T t);

        bool Update(T t);

        bool Delete(T t);

        T GetById(T t);

        IEnumerable<T> GetAll();

    }
}
