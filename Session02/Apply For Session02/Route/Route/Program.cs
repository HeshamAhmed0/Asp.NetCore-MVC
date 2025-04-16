using Microsoft.AspNetCore.Mvc;

namespace Route
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(name: "First",
                                   pattern: "{controller}/{action}/{Id?}",
                                   defaults: new { Controller="Home",Action = "Index" }
                                   );

            app.Run();
        }
    }
}
