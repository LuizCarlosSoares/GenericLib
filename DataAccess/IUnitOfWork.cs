using Microsoft.EntityFrameworkCore;
public interface IUnitOfWork
{
    void Dispose();
    DbContext context { get; }
    int Commit();

}