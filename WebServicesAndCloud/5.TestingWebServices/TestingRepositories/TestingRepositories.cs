namespace TestingRepositories
{
    using System;
    using System.Data.Entity.Validation;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using News.Data;
    using News.Data.Repositories;
    using News.Models;
    
    [TestClass]
    public class TestingRepositories
    {
        private NewsRepository repo = new NewsRepository(new ApplicationDbContext());

        [TestInitialize]
        public void TestInit()
        {
            foreach (var newsItem in repo.GetAll())
            {
                this.repo.Delete(newsItem);
            }

            this.repo.SaveChanges();
        }

        [TestMethod]
        public void ListAllNewsItem_ShouldReturnEmptyList()
        {
            Assert.AreEqual(0, this.repo.GetAll().Count());
        }

        [TestMethod]
        public void ListAllNewsItem_ShouldReturnListWithTwoMembers()
        {
            this.repo.Add(new NewsItem
            {
                Title = "Taralala",
                Content = "Lalalalalala",
                PublishDate = DateTime.Now
            });

            this.repo.Add(new NewsItem
            {
                Title = "asdkljaldjasld",
                Content = "asdlkas;dkas;dkas;dkasdka;sdka;skladfh;aklsj kljoidflkjal",
                PublishDate = DateTime.Now.AddDays(-1)
            });

            this.repo.SaveChanges();

            Assert.AreEqual(2, this.repo.GetAll().Count());
        }

        [TestMethod]
        public void AddNewsItem_ThenGetTheNewItem_SouldBeTheSame()
        {
            var news = (new NewsItem
            {
                Title = "Taralala",
                Content = "Lalalalalala",
                PublishDate = DateTime.Now
            });

            this.repo.Add(news);
            this.repo.SaveChanges();

            Assert.AreEqual(news, this.repo.GetAll().FirstOrDefault());
        }

        // Content field is mandatory
        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateNewsItemWithoutContentData_ShouldThrowException()
        {
            this.repo.Add(new NewsItem
            {
                Title = "Taralala",
                PublishDate = DateTime.Now
            });

            this.repo.SaveChanges();
        }

        // Title field is mandatory
        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateNewsItemWithoutTitleData_ShouldThrowException()
        {
            this.repo.Add(new NewsItem
            {
                Content = "Taralala",
                PublishDate = DateTime.Now
            });

            this.repo.SaveChanges();
        }

        [TestMethod]
        public void ModifyExistingNewsItem_WithValidData()
        {
            var news = (new NewsItem
            {
                Title = "Taralala",
                Content = "Lalalalalala",
                PublishDate = DateTime.Now
            });

            this.repo.Add(news);
            this.repo.SaveChanges();

            var existingNews = this.repo.GetAll().FirstOrDefault();
            existingNews.Title = "New title";
            this.repo.Update(news);
            this.repo.SaveChanges();

            var itemAfterChange = this.repo.GetAll().FirstOrDefault();

            Assert.AreEqual("New title", itemAfterChange.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void ModifyExistingNewsItem_WithInvalidData_ShouldThrowException()
        {
            var news = (new NewsItem
            {
                Title = "Taralala",
                Content = "Lalalalalala",
                PublishDate = DateTime.Now
            });

            this.repo.Add(news);
            this.repo.SaveChanges();

            var existingNews = this.repo.GetAll().FirstOrDefault();
            existingNews.Title = "New";
            this.repo.Update(news);
            this.repo.SaveChanges();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ModifyUnExistingNewsItem_ShouldThrowException()
        {
            var unexistingNews = this.repo.FindById(1);
            unexistingNews.Title = "New";
            this.repo.Update(unexistingNews);
            this.repo.SaveChanges();
        }

        [TestMethod]
        public void DeleteExistingNewsItem()
        {
            var news = (new NewsItem
            {
                Title = "Taralala",
                Content = "Lalalalalala",
                PublishDate = DateTime.Now
            });

            this.repo.Add(news);
            this.repo.SaveChanges();

            var existingNews = this.repo.GetAll().FirstOrDefault();
            this.repo.Delete(existingNews);
            this.repo.SaveChanges();

            Assert.AreEqual(0, this.repo.GetAll().Count());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteUnExistingNewsItem_ShouldThrowException()
        {
            this.repo.DeleteById(1);
            this.repo.SaveChanges();
        }
    }
}
