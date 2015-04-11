using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using MusicSystem.Data;
using MusicSystem.Data.Migrations;

namespace MusicSystem.WebClient
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MusicSystemEntities, 
                    MusicSystemMigrationConfiguration>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
