﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BlogSystem.Services.Startup))]

namespace BlogSystem.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
