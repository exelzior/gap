using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(int id);
        void toUpdate(T entity);
        int Count(Expression<Func<T, bool>> where);
        T ObtainById(int id);
        IEnumerable<T> FindBy(QueryParameters<T> queryParameters);
    }
}
