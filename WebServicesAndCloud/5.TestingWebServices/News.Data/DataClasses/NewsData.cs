namespace News.Data.DataClasses
{
    using System.Data.Entity;
    
    using Repositories;
    
    public class NewsData : INewsData
    {
        private DbContext context;

        public NewsData(DbContext context)
        {
            this.context = context;
        }

        public NewsRepository NewsRepository
        {
            get
            {
                return new NewsRepository(this.context);
            }
        }

        public int SaveChages()
        {
            return this.context.SaveChanges();
        }
    }
}
