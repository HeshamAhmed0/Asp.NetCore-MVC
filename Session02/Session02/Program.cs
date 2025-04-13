namespace Session02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/",()=>$"Hello World");
            app.MapControllerRoute(name:"First",
                                   pattern:"/{controller}/{action}/{Id?}",
                                   defaults:new {Controller = "ApplicationController", action = "GetAction" });
            app.Run();
        }
    }
}
