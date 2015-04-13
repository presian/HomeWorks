namespace IntegrationTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Microsoft.Owin.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Owin;

    using News.Data;
    using News.Models;
    using NewsServices;

    [TestClass]
    public class IntegrationTesting
    {
        private TestServer httpTestServer;
        private HttpClient httpClient;

        [TestInitialize]
        public void TestInit()
        {
            // Start OWIN testing HTTP server with Web API support
            this.httpTestServer = TestServer.Create(appBuilder =>
            {
                var config = new HttpConfiguration();
                WebApiConfig.Register(config);
                appBuilder.UseWebApi(config);
            });
            this.httpClient = httpTestServer.HttpClient;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.httpTestServer.Dispose();
        }


        [TestMethod]
        public void GetEmptyListOfNews_ShouldReturn200_Ok()
        {
            // Arrange
            this.CleanDatabase();
            // Act
            var httpResponse = httpClient.GetAsync("/api/news").Result;
            var news = httpResponse.Content.ReadAsAsync<List<NewsItem>>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, httpResponse.StatusCode);
            Assert.AreEqual(httpResponse.Content.Headers.ContentType.MediaType, "application/json");
            Assert.AreEqual(0, news.Count);
        }

        [TestMethod]
        public void GetListOfNews_ShouldReturn200_Ok()
        {
            
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            db.News.Add(new NewsItem
            {
                Title = "First added",
                Content = "FirstContent",
                PublishDate = DateTime.Now
            });

            db.News.Add(new NewsItem
            {
                Title = "Second added",
                Content = "SecondContent",
                PublishDate = DateTime.Now.AddDays(3)
            });

            db.SaveChanges();

            // Act
            var httpResponse = httpClient.GetAsync("/api/news").Result;
            var news = httpResponse.Content.ReadAsAsync<List<NewsItem>>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, httpResponse.StatusCode);
            Assert.AreEqual(httpResponse.Content.Headers.ContentType.MediaType, "application/json");
            Assert.AreEqual(2, news.Count);
        }

        [TestMethod]
        public void AddNews_ShouldReturn201_Created()
        {
           
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            var postContent = new FormUrlEncodedContent(new[] 
            {
                new KeyValuePair<string, string>("Title", "Title"),
                new KeyValuePair<string, string>("Content", "Content"), 
            });

            // Act
            var httpResponse = httpClient.PostAsync("/api/news", postContent).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.Created, httpResponse.StatusCode);
            Assert.AreEqual(httpResponse.Content.Headers.ContentType.MediaType, "application/json");
            Assert.AreEqual("Title", news.Title);
            Assert.AreEqual("Content", news.Content);
            Assert.AreEqual(1, db.News.Count());
        }

        [TestMethod]
        public void AddNews_InvalidData_ShouldReturn400_BadRequest()
        {
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            var postContent = new FormUrlEncodedContent(new[] 
            {
                new KeyValuePair<string, string>("Title", "Title"),
            });

            // Act
            var httpResponse = httpClient.PostAsync("/api/news", postContent).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, httpResponse.StatusCode);
            Assert.AreEqual(httpResponse.Content.Headers.ContentType.MediaType, "application/json");
            Assert.AreEqual(0, db.News.Count());
        }

        [TestMethod]
        public void UpdateNews_InvalidData_ShouldReturn400_BadRequest()
        {
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            db.News.Add(new NewsItem
            {
                Title = "First added",
                Content = "FirstContent",
                PublishDate = DateTime.Now
            });

            db.News.Add(new NewsItem
            {
                Title = "Second added",
                Content = "SecondContent",
                PublishDate = DateTime.Now.AddDays(3)
            });

            db.SaveChanges();

            var id = db.News.First().Id;
            var postContent = new FormUrlEncodedContent(new[] 
            {
                new KeyValuePair<string, string>("Title", "Title"),
                new KeyValuePair<string, string>("Id", id.ToString()), 
            });

            
            var endpointUrl = string.Format("/api/news/{0}", id);
            // Act
            var httpResponse = httpClient.PutAsync(endpointUrl, postContent).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, httpResponse.StatusCode);
            Assert.AreEqual(httpResponse.Content.Headers.ContentType.MediaType, "application/json");
        }

        [TestMethod]
        public void UpdateNews_ShouldReturn200_Ok()
        {
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            db.News.Add(new NewsItem
            {
                Title = "First added",
                Content = "FirstContent",
                PublishDate = DateTime.Now
            });

            db.News.Add(new NewsItem
            {
                Title = "Second added",
                Content = "SecondContent",
                PublishDate = DateTime.Now.AddDays(3)
            });

            db.SaveChanges();

            var id = db.News.First().Id;
            var postContent = new FormUrlEncodedContent(new[] 
            {
                new KeyValuePair<string, string>("Title", "Title"),
                new KeyValuePair<string, string>("Content", "Content"), 
                new KeyValuePair<string, string>("Id", id.ToString()), 
            });


            var endpointUrl = string.Format("/api/news/{0}", id);
            // Act
            var httpResponse = httpClient.PutAsync(endpointUrl, postContent).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, httpResponse.StatusCode);
        }

        [TestMethod]
        public void DeleteNews_InvalidData_ShouldReturn400_BadRequest()
        {
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            db.News.Add(new NewsItem
            {
                Title = "First added",
                Content = "FirstContent",
                PublishDate = DateTime.Now
            });

            db.News.Add(new NewsItem
            {
                Title = "Second added",
                Content = "SecondContent",
                PublishDate = DateTime.Now.AddDays(3)
            });

            db.SaveChanges();

            var id = db.News.Max(n=>n.Id) + 10;

            var endpointUrl = string.Format("/api/news/{0}", id);
            // Act
            var httpResponse = httpClient.DeleteAsync(endpointUrl).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.NotFound, httpResponse.StatusCode);
        }

        [TestMethod]
        public void DeleteNews_ShouldReturn200_Ok()
        {
            // Arrange
            CleanDatabase();
            var db = new ApplicationDbContext();
            db.News.Add(new NewsItem
            {
                Title = "First added",
                Content = "FirstContent",
                PublishDate = DateTime.Now
            });

            db.News.Add(new NewsItem
            {
                Title = "Second added",
                Content = "SecondContent",
                PublishDate = DateTime.Now.AddDays(3)
            });

            db.SaveChanges();

            var id = db.News.Max(n => n.Id);

            var endpointUrl = string.Format("/api/news/{0}", id);
            // Act
            var httpResponse = httpClient.DeleteAsync(endpointUrl).Result;
            var news = httpResponse.Content.ReadAsAsync<NewsItem>().Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, httpResponse.StatusCode);
            Assert.AreEqual(1, db.News.Count());
        }



        private void CleanDatabase()
        {
            var context = new ApplicationDbContext();
            foreach (var newsItem in context.News)
            {
                context.News.Remove(newsItem);
            }

            context.SaveChanges();
        }
    }
}
