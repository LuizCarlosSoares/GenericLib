public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private readonly IUnitOfWork unitOfWork;
    public Repository(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public int Add(T entity)
    {
        return this.unitOfWork.Commit();
    }

}