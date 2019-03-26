using System;
using System.Reflection;
using System.Reflection.Emit;

public class RepositoryFactory<T> where T: class, IEntity {

    public virtual IRepository<T> Get(){

       Type typeParameterType = typeof(Repository<T>);      
       Repository<T> type = Activator.CreateInstance(typeParameterType) as Repository<T>;
       return type;

    }

    public virtual IRepository<T> Get(IUnitOfWork unitOfWork){

       Type typeParameterType = typeof(Repository<T>);      
       Repository<T> type = Activator.CreateInstance(typeParameterType,unitOfWork) as Repository<T>;
       return type;

    }
}