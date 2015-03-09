namespace SelectEverything_vs_SelectCertainColumns
{
    using System;
    using System.Linq;
    using UsingDB;

    class Problem3
    {
        static void Main()
        {
            SelectAll();
            SelectOnlyTitle();
        }

        private static void SelectOnlyTitle()
        {
            using (var db = new AdsEntities())
            {
                var timer = DateTime.Now;
                foreach (var ad in db.Ads.Select(a => a.Title))
                {
                    Console.WriteLine(ad);
                }

                Console.WriteLine("================================");
                Console.WriteLine("* {0} *", DateTime.Now - timer);
                Console.WriteLine("================================");
            }
        }

        private static void SelectAll()
        {
            using (var db = new AdsEntities())
            {
                var timer = DateTime.Now;
                foreach (var ad in db.Ads)
                {
                    Console.WriteLine(ad.Title);
                }

                Console.WriteLine("================================");
                Console.WriteLine("* {0} *",DateTime.Now - timer);
                Console.WriteLine("================================");
            }
        }
    }
}
