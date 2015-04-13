namespace News.Data.Repositories
{
    using System.Data.Entity;
    using System.Linq;

    using Models;

    public class NewsRepository : IRepository<NewsItem>
    {
        private DbContext context;
        private IDbSet<NewsItem> set;

        public NewsRepository(DbContext context)
        {
            this.context = context;
            this.set = this.context.Set<NewsItem>();
        }

        public IDbSet<NewsItem> Set
        {
            get { return this.set; }
        }

        public IQueryable<NewsItem> GetAll()
        {
            return this.set;
        }

        public NewsItem FindById(int id)
        {
            return this.set.Find(id);
        }

        public void Update(NewsItem entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Add(NewsItem entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public void DeleteById(int id)
        {
            var entity = this.FindById(id);
            this.ChangeState(entity, EntityState.Deleted);
        }

        public void Delete(NewsItem entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private void ChangeState(NewsItem entity, EntityState state)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }
    }
}
