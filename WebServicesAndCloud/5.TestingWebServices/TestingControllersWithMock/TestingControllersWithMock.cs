namespace TestingControllersWithMock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Web.Http;
    using System.Web.Http.Routing;
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;
    using News.Data.Repositories;
    using News.Models;
    using NewsServices.Controllers;
    using Newtonsoft.Json;
    
    [TestClass]
    public class TestingControllersWithMock
    {
        [TestMethod]
        public void Testing_GetAllmethod_ShouldSucceed()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();
            var news  = new List<NewsItem>
            {
                new NewsItem
                {
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(r => r.GetAll()).Returns(news.AsQueryable());
            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller,  "NewsController");
            var result = controller.GetNewsItems().ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            var content = result.Content.ReadAsStringAsync().Result;
            var resultNews = JsonConvert.DeserializeObject<List<NewsItem>>(content);
            for (int i = 0; i < resultNews.Count; i++)
            {
                Assert.AreEqual(news[i].Id, resultNews[i].Id);
                Assert.AreEqual(news[i].Title, resultNews[i].Title);
                Assert.AreEqual(news[i].Content, resultNews[i].Content); 
                Assert.AreEqual(news[i].PublishDate, resultNews[i].PublishDate);
            }
        }

        [TestMethod]
        public void PostNewsItem_WithValidData_ShouldSucceed()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(repo => repo.Add(It.IsAny<NewsItem>()))
                .Callback((NewsItem n) => news.Add(n));

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller,  "NewsController");

            var newNewsItem = new NewsItem() { 
                Title = "ThirdNews",
                Content = "ThirdNewsContent",
                PublishDate = DateTime.Now.AddDays(8)
            };
            var result = controller.PostNewsItem(newNewsItem).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(newNewsItem.Title, news.Last().Title);
            Assert.AreEqual(newNewsItem.Content, news.Last().Content);
            Assert.IsNotNull(news.Last().PublishDate);
        }

        [TestMethod]
        public void PostNewsItem_WithInvalidData_ShouldReturnBadRequest()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>()
            {
                new NewsItem
                {
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(repo => repo.Add(It.IsAny<NewsItem>()))
                .Callback((NewsItem n) => news.Add(n));

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");
            controller.ModelState.AddModelError("key", "errorMessage");

            var newNewsItem = new NewsItem()
            {
                Content = "ThirdNewsContent",
                PublishDate = DateTime.Now.AddDays(8)
            };

            var result = controller.PostNewsItem(newNewsItem).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
        }

        [TestMethod]
        public void PutNewsItem_WithValidData_ShouldSucceed()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Id = 1,
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(repo => repo.Update(It.IsAny<NewsItem>()))
                .Callback((NewsItem n) => news[news.FindIndex(a=>a.Id == n.Id)] = n);

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");

            var existingNewsItem = news.SingleOrDefault(n => n.Title == "FirstNews");
            existingNewsItem.Title = "FirstNewsUpdatet";
            var id = existingNewsItem.Id;
            var result = controller.PutNewsItem(id, existingNewsItem).ExecuteAsync(new CancellationToken()).Result;

            var itemAfterUpdate = news.SingleOrDefault(n => n.Id == id);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(itemAfterUpdate.Title, "FirstNewsUpdatet");
        }


        [TestMethod]
        public void PutNewsItem_WithInvalidData_ShouldReturnBadRequest()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Id = 1,
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(repo => repo.Update(It.IsAny<NewsItem>()))
                .Callback((NewsItem n) => news[news.FindIndex(a => a.Id == n.Id)] = n);

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");
            controller.ModelState.AddModelError("key", "errorMessage");

            var existingNewsItem = news.SingleOrDefault(n => n.Title == "FirstNews");
            existingNewsItem.Title = "Fi";
            var id = existingNewsItem.Id;
            var result = controller.PutNewsItem(id, existingNewsItem).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
        }

        [TestMethod]
        public void PutNonExitingNewsItem_ShouldReturnBadRequest()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Id = 1,
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            repoMock.Setup(repo => repo.Update(It.IsAny<NewsItem>()))
                .Callback((NewsItem n) => news[news.FindIndex(a => a.Id == n.Id)] = n);

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");
            controller.ModelState.AddModelError("key", "errorMessage");

            var existingNewsItem = news.SingleOrDefault(n => n.Title == "FirstNews");
            var result = controller.PutNewsItem(4, existingNewsItem).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
        }

        [TestMethod]
        public void DeleteExitingNewsItem_ShouldReturnOk()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Id = 1,
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            int id = 1;
            repoMock.Setup(r => r.FindById(id)).Returns(news.AsQueryable().SingleOrDefault(item => item.Id == id));
            repoMock.Setup(repo => repo.Delete(It.Is((NewsItem n)=>n.Id == id)))
                .Callback((NewsItem n) => news.RemoveAt(news.FindIndex(x=> x.Id == n.Id)));

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");

            var result = controller.DeleteNewsItem(id).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(2, news.Count);
        }

        [TestMethod]
        public void DeleteNonExitingNewsItem_ShouldReturnNotFound()
        {
            var repoMock = new Mock<IRepository<NewsItem>>();

            var news = new List<NewsItem>
            {
                 new NewsItem
                {
                    Id = 1,
                    Title = "FirstNews",
                    Content = "FirstNewsContent",
                    PublishDate = DateTime.Now
                },
                new NewsItem
                {
                    Id = 2,
                    Title = "SecondNews",
                    Content = "SecondNewsContent",
                    PublishDate = DateTime.Now.AddDays(-3)
                },
                new NewsItem
                {
                    Id = 3,
                    Title = "ThirdNews",
                    Content = "ThirdNewsContent",
                    PublishDate = DateTime.Now.AddDays(-25)
                }
            };

            int id = 6;
            repoMock.Setup(r => r.FindById(id)).Returns(news.AsQueryable().SingleOrDefault(item => item.Id == id));
            repoMock.Setup(repo => repo.Delete(It.Is((NewsItem n) => n.Id == id)))
                .Callback((NewsItem n) => news.RemoveAt(news.FindIndex(x => x.Id == n.Id)));

            var controller = new NewsController(repoMock.Object);
            this.SetupController(controller, "NewsController");

            var result = controller.DeleteNewsItem(id).ExecuteAsync(new CancellationToken()).Result;

            Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
            Assert.AreEqual(3, news.Count);
        }

        private void SetupController(ApiController controller, string controllerName)
        {
            string serverUrl = "http://sample-url.com";

            // Setup the Request object of the controller
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(serverUrl)
            };
            controller.Request = request;

            // Setup the configuration of the controller
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            controller.Configuration = config;

            // Apply the routes to the controller
            controller.RequestContext.RouteData = new HttpRouteData(
                route: new HttpRoute(),
                values: new HttpRouteValueDictionary
                {
                    { "controller", controllerName }
                });
        }
    }
}
