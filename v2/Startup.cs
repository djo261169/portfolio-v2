﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(v2.Startup))]
namespace v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
