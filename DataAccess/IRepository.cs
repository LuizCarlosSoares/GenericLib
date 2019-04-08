public interface IRepository<TEntity> where TEntity : class, IEntity
{

    int Add(TEntity T);
    
}

