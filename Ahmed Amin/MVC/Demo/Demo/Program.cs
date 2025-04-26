using Demo.Controllers;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(name : "Default",
                pattern:"/{Controller}/{Action}/{Id?}"
                );

            app.Run();
        }
    }
}
