using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BackendApplication.Data
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        public void Add(T entity)
        {
            using(var db = new DatabaseDbEntities()) {
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            };            
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            using (var db = new DatabaseDbEntities())
            {
                return db.Set<T>().Where(where).Count();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DatabaseDbEntities())
            {
                var entidad = new T() { Id = id };
                db.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IEnumerable<T> FindBy(QueryParameters<T> queryParameters)
        {
            var orderByClass = ObtenerOrderBy(queryParameters);
            Expression<Func<T, bool>> whereTrue = x => true;
            var where = (queryParameters.Where == null) ? whereTrue : queryParameters.Where;
            using (DatabaseDbEntities db = new DatabaseDbEntities())
            {
                if (orderByClass.IsAscending)
                {
                    return db.Set<T>().Where(where).OrderBy(orderByClass.OrderBy)
                    .Skip((queryParameters.Page - 1) * queryParameters.Top)
                    .Take(queryParameters.Top).ToList();
                }
                else
                {
                    return db.Set<T>().Where(where).OrderByDescending(orderByClass.OrderBy)
                    .Skip((queryParameters.Page - 1) * queryParameters.Top)
                    .Take(queryParameters.Top).ToList();
                }

            }
        }
        private OrderByClass ObtenerOrderBy(QueryParameters<T> parametrosDeQuery)
        {
            if (parametrosDeQuery.OrderBy == null && parametrosDeQuery.OrderByDescending == null)
            {
                return new OrderByClass(x => x.Id, true);
            }

            return (parametrosDeQuery.OrderBy != null)
                ? new OrderByClass(parametrosDeQuery.OrderBy, true) :
                new OrderByClass(parametrosDeQuery.OrderByDescending, false);
        }
        private class OrderByClass
        {

            public OrderByClass()
            {

            }

            public OrderByClass(Func<T, object> orderBy, bool isAscending)
            {
                OrderBy = orderBy;
                IsAscending = isAscending;
            }


            public Func<T, object> OrderBy { get; set; }
            public bool IsAscending { get; set; }
        }

        public T ObtainById(int id)
        {
            using (var db = new DatabaseDbEntities())
            {
                return db.Set<T>().FirstOrDefault(x => x.Id == id);
            }            
        }

        public void toUpdate(T entity)
        {
            using (var db = new DatabaseDbEntities())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();                
            };            
        }

    }
}