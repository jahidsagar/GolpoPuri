using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.DAL
{
    public class Repository<Tobject> : IRepository<Tobject> where Tobject:Common
    {
        protected DbContext context;
        protected DbSet<Tobject> dbset;

        public Repository(DbContext context)
        {
            this.context = context;
            this.dbset = context.Set<Tobject>();
        }

        public virtual void insert(Tobject tobjectInsert)
        {
            dbset.Add(tobjectInsert);
        }

        //find data and attach and delete the parameter
        public virtual void Delete(object parameter)
        {

            Delete(Find(parameter));
        }

        //attach the dbset
        public virtual void Delete(Tobject ObjectToDelete)
        {
            if(context.Entry(ObjectToDelete).State == EntityState.Detached)
            {
                dbset.Attach(ObjectToDelete);
            }
            dbset.Remove(ObjectToDelete);
        }

        public virtual Tobject Find(object parameterFind)
        {
            return dbset.Find(parameterFind);
        }


        public virtual Tobject GetByID(object id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<Tobject> Get(Expression<Func<Tobject, bool>> filter = null,
            Func<IQueryable<Tobject>, IOrderedQueryable<Tobject>> orderby = null)
        {
            IQueryable<Tobject> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderby != null)
            {
                return orderby(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual int GetCount(Expression<Func<Tobject, bool>> filter = null)
        {
            IQueryable<Tobject> query = dbset;
            int count = query.Count();

            if (filter != null)
            {
                query = query.Where(filter);
                count = query.Count();
            }
            return count;
        }

        public virtual IEnumerable<Tobject> Get(out int total, out int totalDisplay,
            Expression<Func<Tobject, bool>> filter = null,
            Func<IQueryable<Tobject>, IOrderedQueryable<Tobject>> orderby = null,
            int pageIndex = 1, int pageSize = 10)
        {
            IQueryable<Tobject> query = dbset;
            total = query.Count();
            totalDisplay = query.Count();

            if (filter != null)
            {
                query = query.Where(filter);
                totalDisplay = query.Count();
            }

            if (orderby != null)
            {
                return orderby(query).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
        }


    }
}
