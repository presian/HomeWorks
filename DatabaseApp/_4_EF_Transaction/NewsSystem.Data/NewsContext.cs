namespace NewsSystem.Data
{
    using System.Data.Entity;
    using Models;

    public class NewsContext : DbContext
    {
        public NewsContext() 
            : base("NewsDB")
        {
        }

        public DbSet<News> News { get; set; }
    }
}
