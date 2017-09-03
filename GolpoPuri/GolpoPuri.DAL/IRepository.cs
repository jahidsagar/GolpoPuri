using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GolpoPuri.Library;

namespace GolpoPuri.DAL
{
    public interface IRepository<Tobject> where Tobject : Common
    {
        void Delete(object parameter);
        void Delete(Tobject ObjectToDelete);
        Tobject Find(object parameterFind);
        IEnumerable<Tobject> Get(Expression<Func<Tobject, bool>> filter = null, Func<IQueryable<Tobject>, IOrderedQueryable<Tobject>> orderby = null);
        IEnumerable<Tobject> Get(out int total, out int totalDisplay, Expression<Func<Tobject, bool>> filter = null, Func<IQueryable<Tobject>, IOrderedQueryable<Tobject>> orderby = null, int pageIndex = 1, int pageSize = 10);
        Tobject GetByID(object id);
        int GetCount(Expression<Func<Tobject, bool>> filter = null);
        void insert(Tobject tobjectInsert);
    }
}