using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BackendApplication.Data
{
    public class QueryParameters<T>
    {
        public QueryParameters(int page, int top) {
            Page = page;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
        public int Page { get; set; }
        public int Top { get; set; }
        public Expression<Func<T,bool>> Where { get; set; }

        public Func<T,object> OrderBy { get; set; }
        public Func<T,object> OrderByDescending { get; set; }
    }
}