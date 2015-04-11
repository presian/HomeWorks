namespace NewsConsoleClient
{
    public static class Utility
    {
        public const string BaseUrl = "http://api.feedzilla.com/v1/";
        public const string QueryString =
            "articles/search.json?q={keyword}&count={count}&title_only=1";

        // This constants are for comments method
        public const string CategoriesQuery = "/categories.json";
        public const string ArticlesQuery = "categories/{categoryId}/articles.json";

        
    }
}
