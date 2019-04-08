
public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private readonly IUnitOfWork unitOfWork;
    private DbSet<T> dbSet;
    public Repository(IUnitOfWork unitOfWork, IDbContext context)
    {
        this.unitOfWork = unitOfWork;
        this.dbSet = context.Set<T>();
    }

    public int Add(T entity) {

        return this.unitOfWork.Commit();
    }

   
}

 public interface IDbContext
    {
       T Set<T>();
    }