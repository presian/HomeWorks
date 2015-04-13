namespace News.Data.Repositories
{
    using System.Linq;

    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        
        T FindById(int id);

        void Update(T entity);

        void Add(T entity);

        void DeleteById(int id);

        void Delete(T entity);

        int SaveChanges();
    }
}
