//Problem 2.	Play with ToList()
//Using Entity Framework select all ads from the database, then invoke ToList(), then filter the categories by status "Published", then select ad title, category and town, then invoke ToList() and finally order the ads by publish date. Rewrite the same in more optimized way and compare the performance.
//Submit as result both versions of your program: the slow version and the optimized version. Submit also screenshots of the executed queries caught by the SQL ExpressProfiler.


namespace PlayWithToList
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using UsingDB;

    class Problem2
    {
        static void Main()
        {
//            UnOptimized();
//            Optimized();
        }

        private static void Optimized()
        {
            using (var db = new AdsEntities())
            {
                foreach (var ad in db.Ads
                    .Include(a => a.AdStatus.Status)
                    .Include(a => a.Category)
                    .Include(a => a.Town)
                    .Where(a => a.AdStatus.Status == "Published")
                    .Select(a => new
                    {
                        a.Title,
                        Category = a.CategoryId == null ? "No category" : a.Category.Name,
                        Town = a.TownId == null ? "No town" : a.Town.Name,
                        a.Date
                    })
                    .ToList()
                    .OrderBy(a => a.Date))
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("                 ===   #{0}   ===                  ", ad.Title);
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Category: {0}\nTown: {1}\nUser: {2}",
                        ad.Title,
                        ad.Category,
                        ad.Town);
                }
            }
        }

        private static void UnOptimized()
        {
            using (var db = new AdsEntities())
            {
                foreach (var ad in db.Ads
                    .ToList()
                    .Where(a => a.AdStatus.Status == "Published")
                    .Select(a =>new 
                        {
                            a.Title,
                            Category = a.CategoryId == null ? "No category" : a.Category.Name,
                            Town = a.TownId == null ? "No town" : a.Town.Name,
                            a.Date
                        })
                    .ToList()
                    .OrderBy(a => a.Date))
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("                 ===   #{0}   ===                  ", ad.Title);
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Category: {0}\nTown: {1}\nUser: {2}",
                        ad.Title,
                        ad.Category,
                        ad.Town);
                }
            }
        }
    }
}
