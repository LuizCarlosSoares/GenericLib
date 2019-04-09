
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace DataAcess.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly IUnitOfWork unitOfWork;
        internal DbSet<T> dbSet;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            dbSet = unitOfWork.context.Set<T>();

        }

        public int Add(T entity)
        {

            return this.unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet.AsEnumerable();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

    }

}
