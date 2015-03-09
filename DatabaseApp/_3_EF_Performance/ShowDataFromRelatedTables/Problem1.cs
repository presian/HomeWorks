//Problem 1.	Show Data from Related Tables
//You are given a MS SQL Server database "Ads" holding advertisements, organized by categories, towns and users, available as SQL script.
//Using Entity Framework write a SQL query to select all ads from the database and later print their title, status, category, town and user. Do not use Include(…) for the relationships of the Ads. Check how many SQL commands are executed with the SQL ExpressProfiler (or similar tool).
//Add Include(…) to select statuses, categories, towns and users along with all ads. Compare the number of executed SQL statements and the performance before and after adding Include(…).
//Submit as result both versions of your program: with and without Include(…). Submit also screenshots of the executed queries caught by the SQL ExpressProfiler.


namespace ShowDataFromRelatedTables
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using UsingDB;

    class Problem1
    {
        static void Main()
        {
//            WithoutInclude();
//            WithInclude();
        }

        private static void WithInclude()
        {
            using (var db = new AdsEntities())
            {
                foreach (var ad in db.Ads
                    .Include(a => a.Category)
                    .Include(a => a.Town)
                    .Include(a => a.AspNetUser)
                    .Include(a => a.AdStatus))
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("                 ===   #{0}   ===                  ", ad.Id);
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Titele: {0}\nStatus: {1}\nCategory: {2}\nTown: {3}\nUser: {4}",
                        ad.Title,
                        ad.AdStatus.Status,
                        ad.CategoryId == null ? "No category" : ad.Category.Name,
                        ad.TownId == null ? "No town" : ad.Town.Name,
                        ad.AspNetUser.UserName);
                }
            }
        }

        private static void WithoutInclude()
        {
            using (var db = new AdsEntities())
            {
                foreach (var ad in db.Ads)
                {
                    var category = db.Categories
                        .Where(c => c.Id == ad.CategoryId)
                        .Select(c => c.Name)
                        .FirstOrDefault();

                    var town = db.Towns
                        .Where(t => t.Id == ad.TownId)
                        .Select(t => t.Name)
                        .FirstOrDefault();

                    Console.WriteLine("====================================================");
                    Console.WriteLine("                 ===   #{0}   ===                  ", ad.Id);
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Titele: {0}\nStatus: {1}\nCategory: {2}\nTown: {3}\nUser: {4}",
                        ad.Title,
                        ad.AdStatus.Status,
                        ad.CategoryId == null ? "No category" : ad.Category.Name,
                        ad.TownId == null ? "No town" : ad.Town.Name,
                        ad.AspNetUser.UserName);
                }
            }
        }
    }
}
