namespace NewsConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Classes;

    class Client
    {
        static void Main()
        {
            PrintingStartMessage();
            var keyword = GetUserKeyword();
            var count = GetUserCount();
            var news = GetNewsByKeywordAndCount(keyword, count);

            PrintAllNews(news);


            // Get categories and articles for spcific category

            // var categories = GetCategoriesList();
            // PrintingCategoriesList(categories);
            // int categoryId = GetUserChoice(categories);
            // GetNewsByCategoryId(categoryId);
            // var news = GetNewsByCategoryId(categoryId);
            // PrintAllNews(news, categoryId);

        }

        private static NewsLsit GetNewsByKeywordAndCount(string keyword, int count)
        {
            var news = WebClient.GetNewsByKeywordAndCount(keyword, count);
            return news;
        }

        private static int GetUserCount()
        {
            int count = 0;
            while (true)
            {
                Console.Write("Pease enter a count of dysplayed news: ");
                var userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsDigit))
                {
                    count = int.Parse(userInput);
                    if (count > 0 && count <= 100)
                    {
                        break;
                    }
                }

                Console.WriteLine("Your input is invalid please try again ;)");
                Console.WriteLine("Should be number betwen 1 and 100");
            }

            return count;
        }

        private static string GetUserKeyword()
        {
            string keyword;
            while (true)
            {
                Console.Write("Pease enter a keyword: ");
                var userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    keyword = userInput;
                    break;
                }

                Console.WriteLine("Your input is invalid please enter valid word ;)");
            }

            return keyword;
        }

        private static void PrintAllNews(NewsLsit news)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("                         News :)");
            Console.WriteLine("=====================================================");
            foreach (var article in news.Articles)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine(article.ToString());
                Console.WriteLine("-----------------------------------------------------");
            }
        }

        private static void PrintingStartMessage()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("     Hello user :)");
            Console.WriteLine("=====================");
        }

        private static NewsLsit GetNewsByCategoryId(int categoryId)
        {
            var news = WebClient.GetNewsByCategoryId(categoryId);
            return news;
        }

        private static int GetUserChoice(IList<Category> categories)
        {
            int id = 0;
            while (true)
            {
                Console.Write("Pease enter a count of articles: ");
                var userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsDigit))
                {
                    id = int.Parse(userInput);
                    if (categories.Any(c=>c.Id == id))
                    {
                        break;
                    }
                }

                Console.WriteLine("Your input is invalid please try again ;)");
            }

            return id;
        }

        private static void PrintingCategoriesList(IList<Category> categories)
        {
            foreach (var category in categories.OrderBy(c=>c.Id))
            {
                Console.WriteLine(category.ToString());
            }
        }

        private static IList<Category> GetCategoriesList()
        {
            var categories = WebClient.GetCategories();
            return categories;
        }
    }
}
