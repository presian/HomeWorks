namespace NewsSystem.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsContext context)
        {
            AddNewses(context);
        }

        private static void AddNewses(NewsContext context)
        {
            if (context.News.Any())
            {
                return;
            }
            context.News.AddRange(new HashSet<News>()
            {
                new News
                {
                    Content = "New homework is very, very big! But i don't care!"
                },
                new News
                {
                    Content = "Bla, bla bla bla!"
                },
                new News
                {
                    Content = "Lalalalalalalala"
                },
                new News
                {
                    Content = "Tralalalalalala"
                },
                new News
                {
                    Content = "Ddddddadsadasdladk;asdk"
                }
            });
        }
    }
}
