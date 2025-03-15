using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Assgiment02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
        //   app.MapGet("/", () => "Hello World!");
            #region variable segmrnt
            //app.MapGet("/{name}", async context =>
            //{
            //    var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($" Hello {Name}");
            //});
            #endregion

            #region Mixed segmrnt
            //app.MapGet("/{name}", async context =>
            //{

            //    await context.Response.WriteAsync($" Hello {context.Request.RouteValues["name"]}");
            //});
            #endregion

            #region Make Routing To Controller 
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Movies}/{action=Index}/{Id:regex(\\d{{2}})?}" // we can add default here and constraints
               // defaults: new{ controller = "Movies",  action = "Index"  },

                //constraints: new { Id = new IntRouteConstraint() } // id must be intger

                // constraints: new { Id = @"\d{2}" } // id will be integer and jsut consist from 2 digit onely
                );
            #endregion
            app.Run();
        }
    }
}
