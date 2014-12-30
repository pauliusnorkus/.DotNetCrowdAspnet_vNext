using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNet.Diagnostics;

namespace BasicWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseErrorPage(ErrorPageOptions.ShowAll);
            
            app.Run(async context =>
            {
                //throw new Exception();
                if (context.Request.Path.Value == "/api")
                {
                    context.Response.ContentType = "text/json";
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(new List<string> { "value1", "value2" }));
                }
                else
                {
                    await context.Response.WriteAsync("Home page");
                }
            });
        }
    }
}
