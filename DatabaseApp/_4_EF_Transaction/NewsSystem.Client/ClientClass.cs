namespace NewsSystem.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    using Data;
    using Data.Migrations;

    class ClientClass
    {
        static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<NewsContext, Configuration>());

            OpenFirstConnection();
            
        }

        private static void OpenSecondConnection(NewsContext firstDb)
        {
            using (var secondDb = new NewsContext())
            {
                Console.WriteLine("Second User: ");
                PrintNews(secondDb);
                var firstUserEdit = GetUserEdit(firstDb, "");
                var secondUserEdit = GetUserEdit(secondDb, "");
                SaveChanges(firstDb, firstUserEdit);
                SaveChanges(secondDb, secondUserEdit);
            }
        }

        private static void OpenFirstConnection()
        {
            using (var firstDb = new NewsContext())
            {
                Console.WriteLine("First User: ");
                PrintNews(firstDb);
                OpenSecondConnection(firstDb);
            }
        }

        private static void SaveChanges(NewsContext db, string newContent)
        {
            try
            {
                var firstNews = db.News.FirstOrDefault();
                firstNews.Content = newContent;
                db.SaveChanges();
                Console.WriteLine("//////////////////////////////////////");
                Console.WriteLine("        Your data is in database      ");
                Console.WriteLine("//////////////////////////////////////");
            }
            catch (Exception)
            {
                Console.WriteLine("//////////////////////////////////////");
                Console.WriteLine("Some one else make changes before you!");
                Console.WriteLine("//////////////////////////////////////");
                using (var newDb = new NewsContext())
                {
                    var finalContent = GetUserEdit(newDb, " ");
                    SaveChanges(newDb, finalContent);
                }
            }
        }

        private static string GetUserEdit(NewsContext db, string content)
        {
            string changedText = "";
            if (content == "")
            {
                var firstNews = db.News.FirstOrDefault();
                Console.WriteLine("***********************************************************");
                Console.WriteLine("                          Edit News #{0}", firstNews.Id);
                Console.WriteLine("***********************************************************");
                SendKeys.SendWait(firstNews.Content);
                changedText = Console.ReadLine();
            }
            else
            {
                var firstNews = db.News.FirstOrDefault();
                Console.WriteLine("***********************************************************");
                Console.WriteLine(" New content is: {0}", firstNews.Content);
                Console.WriteLine("***********************************************************");
                SendKeys.SendWait(firstNews.Content);
                changedText = Console.ReadLine();
            }
           
            return changedText;
        }

        private static void PrintNews(NewsContext db)
        {
            var firstNews = db.News.FirstOrDefault();
            Console.WriteLine("===========================================================");
            Console.WriteLine("                          News #{0}",firstNews.Id);
            Console.WriteLine("===========================================================");
            Console.WriteLine(" * {0} * ",firstNews.Content);
            Console.WriteLine("===========================================================");
        }
    }
}
