using System;

namespace services
{
    public interface IService<T> where T : class, IEntity
    {
        int Add(T entity);
        int Delete(int Id);
        int Update(T entity);
    }

    public class Service<T> : IService<T> where T : class, IEntity
    {
        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }
        protected IRepository<T> repository;
        public virtual int Add(T entity)
        {
            return this.repository.Add(entity);
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
