using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using project02.Contllorer;

namespace project02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            #region Configure Servies
             builder.Services.AddControllersWithViews();
            #endregion
                   
            var app = builder.Build();


            #region SEGMENTS

            #region Static SEGMENTS
            //app.MapGet("/", () => "Hello World!");

            #endregion

            #region Variable SEGMENTS
            //app.MapGet("/{name}", async Hesham =>
            //{
            //    var Name = Hesham.GetRouteValue("name");
            // await  Hesham.Response.WriteAsync($"Hello {Name}");
            //});

            #endregion

            #region Mixed Segment
            //app.MapGet("/X{name}", async Hesam =>
            //{
            //    await Hesam.Response.WriteAsync($"Hello {Hesam.Request.RouteValues["name"]}");
            //});
            #endregion

            #region Controller Routing
            //app.MapControllerRoute(name: "First",
            //                       pattern : "/{Controller}/{action}/{Id?}",
            //                       defaults : new { Controller = "ViewContllorer" ,action = "GetView" },
            //                       constraints: new { Id = @"\d{2}"});

            // خلي بالك منعني علامه الاستفهام الي جمب 
            //ID 
            // بتعرفك انها optional       عادي تدخلها وعادي لا 



            app.MapControllerRoute(name: "First",
                                   pattern : "/{Controller}/{action}/{Id:regex(^\\d{{7}}$)?}",
                                   defaults: new { Controller ="ViewContllorer",action = "GetAction" }); 
            #endregion

            #endregion
            app.Run();
        }
    }
}
