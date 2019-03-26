public class Repository<T> : IRepository<T> where T : class, IEntity
{

    public Repository()
    {

    }

    public int Add(T entity)
    {
        return 1;
    }

}