using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IRepository<TEntity> where TEntity : class, IEntity
{

    int Add(TEntity T);


    IEnumerable<TEntity> GetAll();

    IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> whereCondition);

    void Delete(TEntity entity);

    

}

