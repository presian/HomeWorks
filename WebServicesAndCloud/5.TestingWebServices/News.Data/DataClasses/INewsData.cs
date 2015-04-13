namespace News.Data.DataClasses
{
    using Repositories;

    public interface INewsData
    {
        NewsRepository NewsRepository { get; }
        int SaveChages();
    }
}
