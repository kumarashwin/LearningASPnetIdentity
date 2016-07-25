using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(LearningASPnetIdentity.Startup))]
namespace LearningASPnetIdentity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}